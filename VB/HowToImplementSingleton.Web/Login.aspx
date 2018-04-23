<%@ Page Language="vb" AutoEventWireup="true" Inherits="LoginPage" Codebehind="Login.aspx.vb" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v8.2" Namespace="DevExpress.ExpressApp.Web.Templates.ActionContainers" TagPrefix="cc2" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v8.2" Namespace="DevExpress.ExpressApp.Web.Templates.Controls" TagPrefix="tc" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v8.2" Namespace="DevExpress.ExpressApp.Web.Controls" TagPrefix="cc4" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title>Logon</title>
	<link href="TemplateStyle.css" rel="stylesheet" type="text/css" />    
	<link href="XAFControlsStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
	<cc4:ProgressControl ID="ProgressControl" runat="server" ImageName="~/Images/Progress.gif" CssClass="Progress" Text="">
	</cc4:ProgressControl>
	<table id="formTable" cellpadding="0" cellspacing="0" border="0" class="FullWidth"><tr><td align="center">
		<table border="0" cellpadding="0" cellspacing="0" height="50px" class="FullWidth Header">
			<tr><td class="ViewCaption" style="text-align:left;padding: 5px 0px 5px 20px; border-bottom:solid 1px #AECD76;background-color:#CFE7A5">
					<asp:Literal ID="ViewCaption" runat="server" Text="Log On"></asp:Literal></td></tr></table>

	<form id="form1" runat="server">
	<div id="Div2" class="Spacer NullSize" style="height: 50px;"></div>
	<table cellpadding="0" cellspacing="0" border="0" width="700px">
		<tr><td>
			<tc:ErrorInfoControl ID="ErrorInfo" style="margin: 10px 0px 10px 0px" runat="server">
			</tc:ErrorInfoControl>
		</td></tr>
		<tr><td align="center"><asp:PlaceHolder runat="server" ID="ViewSite"></asp:PlaceHolder></td></tr>
		<tr><td align="right" style="padding-top: 17px;">
					<cc2:HorizontalActionContainer ID="PopupActions" runat="server" ContainerId="PopupActions" CssClass="HContainer" Style="display:inline" BorderWidth="0px" CellPadding="0" CellSpacing="1">
					</cc2:HorizontalActionContainer>
		</td></tr>
	</table>
	</form>
   </td></tr></table>
</body>
</html>
