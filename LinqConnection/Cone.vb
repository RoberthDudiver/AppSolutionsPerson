
Public Class Cone

    Shared bd As DbmlClassDataContext

    Private Shared Sub connect()
        Dim stringconnect As String =
             Global.LinqConnection.My.MySettings.Default.DBPeopleConnectionString
        Try
            bd = New DbmlClassDataContext(stringconnect)
        Catch
            disconnet()
            bd = New DbmlClassDataContext(stringconnect)
        End Try
    End Sub

    Public Shared Function DeletetDTPeople(ByVal Id As String) As DTPeople
        connect()
        Dim item = bd.DTPeoples.SingleOrDefault(Function(x) x.IDPeople = Id)
        If item IsNot Nothing Then
            bd.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, item)
            bd.DTPeoples.DeleteOnSubmit(item)
            bd.SubmitChanges()
            disconnet()
        Else
            disconnet()
        End If

        Return item
    End Function

    Public Shared Function GetAllVWPeopleGeneralView() As List(Of VWPeopleGeneral)
        connect()
        Dim item = bd.VWPeopleGenerals.ToList()
        disconnet()
        Return item
    End Function
    Public Shared Function GetAllPeopleView() As List(Of VWInfoPeople)
        connect()
        Dim item = bd.VWInfoPeoples.ToList()
        disconnet()
        Return item
    End Function
    Public Shared Function GetAllPeople() As List(Of DTPeople)
        connect()
        Dim item = bd.DTPeoples.ToList()
        disconnet()
        Return item
    End Function
    Public Shared Function GetDTDocumentsType() As List(Of DTDocumentsType)
        connect()
        Dim items = bd.DTDocumentsTypes.ToList()
        disconnet()
        Return items
    End Function
    Public Shared Function GetDTCountries() As List(Of DTCountry)
        connect()
        Dim items = bd.DTCountries.ToList()
        disconnet()
        Return items
    End Function
    Public Shared Function GetPeopleByID(ByVal Id As Integer) As DTPeople

        Dim item1 = GetAllPeople()

        Dim item = item1.SingleOrDefault(Function(x) x.IDPeople = Id)

        Return item
    End Function
    Public Shared Function SetPeople(ByVal item As DTPeople) As DTPeople
        If item.IDPeople = 0 Then
            connect()
            bd.DTPeoples.InsertOnSubmit(item)
            bd.SubmitChanges()
            disconnet()
        Else
            connect()
            bd.DTPeoples.Attach(item)
            bd.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, item)
            bd.SubmitChanges()
            disconnet()
        End If

        Return item
    End Function

    Private Shared Sub disconnet()
        bd.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues)
        bd.Dispose()
    End Sub

End Class
