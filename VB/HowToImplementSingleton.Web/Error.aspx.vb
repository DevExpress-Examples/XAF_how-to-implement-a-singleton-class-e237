Imports System
Imports System.IO
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Globalization
Imports System.Threading
Imports System.Drawing
Imports System.Web
Imports System.Web.SessionState
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports DevExpress.ExpressApp.Utils

Imports DevExpress.ExpressApp.Web

Partial Public Class ErrorPage
    Inherits System.Web.UI.Page
    Protected Overrides Sub InitializeCulture()
        MyBase.InitializeCulture()
        WebApplication.Instance.InitializeCulture()
    End Sub
    Protected Sub Page_Load()
        ApplicationTitle.Text = WebApplication.Instance.Title
        Header.Title = "Application Error - " + WebApplication.Instance.Title
        Copyright.Text = WebApplication.Instance.Info.GetAttributeValue("Copyright")
        Dim logoImageInfo As ImageInfo
        logoImageInfo = ImageLoader.Instance.GetImageInfo(WebApplication.Instance.Info.GetAttributeValue("Logo", "ExpressAppLogo"))
        If Not logoImageInfo.IsEmpty Then
            LogoImage.ImageUrl = logoImageInfo.ImageUrl
        Else
            LogoImage.Visible = False
        End If

        Dim errorInfo As ErrorInfo = ErrorHandling.GetApplicationError()
        If Not errorInfo Is Nothing Then
            RequestUrl.NavigateUrl = errorInfo.Url
            RequestUrl.Text = errorInfo.Url
            RequestUrl2.NavigateUrl = errorInfo.Url
            RequestUrl2.Text = errorInfo.Url
            If Not String.IsNullOrEmpty(errorInfo.UrlReferrer) Then
                HyperLinkReturn.NavigateUrl = errorInfo.UrlReferrer
            Else
                LiteralReturn.Visible = False
                HyperLinkReturn.Visible = False
            End If
            If ErrorHandling.CanShowDetailedInformation Then
                DetailsText.Text = errorInfo.GetTextualPresentation(True)
            Else
                Details.Visible = False
            End If
            ReportResult.Visible = False
            ReportForm.Visible = ErrorHandling.CanSendAlertToAdmin
        Else
            ErrorPanel.Visible = False
        End If
        WebWindow.PatchIEForPNGImages(Me)
    End Sub
#Region "Web Form Designer generated code"
    Protected Overrides Sub OnInit(ByVal e As EventArgs)
        InitializeComponent()
        MyBase.OnInit(e)
    End Sub

    Private Sub InitializeComponent()
    End Sub

#End Region
    Protected Sub ReportButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim errorInfo As ErrorInfo = ErrorHandling.GetApplicationError()
        If Not errorInfo Is Nothing Then
            ErrorHandling.SendAlertToAdmin(errorInfo.Id, DescriptionTextBox.Text, errorInfo.Exception.Message)
            ErrorHandling.ClearApplicationError()
            ApologizeMessage.Visible = False
            ReportForm.Visible = False
            Details.Visible = False
            ReportResult.Visible = True
        End If
    End Sub
End Class

