Imports DevExpress.ExpressApp.DC
Imports System.ComponentModel
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Editors

Namespace HowToImplementSingleton.Module
    Public Class ShowSingletonController
        Inherits WindowController

        Public Sub New()
            Me.TargetWindowType = WindowType.Main
            Dim showSingletonAction As New PopupWindowShowAction(Me, "ShowSingleton", PredefinedCategory.View)
            AddHandler showSingletonAction.CustomizePopupWindowParams, AddressOf showSingletonAction_CustomizePopupWindowParams
        End Sub
        Private Sub showSingletonAction_CustomizePopupWindowParams(ByVal sender As Object, ByVal e As CustomizePopupWindowParamsEventArgs)
            Dim objectSpace As IObjectSpace = Application.CreateObjectSpace()
            Dim detailView As DetailView = Application.CreateDetailView(objectSpace, Singleton.GetInstance(objectSpace))
            detailView.ViewEditMode = ViewEditMode.Edit
            e.View = detailView
        End Sub
    End Class
End Namespace
