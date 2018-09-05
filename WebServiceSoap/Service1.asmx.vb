Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports LinqConnection
' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class Service1
    Inherits System.Web.Services.WebService
    <WebMethod()> _
    Public Function GetAllPeopleView() As List(Of VWInfoPeople)
        Return Cone.GetAllPeopleView()
    End Function
    <WebMethod()> _
    Public Function GetDataAllPeople() As List(Of DTPeople)
        Return Cone.GetAllPeople()
    End Function
    <WebMethod()> _
    Public Function GetPeopleByID(ByVal value As Integer) As DTPeople
        Return Cone.GetPeopleByID(value)
    End Function

    <WebMethod()> _
    Public Function GetDTDocumentsType() As List(Of DTDocumentsType)
        Return Cone.GetDTDocumentsType()
    End Function

    <WebMethod()> _
    Public Function GetDTCountries() As List(Of DTCountries)
        Return Cone.GetDTCountries()
    End Function
    <WebMethod()> _
    Public Function SetPeople(ByVal item As DTPeople) As DTPeople
        Return Cone.SetPeople(item)
    End Function
    <WebMethod()> _
    Public Function DeletetDTPeople(ByVal item As Integer) As DTPeople
        Return Cone.DeletetDTPeople(item)
    End Function
End Class