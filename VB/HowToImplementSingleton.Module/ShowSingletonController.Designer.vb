Partial Class ShowSingletonController

	<System.Diagnostics.DebuggerNonUserCode()> _
	Public Sub New(ByVal Container As System.ComponentModel.IContainer)
		MyClass.New()

		'Required for Windows.Forms Class Composition Designer support
		Container.Add(Me)

	End Sub

	'Component overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso components IsNot Nothing Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	'Required by the Component Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Component Designer
	'It can be modified using the Component Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Me.PopupWindowShowAction1 = New DevExpress.ExpressApp.Actions.PopupWindowShowAction(Me.components)
      '
      'PopupWindowShowAction1
      '
      Me.PopupWindowShowAction1.AcceptButtonCaption = Nothing
      Me.PopupWindowShowAction1.CancelButtonCaption = Nothing
      Me.PopupWindowShowAction1.Caption = "Show Sigleton"
      Me.PopupWindowShowAction1.Id = "3e058b61-2312-4e5e-a378-b0eaf5d96a66"

   End Sub
   Friend WithEvents PopupWindowShowAction1 As DevExpress.ExpressApp.Actions.PopupWindowShowAction

End Class
