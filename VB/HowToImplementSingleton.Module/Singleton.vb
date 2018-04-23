Imports System

Imports DevExpress.Xpo

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

<DefaultClassOptions()> _
 Public Class Singleton
   Inherits BaseObject
   Protected Friend Sub New(ByVal session As Session)
      MyBase.New(session)
   End Sub
   Public Shared Function GetInstance(ByVal session As Session) As Singleton
      'Get the Singleton's instance if it exists
      Dim result As Singleton = session.FindObject(Of Singleton)(Nothing)
      'Create the Singleton's instance
      If result Is Nothing Then
         result = New Singleton(session)
         result.Name = "My Singleton"
         result.Description = "Empty"
         result.Save()
      End If
      Return result
   End Function
   Private fname As String
   Public Property Name() As String
      Get
         Return fname
      End Get
      Set(ByVal value As String)
         SetPropertyValue("Name", fname, Value)
      End Set
   End Property
   Private fdescription As String
   Public Property Description() As String
      Get
         Return fdescription
      End Get
      Set(ByVal value As String)
         SetPropertyValue("Description", fdescription, Value)
      End Set
   End Property
   'Prevent the Singleton from being deleted
   Protected Overrides Sub OnDeleting()
      Throw New Exception("Cannot be deleted")
   End Sub
End Class
