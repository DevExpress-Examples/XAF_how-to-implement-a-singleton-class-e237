Imports Microsoft.VisualBasic
Imports System
Namespace HowToImplementSingleton.Module
	Partial Public Class ShowSingletonController
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.popupWindowShowAction1 = New DevExpress.ExpressApp.Actions.PopupWindowShowAction(Me.components)
			' 
			' popupWindowShowAction1
			' 
			Me.popupWindowShowAction1.AcceptButtonCaption = Nothing
			Me.popupWindowShowAction1.CancelButtonCaption = Nothing
			Me.popupWindowShowAction1.Caption = "Show Singleton"
			Me.popupWindowShowAction1.Id = "566d5031-9ce4-4d6c-9841-843a2c59a548"
'			Me.popupWindowShowAction1.CustomizePopupWindowParams += New DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(Me.popupWindowShowAction1_CustomizePopupWindowParams);

		End Sub

		#End Region

		Private WithEvents popupWindowShowAction1 As DevExpress.ExpressApp.Actions.PopupWindowShowAction

	End Class
End Namespace
