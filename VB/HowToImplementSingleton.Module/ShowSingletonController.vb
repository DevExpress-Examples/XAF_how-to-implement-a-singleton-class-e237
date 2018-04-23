Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base

Public Class ShowSingletonController
	Inherits DevExpress.ExpressApp.ViewController

	Public Sub New()
		MyBase.New()

		'This call is required by the Component Designer.
		InitializeComponent()
		RegisterActions(components) 

	End Sub

   Private Sub PopupWindowShowAction1_CustomizePopupWindowParams(ByVal sender As System.Object, ByVal e As DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventArgs) Handles PopupWindowShowAction1.CustomizePopupWindowParams
      Dim objectSpace As ObjectSpace = Application.CreateObjectSpace()
      e.View = Application.CreateDetailView(objectSpace, Singleton.GetInstance(objectSpace.Session))
   End Sub
End Class
