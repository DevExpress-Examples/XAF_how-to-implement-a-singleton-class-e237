Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web.UI
Imports System.Drawing
Imports System.Web.UI.WebControls

Imports DevExpress.ExpressApp.Templates
Imports DevExpress.ExpressApp.Web
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Utils
Imports DevExpress.ExpressApp.Web.TestScripts
Imports DevExpress.ExpressApp

Public Partial Class [Default]
	Inherits System.Web.UI.Page
	Implements IWindowTemplate
	Private contextMenu As ContextActionsMenu
	Protected Overrides Sub InitializeCulture()
		MyBase.InitializeCulture()
        WebApplication.Instance.InitializeCulture()
	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		contextMenu = New ContextActionsMenu(Me, "RecordEdit", "ListView")
      Header.Title = WebApplication.Instance.Title
      NavigationTabsActionContainer.ShowImages = True
      ApplicationTitle.Text = WebApplication.Instance.Title
      ApplicationTitle.NavigateUrl = Request.ApplicationPath + "/"
      Copyright.Text = WebApplication.Instance.Info.GetAttributeValue("Copyright")
		Dim logoImageInfo As ImageInfo = ImageLoader.Instance.GetImageInfo(WebApplication.Instance.Info.GetAttributeValue("Logo", "ExpressAppLogo"))
		If (Not logoImageInfo.IsEmpty) Then
			LogoImage.ImageUrl = logoImageInfo.ImageUrl
		Else
			LogoImage.Visible = False
		End If
		WebApplication.Instance.CreateControls(Me)
	End Sub
	Protected Sub Page_Prerender(ByVal sender As Object, ByVal e As EventArgs)
		If TestScriptsManager.EasyTestEnabled Then
			ViewCaption.Attributes(EasyTestTagHelper.TestField) = "FormCaption"
			ViewCaption.Attributes(EasyTestTagHelper.TestControlClassName) = JSLabelTestControl.ClassName
		End If
	End Sub
	Public Overrides Sub Dispose()
		If Not contextMenu Is Nothing Then
			contextMenu.Dispose()
			contextMenu = Nothing
		End If
		MyBase.Dispose()
	End Sub
	Private isSizeable_Renamed As Boolean
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
		ViewCaption.Text = caption
	End Sub

	Private Sub SetStatus(ByVal statusMessages As ICollection(Of String)) Implements IWindowTemplate.SetStatus
		InfoMessagesPanel.Text = String.Join("<br>", New List(Of String)(statusMessages).ToArray())
	End Sub

	#End Region

	#Region "IFrameTemplate Members"

	Private ReadOnly Property DefaultContainer() As IActionContainer Implements IFrameTemplate.DefaultContainer
		Get
            Return ViewPresentationActionContainer
		End Get
	End Property

	Private Function GetContainers() As ICollection(Of IActionContainer) Implements IFrameTemplate.GetContainers
		Dim result As List(Of IActionContainer) = New List(Of IActionContainer)()
		result.AddRange(contextMenu.Containers)
		result.AddRange(New IActionContainer() { NavigationTabsActionContainer, NavigationLinksActionContainer, SearchActionContainer, VerticalNewActionContainer, ContextObjectsCreationActionContainer, RecordsNavigationContainer, ListViewDataManagementActionContainer, ViewPresentationActionContainer, TopRecordEditActionContainer, BottomRecordEditActionContainer, DiagnosticActionContainer, VerticalToolsActionContainer, ViewsHistoryNavigationContainer })
		Return result.ToArray()
	End Function

	Private Sub SetView(ByVal view As DevExpress.ExpressApp.View) Implements IFrameTemplate.SetView
		ViewSite.Controls.Clear()
		If Not view Is Nothing Then
			contextMenu.CreateControls(view)
			view.CreateControls()
			ViewSite.Controls.Add(CType(view.Control, Control))
			view.DataBind()
			ViewCaption.Text = view.Caption
			Header.Title = view.Caption & " - " & WebApplication.Instance.Title

			Dim imageInfo As ImageInfo = ImageLoader.Instance.GetLargeImageInfo(view.Info.GetAttributeValue("ImageName"))
			If imageInfo.IsEmpty Then
				ViewImage.Visible = False
			Else
				ViewImage.ImageUrl = imageInfo.ImageUrl
			End If
			Dim colorString As String = view.Info.GetAttributeValue("BackColor")
			If (Not String.IsNullOrEmpty(colorString)) Then
				Try
					Dim knowCcolor As KnownColor = CType(System.Enum.Parse(GetType(KnownColor), colorString), KnownColor)
					ViewTitle.BackColor = Color.FromKnownColor(knowCcolor)
				Catch e1 As Exception
				End Try
			End If
		End If
	End Sub

	#End Region

End Class
