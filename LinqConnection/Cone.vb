
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
        Dim item = bd.DTPeople.SingleOrDefault(Function(x) x.IDPeople = Id)
        If item IsNot Nothing Then
            bd.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, item)
            bd.DTPeople.DeleteOnSubmit(item)
            bd.SubmitChanges()
            disconnet()
        Else
            disconnet()
        End If

        Return item
    End Function
    Public Shared Function GetAllPeopleView() As List(Of VWInfoPeople)
        connect()
        Dim item = bd.VWInfoPeople.ToList()
        disconnet()
        Return item
    End Function
    Public Shared Function GetAllPeople() As List(Of DTPeople)
        connect()
        Dim item = bd.DTPeople.ToList()
        disconnet()
        Return item
    End Function
    Public Shared Function GetDTDocumentsType() As List(Of DTDocumentsType)
        connect()
        Dim items = bd.DTDocumentsType.ToList()
        disconnet()
        Return items
    End Function
    Public Shared Function GetDTCountries() As List(Of DTCountries)
        connect()
        Dim items = bd.DTCountries.ToList()
        disconnet()
        Return items
    End Function
    Public Shared Function GetPeopleByID(ByVal Id As Int32) As DTPeople
        connect()
        Dim item = bd.DTPeople.ToList().Where(Function(x) x.IDPeople = Id).SingleOrDefault()
        disconnet()
        Return item
    End Function
    Public Shared Function SetPeople(ByVal item As DTPeople) As DTPeople
        If item.IDPeople = 0 Then
            connect()
            bd.DTPeople.InsertOnSubmit(item)
            bd.SubmitChanges()
            disconnet()
        Else
            connect()
            bd.DTPeople.Attach(item)
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
