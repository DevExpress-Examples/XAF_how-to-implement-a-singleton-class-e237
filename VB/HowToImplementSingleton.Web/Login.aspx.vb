Imports Microsoft.VisualBasic
Imports System
Imports System.Web

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Templates
Imports DevExpress.ExpressApp.Web.TestScripts
Imports DevExpress.ExpressApp.Web
Imports System.Web.UI
Imports DevExpress.ExpressApp.Utils
Imports System.Collections.Generic

Public Partial Class LoginPage
	Inherits System.Web.UI.Page
	Implements IWindowTemplate
	Private isSizeable_Renamed As Boolean
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		WebApplication.Instance.CreateLogonControls(Me)
	End Sub
	#Region "IWindowTemplate Members"

	Private Property IsSizeable() As Boolean Implements IWindowTemplate.IsSizeable
		Get
			Return isSizeable_Renamed
		End Get
		Set
			isSizeable_Renamed = Value
		End Set
	End Property
	Private Sub SetCaption(ByVal caption As String) Implements IWindowTemplate.SetCaption
	End Sub
	Private Sub SetStatus(ByVal statusMessages As System.Collections.Generic.ICollection(Of String)) Implements IWindowTemplate.SetStatus
	End Sub

	#End Region

	#Region "IFrameTemplate Members"
	Private ReadOnly Property DefaultContainer() As IActionContainer Implements IFrameTemplate.DefaultContainer
		Get
			Return Nothing
		End Get
	End Property
	Private Function GetContainers() As ICollection(Of IActionContainer) Implements IFrameTemplate.GetContainers
		Return New IActionContainer() {Me.PopupActions}
	End Function
	Private Sub SetView(ByVal view As DevExpress.ExpressApp.View) Implements IFrameTemplate.SetView
		Me.ViewSite.Controls.Clear()
		If Not view Is Nothing Then
			view.CreateControls()
			ViewSite.Controls.Add(CType(view.Control, Control))
			view.DataBind()
			Me.ViewCaption.Text = view.Caption
			Header.Title = view.Caption
		End If
	End Sub

	#End Region
End Class
