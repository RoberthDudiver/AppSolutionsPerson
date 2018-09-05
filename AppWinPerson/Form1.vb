
Public Class PersonaFrm
    Dim server As ServicioSoapAsmx.Service1SoapClient = New ServicioSoapAsmx.Service1SoapClient

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load()

        TypeDocumentID.DataSource = server.GetDTDocumentsType().ToList()
        TypeDocumentID.DisplayMember = "TypeDocument"
        TypeDocumentID.ValueMember = "TypeDocumentID"

        CountryID.DataSource = server.GetDTCountries().ToList()
        CountryID.DisplayMember = "Country"
        CountryID.ValueMember = "CountryID"
    End Sub

    Function Load()
        GridView.DataSource = server.GetAllPeopleView().ToList()

    End Function

    Private Sub GridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView.CellContentClick



    End Sub
    Dim Itemselec As ServicioSoapAsmx.VWInfoPeople
    Private Sub GridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView.CellClick

        Itemselec = CType(GridView.SelectedRows(0).DataBoundItem(), ServicioSoapAsmx.VWInfoPeople)
        Name1.Text = Itemselec.Name

        SecondName.Text = Itemselec.SecondName
        BirthDate.Value = Itemselec.BirthDate
        CountryID.SelectedValue = Itemselec.CountryID.Value
        TypeDocumentID.SelectedValue = Itemselec.TypeDocumentID
        DocumentID.Text = Itemselec.DocumentID
        PrincipalPhone.Text = Itemselec.PrincipalPhone
        Addres.Text = Itemselec.Addres
    End Sub

    Function Clean()
        Itemselec = Nothing
        Name1.Renew()
        SecondName.Renew()
        BirthDate.Value = Today
        CountryID.SelectedIndex = 0
        PrincipalPhone.Renew()
        TypeDocumentID.SelectedIndex = 0
        DocumentID.Renew()
        Addres.Renew()
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clean()
        Load()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If (Name1.change And SecondName.change And DocumentID.change) Then
            If MsgBox("¿Quiere guardar el registro?", MsgBoxStyle.Question, "Advertencia") = MsgBoxResult.Ok Then
                Dim Person As ServicioSoapAsmx.DTPeople = New ServicioSoapAsmx.DTPeople()
                Person.Name = Name1.Text
                If (IsNothing(Itemselec) = False) Then
                    Person.IDPeople = Itemselec.IDPeople

                End If
                Person.SecondName = SecondName.Text
                Person.PrincipalPhone = PrincipalPhone.Text
                Person.Addres = Addres.Text
                Person.CountryID = CountryID.SelectedValue
                Person.DocumentID = DocumentID.Text
                Person.TypeDocumentID = TypeDocumentID.SelectedValue
                Person.BirthDate = BirthDate.Value
                Person.UpdateUpd = Date.Now
                Try
                    server.SetPeople(Person)
                    MsgBox("Se ha guardado  con exito")
                    Clean()
                    Load()
                Catch ex As Exception
                    MsgBox("Error" & ex.Message)

                End Try

            End If
        End If



    End Sub


    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MsgBox("¿Quiere eliminar?", MsgBoxStyle.Question, "Advertencia") = MsgBoxResult.Ok Then
            Dim Itemselec = CType(GridView.SelectedRows(0).DataBoundItem(), ServicioSoapAsmx.VWInfoPeople)
            Try
                server.DeletetDTPeople(Itemselec.IDPeople)
                MsgBox("Se ha eliminado  con exito")
                Clean()
                Load()
            Catch ex As Exception
                 MsgBox("Error" & ex.Message)
            End Try
          
        End If
    End Sub
End Class
