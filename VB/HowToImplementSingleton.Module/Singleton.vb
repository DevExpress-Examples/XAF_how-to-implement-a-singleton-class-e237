Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation
Imports DevExpress.ExpressApp.Xpo

Namespace HowToImplementSingleton.Module
	Public Class Singleton
		Inherits BaseObject
		Friend Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Shared Function GetInstance(ByVal objectSpace As IObjectSpace) As Singleton
			Dim result As Singleton = objectSpace.FindObject(Of Singleton)(Nothing)
			If result Is Nothing Then
				result = New Singleton((CType(objectSpace, XPObjectSpace)).Session)
				result.Name = "My Singleton"
				result.Description = "Sample Description"
				result.Save()
			End If
			Return result
		End Function
		Private name_Renamed As String
		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Name", name_Renamed, value)
			End Set
		End Property
		Private description_Renamed As String
		Public Property Description() As String
			Get
				Return description_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Description", description_Renamed, value)
			End Set
		End Property
		Protected Overrides Sub OnDeleting()
			Throw New UserFriendlyException("This object cannot be deleted.")
		End Sub
	End Class
End Namespace
