Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.ExpressApp.Templates
Imports DevExpress.ExpressApp.Utils
Imports DevExpress.Persistent.Base
Imports System.Collections.Generic
Imports DevExpress.ExpressApp

Public Partial Class NestedFrameControl
	Inherits System.Web.UI.UserControl
	Implements IFrameTemplate
	Private contextMenu As ContextActionsMenu
	Protected Overrides Sub OnPreRender(ByVal e As EventArgs)
		MyBase.OnPreRender(e)
	End Sub
	Protected Overrides Sub OnLoad(ByVal e As EventArgs)
		MyBase.OnLoad(e)
	End Sub
	Protected Overrides Sub OnInit(ByVal e As EventArgs)
		MyBase.OnInit(e)
	End Sub
	Public Sub New()
		contextMenu = New ContextActionsMenu(Me, "RecordEdit", "ListView")
	End Sub
	Public Overrides Sub Dispose()
		If Not contextMenu Is Nothing Then
			contextMenu.Dispose()
			contextMenu = Nothing
		End If
		MyBase.Dispose()
	End Sub

	#Region "IFrameTemplate Members"
	Private ReadOnly Property DefaultContainer() As IActionContainer Implements IFrameTemplate.DefaultContainer
		Get
            Return ViewContainer
        End Get
	End Property
	Private Function GetContainers() As ICollection(Of IActionContainer) Implements IFrameTemplate.GetContainers
		Dim result As List(Of IActionContainer) = New List(Of IActionContainer)()
		result.AddRange(contextMenu.Containers)
		result.AddRange(New IActionContainer() { ContextObjectsCreationActionContainer, DiagnosticActionContainer, RecordEditContainer, ViewContainer})
		Return result
	End Function
	Private Sub SetView(ByVal view As DevExpress.ExpressApp.View) Implements IFrameTemplate.SetView
		ViewSite.Controls.Clear()
		If Not view Is Nothing Then
			contextMenu.CreateControls(view)
			view.CreateControls()
			ViewSite.Controls.Add(CType(view.Control, Control))
			ViewCaption.Text = view.Caption
			Dim imageInfo As ImageInfo = ImageLoader.Instance.GetImageInfo(view.Info.GetAttributeValue("ImageName"))
			If imageInfo.IsEmpty Then
				ViewImage.Visible = False
			Else
				ViewImage.ImageUrl = imageInfo.ImageUrl
			End If
		End If
	End Sub
	#End Region
End Class
