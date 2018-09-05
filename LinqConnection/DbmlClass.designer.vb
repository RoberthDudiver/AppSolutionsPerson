﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="DBPeople")>  _
Partial Public Class DbmlClassDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertDTCountry(instance As DTCountry)
    End Sub
  Partial Private Sub UpdateDTCountry(instance As DTCountry)
    End Sub
  Partial Private Sub DeleteDTCountry(instance As DTCountry)
    End Sub
  Partial Private Sub InsertDTPeople(instance As DTPeople)
    End Sub
  Partial Private Sub UpdateDTPeople(instance As DTPeople)
    End Sub
  Partial Private Sub DeleteDTPeople(instance As DTPeople)
    End Sub
  Partial Private Sub InsertDTDocumentsType(instance As DTDocumentsType)
    End Sub
  Partial Private Sub UpdateDTDocumentsType(instance As DTDocumentsType)
    End Sub
  Partial Private Sub DeleteDTDocumentsType(instance As DTDocumentsType)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.LinqConnection.My.MySettings.Default.DBPeopleConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property DTCountries() As System.Data.Linq.Table(Of DTCountry)
		Get
			Return Me.GetTable(Of DTCountry)
		End Get
	End Property
	
	Public ReadOnly Property DTPeoples() As System.Data.Linq.Table(Of DTPeople)
		Get
			Return Me.GetTable(Of DTPeople)
		End Get
	End Property
	
	Public ReadOnly Property DTDocumentsTypes() As System.Data.Linq.Table(Of DTDocumentsType)
		Get
			Return Me.GetTable(Of DTDocumentsType)
		End Get
	End Property
	
	Public ReadOnly Property VWPeopleGenerals() As System.Data.Linq.Table(Of VWPeopleGeneral)
		Get
			Return Me.GetTable(Of VWPeopleGeneral)
		End Get
	End Property
	
	Public ReadOnly Property VWInfoPeoples() As System.Data.Linq.Table(Of VWInfoPeople)
		Get
			Return Me.GetTable(Of VWInfoPeople)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.DTCountries")>  _
Partial Public Class DTCountry
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _CountryID As Integer
	
	Private _Country As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnCountryIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnCountryIDChanged()
    End Sub
    Partial Private Sub OnCountryChanging(value As String)
    End Sub
    Partial Private Sub OnCountryChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CountryID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property CountryID() As Integer
		Get
			Return Me._CountryID
		End Get
		Set
			If ((Me._CountryID = value)  _
						= false) Then
				Me.OnCountryIDChanging(value)
				Me.SendPropertyChanging
				Me._CountryID = value
				Me.SendPropertyChanged("CountryID")
				Me.OnCountryIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Country", DbType:="VarChar(50)")>  _
	Public Property Country() As String
		Get
			Return Me._Country
		End Get
		Set
			If (String.Equals(Me._Country, value) = false) Then
				Me.OnCountryChanging(value)
				Me.SendPropertyChanging
				Me._Country = value
				Me.SendPropertyChanged("Country")
				Me.OnCountryChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.DTPeople")>  _
Partial Public Class DTPeople
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _IDPeople As Integer
	
	Private _Name As String
	
	Private _SecondName As String
	
	Private _DocumentID As String
	
	Private _TypeDocumentID As System.Nullable(Of Integer)
	
	Private _BirthDate As System.Nullable(Of Date)
	
	Private _CountryID As System.Nullable(Of Integer)
	
	Private _Addres As String
	
	Private _PrincipalPhone As String
	
	Private _UpdateUpd As System.Nullable(Of Date)
	
	Private _CreateDate As System.Nullable(Of Date)
	
	Private _Sex As System.Nullable(Of Integer)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDPeopleChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDPeopleChanged()
    End Sub
    Partial Private Sub OnNameChanging(value As String)
    End Sub
    Partial Private Sub OnNameChanged()
    End Sub
    Partial Private Sub OnSecondNameChanging(value As String)
    End Sub
    Partial Private Sub OnSecondNameChanged()
    End Sub
    Partial Private Sub OnDocumentIDChanging(value As String)
    End Sub
    Partial Private Sub OnDocumentIDChanged()
    End Sub
    Partial Private Sub OnTypeDocumentIDChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnTypeDocumentIDChanged()
    End Sub
    Partial Private Sub OnBirthDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnBirthDateChanged()
    End Sub
    Partial Private Sub OnCountryIDChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnCountryIDChanged()
    End Sub
    Partial Private Sub OnAddresChanging(value As String)
    End Sub
    Partial Private Sub OnAddresChanged()
    End Sub
    Partial Private Sub OnPrincipalPhoneChanging(value As String)
    End Sub
    Partial Private Sub OnPrincipalPhoneChanged()
    End Sub
    Partial Private Sub OnUpdateUpdChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnUpdateUpdChanged()
    End Sub
    Partial Private Sub OnCreateDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnCreateDateChanged()
    End Sub
    Partial Private Sub OnSexChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnSexChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IDPeople", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property IDPeople() As Integer
		Get
			Return Me._IDPeople
		End Get
		Set
			If ((Me._IDPeople = value)  _
						= false) Then
				Me.OnIDPeopleChanging(value)
				Me.SendPropertyChanging
				Me._IDPeople = value
				Me.SendPropertyChanged("IDPeople")
				Me.OnIDPeopleChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Name", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Name() As String
		Get
			Return Me._Name
		End Get
		Set
			If (String.Equals(Me._Name, value) = false) Then
				Me.OnNameChanging(value)
				Me.SendPropertyChanging
				Me._Name = value
				Me.SendPropertyChanged("Name")
				Me.OnNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SecondName", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property SecondName() As String
		Get
			Return Me._SecondName
		End Get
		Set
			If (String.Equals(Me._SecondName, value) = false) Then
				Me.OnSecondNameChanging(value)
				Me.SendPropertyChanging
				Me._SecondName = value
				Me.SendPropertyChanged("SecondName")
				Me.OnSecondNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DocumentID", DbType:="VarChar(50)")>  _
	Public Property DocumentID() As String
		Get
			Return Me._DocumentID
		End Get
		Set
			If (String.Equals(Me._DocumentID, value) = false) Then
				Me.OnDocumentIDChanging(value)
				Me.SendPropertyChanging
				Me._DocumentID = value
				Me.SendPropertyChanged("DocumentID")
				Me.OnDocumentIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TypeDocumentID", DbType:="Int")>  _
	Public Property TypeDocumentID() As System.Nullable(Of Integer)
		Get
			Return Me._TypeDocumentID
		End Get
		Set
			If (Me._TypeDocumentID.Equals(value) = false) Then
				Me.OnTypeDocumentIDChanging(value)
				Me.SendPropertyChanging
				Me._TypeDocumentID = value
				Me.SendPropertyChanged("TypeDocumentID")
				Me.OnTypeDocumentIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_BirthDate", DbType:="Date")>  _
	Public Property BirthDate() As System.Nullable(Of Date)
		Get
			Return Me._BirthDate
		End Get
		Set
			If (Me._BirthDate.Equals(value) = false) Then
				Me.OnBirthDateChanging(value)
				Me.SendPropertyChanging
				Me._BirthDate = value
				Me.SendPropertyChanged("BirthDate")
				Me.OnBirthDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CountryID", DbType:="Int")>  _
	Public Property CountryID() As System.Nullable(Of Integer)
		Get
			Return Me._CountryID
		End Get
		Set
			If (Me._CountryID.Equals(value) = false) Then
				Me.OnCountryIDChanging(value)
				Me.SendPropertyChanging
				Me._CountryID = value
				Me.SendPropertyChanged("CountryID")
				Me.OnCountryIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Addres", DbType:="VarChar(500)")>  _
	Public Property Addres() As String
		Get
			Return Me._Addres
		End Get
		Set
			If (String.Equals(Me._Addres, value) = false) Then
				Me.OnAddresChanging(value)
				Me.SendPropertyChanging
				Me._Addres = value
				Me.SendPropertyChanged("Addres")
				Me.OnAddresChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PrincipalPhone", DbType:="VarChar(10)")>  _
	Public Property PrincipalPhone() As String
		Get
			Return Me._PrincipalPhone
		End Get
		Set
			If (String.Equals(Me._PrincipalPhone, value) = false) Then
				Me.OnPrincipalPhoneChanging(value)
				Me.SendPropertyChanging
				Me._PrincipalPhone = value
				Me.SendPropertyChanged("PrincipalPhone")
				Me.OnPrincipalPhoneChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UpdateUpd", DbType:="DateTime")>  _
	Public Property UpdateUpd() As System.Nullable(Of Date)
		Get
			Return Me._UpdateUpd
		End Get
		Set
			If (Me._UpdateUpd.Equals(value) = false) Then
				Me.OnUpdateUpdChanging(value)
				Me.SendPropertyChanging
				Me._UpdateUpd = value
				Me.SendPropertyChanged("UpdateUpd")
				Me.OnUpdateUpdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CreateDate", DbType:="Date")>  _
	Public Property CreateDate() As System.Nullable(Of Date)
		Get
			Return Me._CreateDate
		End Get
		Set
			If (Me._CreateDate.Equals(value) = false) Then
				Me.OnCreateDateChanging(value)
				Me.SendPropertyChanging
				Me._CreateDate = value
				Me.SendPropertyChanged("CreateDate")
				Me.OnCreateDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Sex", DbType:="Int")>  _
	Public Property Sex() As System.Nullable(Of Integer)
		Get
			Return Me._Sex
		End Get
		Set
			If (Me._Sex.Equals(value) = false) Then
				Me.OnSexChanging(value)
				Me.SendPropertyChanging
				Me._Sex = value
				Me.SendPropertyChanged("Sex")
				Me.OnSexChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.DTDocumentsType")>  _
Partial Public Class DTDocumentsType
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _TypeDocumentID As Integer
	
	Private _TypeDocument As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnTypeDocumentIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnTypeDocumentIDChanged()
    End Sub
    Partial Private Sub OnTypeDocumentChanging(value As String)
    End Sub
    Partial Private Sub OnTypeDocumentChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TypeDocumentID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property TypeDocumentID() As Integer
		Get
			Return Me._TypeDocumentID
		End Get
		Set
			If ((Me._TypeDocumentID = value)  _
						= false) Then
				Me.OnTypeDocumentIDChanging(value)
				Me.SendPropertyChanging
				Me._TypeDocumentID = value
				Me.SendPropertyChanged("TypeDocumentID")
				Me.OnTypeDocumentIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TypeDocument", DbType:="VarChar(50)")>  _
	Public Property TypeDocument() As String
		Get
			Return Me._TypeDocument
		End Get
		Set
			If (String.Equals(Me._TypeDocument, value) = false) Then
				Me.OnTypeDocumentChanging(value)
				Me.SendPropertyChanging
				Me._TypeDocument = value
				Me.SendPropertyChanged("TypeDocument")
				Me.OnTypeDocumentChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.VWPeopleGeneral")>  _
Partial Public Class VWPeopleGeneral
	
	Private _FullName As String
	
	Private _IDPeople As Integer
	
	Private _Age As System.Nullable(Of Integer)
	
	Private _Sex As String
	
	Private _BirthDate As System.Nullable(Of Date)
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FullName", DbType:="VarChar(101) NOT NULL", CanBeNull:=false)>  _
	Public Property FullName() As String
		Get
			Return Me._FullName
		End Get
		Set
			If (String.Equals(Me._FullName, value) = false) Then
				Me._FullName = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IDPeople", AutoSync:=AutoSync.Always, DbType:="Int NOT NULL IDENTITY", IsDbGenerated:=true)>  _
	Public Property IDPeople() As Integer
		Get
			Return Me._IDPeople
		End Get
		Set
			If ((Me._IDPeople = value)  _
						= false) Then
				Me._IDPeople = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Age", DbType:="Int")>  _
	Public Property Age() As System.Nullable(Of Integer)
		Get
			Return Me._Age
		End Get
		Set
			If (Me._Age.Equals(value) = false) Then
				Me._Age = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Sex", DbType:="VarChar(9) NOT NULL", CanBeNull:=false)>  _
	Public Property Sex() As String
		Get
			Return Me._Sex
		End Get
		Set
			If (String.Equals(Me._Sex, value) = false) Then
				Me._Sex = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_BirthDate", DbType:="Date")>  _
	Public Property BirthDate() As System.Nullable(Of Date)
		Get
			Return Me._BirthDate
		End Get
		Set
			If (Me._BirthDate.Equals(value) = false) Then
				Me._BirthDate = value
			End If
		End Set
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.VWInfoPeople")>  _
Partial Public Class VWInfoPeople
	
	Private _IDPeople As Integer
	
	Private _Name As String
	
	Private _SecondName As String
	
	Private _DocumentID As String
	
	Private _TypeDocumentID As System.Nullable(Of Integer)
	
	Private _BirthDate As System.Nullable(Of Date)
	
	Private _CountryID As System.Nullable(Of Integer)
	
	Private _Addres As String
	
	Private _PrincipalPhone As String
	
	Private _UpdateUpd As System.Nullable(Of Date)
	
	Private _CreateDate As System.Nullable(Of Date)
	
	Private _TypeDocument As String
	
	Private _Country As String
	
	Private _Sex As System.Nullable(Of Integer)
	
	Private _Age As System.Nullable(Of Integer)
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IDPeople", DbType:="Int NOT NULL")>  _
	Public Property IDPeople() As Integer
		Get
			Return Me._IDPeople
		End Get
		Set
			If ((Me._IDPeople = value)  _
						= false) Then
				Me._IDPeople = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Name", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Name() As String
		Get
			Return Me._Name
		End Get
		Set
			If (String.Equals(Me._Name, value) = false) Then
				Me._Name = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SecondName", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property SecondName() As String
		Get
			Return Me._SecondName
		End Get
		Set
			If (String.Equals(Me._SecondName, value) = false) Then
				Me._SecondName = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DocumentID", DbType:="VarChar(50)")>  _
	Public Property DocumentID() As String
		Get
			Return Me._DocumentID
		End Get
		Set
			If (String.Equals(Me._DocumentID, value) = false) Then
				Me._DocumentID = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TypeDocumentID", DbType:="Int")>  _
	Public Property TypeDocumentID() As System.Nullable(Of Integer)
		Get
			Return Me._TypeDocumentID
		End Get
		Set
			If (Me._TypeDocumentID.Equals(value) = false) Then
				Me._TypeDocumentID = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_BirthDate", DbType:="Date")>  _
	Public Property BirthDate() As System.Nullable(Of Date)
		Get
			Return Me._BirthDate
		End Get
		Set
			If (Me._BirthDate.Equals(value) = false) Then
				Me._BirthDate = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CountryID", DbType:="Int")>  _
	Public Property CountryID() As System.Nullable(Of Integer)
		Get
			Return Me._CountryID
		End Get
		Set
			If (Me._CountryID.Equals(value) = false) Then
				Me._CountryID = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Addres", DbType:="VarChar(500)")>  _
	Public Property Addres() As String
		Get
			Return Me._Addres
		End Get
		Set
			If (String.Equals(Me._Addres, value) = false) Then
				Me._Addres = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PrincipalPhone", DbType:="VarChar(10)")>  _
	Public Property PrincipalPhone() As String
		Get
			Return Me._PrincipalPhone
		End Get
		Set
			If (String.Equals(Me._PrincipalPhone, value) = false) Then
				Me._PrincipalPhone = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UpdateUpd", DbType:="DateTime")>  _
	Public Property UpdateUpd() As System.Nullable(Of Date)
		Get
			Return Me._UpdateUpd
		End Get
		Set
			If (Me._UpdateUpd.Equals(value) = false) Then
				Me._UpdateUpd = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CreateDate", DbType:="Date")>  _
	Public Property CreateDate() As System.Nullable(Of Date)
		Get
			Return Me._CreateDate
		End Get
		Set
			If (Me._CreateDate.Equals(value) = false) Then
				Me._CreateDate = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TypeDocument", DbType:="VarChar(50)")>  _
	Public Property TypeDocument() As String
		Get
			Return Me._TypeDocument
		End Get
		Set
			If (String.Equals(Me._TypeDocument, value) = false) Then
				Me._TypeDocument = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Country", DbType:="VarChar(50)")>  _
	Public Property Country() As String
		Get
			Return Me._Country
		End Get
		Set
			If (String.Equals(Me._Country, value) = false) Then
				Me._Country = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Sex", DbType:="Int")>  _
	Public Property Sex() As System.Nullable(Of Integer)
		Get
			Return Me._Sex
		End Get
		Set
			If (Me._Sex.Equals(value) = false) Then
				Me._Sex = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Age", DbType:="Int")>  _
	Public Property Age() As System.Nullable(Of Integer)
		Get
			Return Me._Age
		End Get
		Set
			If (Me._Age.Equals(value) = false) Then
				Me._Age = value
			End If
		End Set
	End Property
End Class
