Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Web.UI

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Templates
Imports DevExpress.ExpressApp.Utils
Imports DevExpress.ExpressApp.Web

Public Partial Class DialogPage
	Inherits System.Web.UI.Page
	Implements IWindowTemplate, ILookupPopupFrameTemplate
	Protected Overrides Sub InitializeCulture()
		MyBase.InitializeCulture()
        WebApplication.Instance.InitializeCulture()
	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		WebApplication.Instance.CreateControls(Me)
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
		Return New IActionContainer() { Me.SearchActionContainer, Me.ObjectsCreationActionContainer, Me.PopupActions, Me.DiagnosticActionContainer}
	End Function
	Private Sub SetView(ByVal view As DevExpress.ExpressApp.View) Implements IFrameTemplate.SetView
		Me.ViewSite.Controls.Clear()
		If Not view Is Nothing Then
			view.CreateControls()
			ViewSite.Controls.Add(CType(view.Control, Control))
			view.DataBind()
			Me.ViewCaption.Text = view.Caption
			Header.Title = view.Caption & " - " & WebApplication.Instance.Title
			Dim imageInfo As ImageInfo = ImageLoader.Instance.GetLargeImageInfo(view.Info.GetAttributeValue("ImageName"))
			If imageInfo.IsEmpty Then
				ViewImage.Visible = False
			Else
				ViewImage.ImageUrl = imageInfo.ImageUrl
			End If
			If TypeOf view Is DetailView Then
				SearchActionContainer.Visible = False
				ObjectsCreationActionContainer.Visible = False
			End If
			Dim colorString As String = view.Info.GetAttributeValue("BackColor")
			If (Not String.IsNullOrEmpty(colorString)) Then
				Try
					Dim knownColor As KnownColor = CType(System.Enum.Parse(GetType(KnownColor), colorString), KnownColor)
					ViewTitle.BackColor = Color.FromKnownColor(knownColor)
				Catch e1 As Exception
				End Try
			End If
		End If
	End Sub

	#End Region


	#Region "ILookupPopupFrameTemplate Members"

	Private Property IsSearchEnabled() As Boolean Implements ILookupPopupFrameTemplate.IsSearchEnabled
		Get
			Return SearchActionContainer.Visible
		End Get
		Set
			SearchActionContainer.Visible = Value
		End Set
	End Property

	Private Sub SetStartSearchString(ByVal searchString As String) Implements ILookupPopupFrameTemplate.SetStartSearchString
	End Sub

	#End Region


End Class
