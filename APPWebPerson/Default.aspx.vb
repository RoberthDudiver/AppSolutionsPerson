Public Class Formulario_web1
    Inherits System.Web.UI.Page
    Dim server As ServicioSoapAsmx.Service1SoapClient = New ServicioSoapAsmx.Service1SoapClient

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Loaddata()
    End Sub
    Function Loaddata()
        'cargamos la data
        GridView.AutoGenerateColumns = False
        GridView.DataSource = server.GetAllVWPeopleGeneralView().ToList()
        GridView.DataBind()
    End Function

    Protected Sub GridView_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles GridView.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Attributes("onmouseover") = "this.style.backgroundColor='aquamarine';"
            e.Row.Attributes("onmouseout") = "this.style.backgroundColor='white';"
            e.Row.ToolTip = "Seleccionar"
        End If
    End Sub

    Protected Sub GridView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView.SelectedIndexChanged
        

    End Sub
    Public Property Seleccionado As Integer
        Get

            If ViewState("Seleccion") Is Nothing Then
                ViewState("Seleccion") = 0
            End If

            Return CType(ViewState("Seleccion"), Integer)
        End Get
        Set(ByVal value As Integer)
            ViewState("Seleccion") = value
        End Set
    End Property
    Protected Sub GridView_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles GridView.SelectedIndexChanging

        Dim ID As Integer = server.GetAllVWPeopleGeneralView.ToList()(e.NewSelectedIndex).IDPeople
        Dim People As ServicioSoapAsmx.DTPeople = server.GetPeopleByID(ID)
        Name.Text = People.Name
        Seleccionado = People.IDPeople
        SecondName.Text = People.SecondName
        BirthDate.Text = People.BirthDate.Value.ToString("dd/MM/yyyy")
        Panel1.Visible = True
        Eliminar.Visible = True
        If (People.Sex) Then
            Femenino.Checked = True
            Masculino.Checked = False
        Else
            Femenino.Checked = False
            Masculino.Checked = True
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
       Clean()
        Panel1.Visible = False
        Agregar.Visible = True
        GridView.Visible = True
        Eliminar.Visible = False
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Person As ServicioSoapAsmx.DTPeople = New ServicioSoapAsmx.DTPeople()
            Person.Name = Name.Text
            If (Femenino.Checked) Then
                Person.Sex = True

            Else
                Person.Sex = False

            End If

            Person.SecondName = SecondName.Text
            Person.BirthDate = BirthDate.Text
            Person.UpdateUpd = Date.Now
            Person.IDPeople = Seleccionado
            Try
                server.SetPeople(Person)

                Loaddata()
                Clean()
                GridView.Visible = True
            Catch ex As Exception


            End Try
        Catch ex As Exception

        End Try
    End Sub
    Function Clean()
        Name.Text = ""
        SecondName.Text = ""
        BirthDate.Text = ""
        Seleccionado = 0
    End Function
    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
      Clean()
    End Sub
    Protected Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        Agregar.Visible = True
        Panel1.Visible = True
        GridView.Visible = False
        Eliminar.Visible = False
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If (Seleccionado <> 0) Then
            Try
                server.DeletetDTPeople(Seleccionado)

                Loaddata()
                Clean()
                GridView.Visible = True
            Catch ex As Exception


            End Try
        End If

    End Sub
End Class