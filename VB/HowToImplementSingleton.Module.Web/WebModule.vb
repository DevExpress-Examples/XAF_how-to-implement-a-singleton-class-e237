Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel

Imports DevExpress.ExpressApp

Namespace HowToImplementSingleton.Module.Web
	<ToolboxItemFilter("Xaf.Platform.Web")> _
	Public NotInheritable Partial Class HowToImplementSingletonAspNetModule
		Inherits ModuleBase
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
