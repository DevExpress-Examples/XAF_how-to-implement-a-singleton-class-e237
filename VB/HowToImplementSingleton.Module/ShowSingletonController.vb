Imports DevExpress.ExpressApp.DC
Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base

Namespace HowToImplementSingleton.Module
	Partial Public Class ShowSingletonController
		Inherits ViewController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
		End Sub
		Private Sub popupWindowShowAction1_CustomizePopupWindowParams(ByVal sender As Object, ByVal e As CustomizePopupWindowParamsEventArgs) Handles popupWindowShowAction1.CustomizePopupWindowParams
			Dim objectSpace As IObjectSpace = Application.CreateObjectSpace()
			e.View = Application.CreateDetailView(objectSpace, Singleton.GetInstance(TryCast(objectSpace, ObjectSpace).Session))
		End Sub
	End Class
End Namespace
