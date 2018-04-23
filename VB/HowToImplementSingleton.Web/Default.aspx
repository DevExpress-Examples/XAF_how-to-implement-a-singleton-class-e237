<%@ Page Language="vb" AutoEventWireup="true" Inherits="Default" EnableViewState="false" validateRequest="false" Codebehind="Default.aspx.vb" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v8.2" Namespace="DevExpress.ExpressApp.Web.Templates.ActionContainers" TagPrefix="cc2" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v8.2" Namespace="DevExpress.ExpressApp.Web.Controls" TagPrefix="cc4" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v8.2" Namespace="DevExpress.ExpressApp.Web.Templates.Controls" TagPrefix="tc" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Main Page</title>
	<meta http-equiv="Expires" content="0" />
    <link href="TemplateStyle.css" rel="stylesheet" type="text/css" />	
    <link href="XAFControlsStyle.css" rel="stylesheet" type="text/css" />	
</head>
<body>
    <script src="MoveFooter.js" type="text/javascript"></script>
	<cc4:ProgressControl ID="ProgressControl" runat="server" ImageName="~/Images/Progress.gif" CssClass="Progress" Text="" />
	<table id="formTable" cellpadding="0" cellspacing="0" border="0" class="FullWidth" width="800px"><tr><td>
	<form id="form1" runat="server">
		<table border="0" cellpadding="0" cellspacing="0" class="FullWidth Header">
			<tr><td class="ApplicationTitle">
                    <asp:HyperLink ID="ApplicationTitle" runat="server" ToolTip="Go to Default Page">HyperLink</asp:HyperLink></td>
				<td class="InfoMessagesPanel">
				    <asp:Literal ID="InfoMessagesPanel" runat="server" Text=""></asp:Literal></td>
			</tr>
			<tr><td colspan="2">
		            <cc2:NavigationTabsActionContainer ID="NavigationTabsActionContainer" runat="server" ContainerId="ViewsNavigation" CssClass="FullWidth Header" EnableDefaultAppearance="False" EnableHotTrack="False" EnableTheming="False" SaveStateToCookies="False" ShowLoadingPanelImage="False" Width="100%" TabSpacing="0px">
                        <ContentStyle Font-Names="Tahoma" Font-Underline="False" HorizontalAlign="Left" Font-Size="80%" ForeColor="#5CA0DA" VerticalAlign="Middle" BackColor="#C1DEF8" CssClass="TabNavigationContent">
                            <Paddings Padding="0px" PaddingBottom="10px" PaddingLeft="17px" PaddingTop="7px" />
                            <BackgroundImage ImageUrl="~/Images/TabContentBkg.gif" Repeat="RepeatX" />
                            <BorderBottom BorderColor="#5CA0DA" BorderStyle="Solid" BorderWidth="1px" />
                            <BorderTop BorderColor="#5CA0DA" BorderStyle="Solid" BorderWidth="1px" />
                        </ContentStyle>
                        <ActiveTabTemplate>
                            <asp:Table runat="server" BorderWidth="0px" CellPadding="0" CellSpacing="0">
                                <asp:TableRow runat="server">
                                    <asp:TableCell runat="server"><asp:Panel runat="server" CssClass="TabLeftPartSelected"></asp:Panel>
</asp:TableCell>
                                    <asp:TableCell runat="server" CssClass="TabMiddlePartSelected"><asp:Label runat="server"></asp:Label>
</asp:TableCell>
                                    <asp:TableCell runat="server"><asp:Panel runat="server" CssClass="TabRightPartSelected"></asp:Panel>
</asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </ActiveTabTemplate>
                        <TabTemplate>
                            <asp:Table runat="server" BorderWidth="0px" CellPadding="0" CellSpacing="0">
                                <asp:TableRow runat="server">
                                    <asp:TableCell runat="server"><asp:Panel runat="server" CssClass="TabLeftPart"></asp:Panel>
</asp:TableCell>
                                    <asp:TableCell runat="server" CssClass="TabMiddlePart"><asp:Label runat="server"></asp:Label>
</asp:TableCell>
                                    <asp:TableCell runat="server"><asp:Panel runat="server" CssClass="TabRightPart"></asp:Panel>
</asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </TabTemplate>
                        <Paddings Padding="0px" PaddingLeft="40px" />
                        <TabStyle HorizontalAlign="Left">
                            <Paddings Padding="0px" />
                        </TabStyle>
		            </cc2:NavigationTabsActionContainer>
			    </td>
			</tr>
		</table>
        <asp:Table ID="ViewTitle" runat="server" Width="100%" Height="50px" CellPadding="0" CellSpacing="0" BackColor="#CFE7A5">
            <asp:TableRow ID="TableRow1" runat="server">
                <asp:TableCell ID="TableCell1" runat="server" HorizontalAlign="Left" style="padding: 5px 0px 5px 21px; border-bottom:solid 1px #AECD76">
                    <cc2:HorizontalActionContainer ID="SearchActionContainer" runat="server" ContainerId="Search" CssClass="HContainer" BorderWidth="0px" CellPadding="0" CellSpacing="1">
		            </cc2:HorizontalActionContainer>
			        <cc2:HorizontalActionContainer ID="RecordsNavigationContainer" runat="server"
				        CssClass="HContainer" ContainerId="RecordsNavigation" BorderWidth="0px" CellPadding="0" CellSpacing="1">
			        </cc2:HorizontalActionContainer>
                </asp:TableCell>
                <asp:TableCell ID="TableCell2" runat="server" HorizontalAlign="Right" style="padding: 5px 20px 5px 0px; border-bottom:solid 1px #AECD76">
		            <table cellpadding="0" cellspacing="0" border="0">
			            <tr><td class="ViewImage">
					            <asp:Image ID="ViewImage" runat="server" /></td>
				            <td class="ViewCaption">
					            <asp:Label ID="ViewCaption" runat="server" Text="Contact list"></asp:Label>
				            </td>
			            </tr>
		            </table>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <table cellpadding="0" cellspacing="0" border="0" class="FullWidth"><tr>
        <td><div class="Spacer" style="height:30px;width:0px;"></div></td><td valign="middle" style="padding-left:21px; padding-bottom:5px;">
            <cc2:NavigationHistoryActionContainer ID="ViewsHistoryNavigationContainer" runat="server"
                CssClass="NavigationHistoryLinks" ContainerId="ViewsHistoryNavigation">
            </cc2:NavigationHistoryActionContainer>
        </td></tr></table>
		<table cellpadding="0" cellspacing="0" border="0" class="FullWidth">
			<tr>
				<td valign="top" style="width: 195px;padding-right:17px">
				<table cellpadding="0" cellspacing="0" bgcolor="#DAEBFB" class="FullWidth">
				<tr><td style="border-top:solid 1px #5CA0DA;"><div class="Spacer" style="height:1px"></div></td><td style="background-image:url(Images/SideBarRUCorner.gif); background-repeat:no-repeat; background-position: right top;width:8px;"><div class="Spacer" style="width:8px;height:8px;"></div></td></tr>
				<tr><td style="padding:4px 4px 4px 21px;">
					    <cc2:VerticalActionContainer ID="VerticalNewActionContainer" runat="server" ContainerId="RootObjectsCreation" CssClass="VContainer" BorderWidth="0px" CellPadding="0" CellSpacing="1"></cc2:VerticalActionContainer>
					    <cc2:VerticalActionContainer ID="VerticalToolsActionContainer" runat="server" ContainerId="Tools" CssClass="VContainer" BorderWidth="0px" CellPadding="0" CellSpacing="1"></cc2:VerticalActionContainer>
				</td><td style="border-right:solid 1px #5CA0DA;width:1px;"><div class="Spacer" style="width:1px;height:1px"></div></td></tr>
				<tr style="height:8px;"><td style="border-bottom:solid 1px #5CA0DA;"><div class="Spacer" style="height:7px"></div></td><td style="background-image:url(Images/SideBarRDCorner.gif); background-repeat:no-repeat; background-position: right bottom;"><div class="Spacer" style="width:8px;height:7px;"></div></td></tr>
				</table>
				</td>
				<td valign="top" style="padding-right: 20px;">
					<table cellpadding="0" cellspacing="0" border="0" width="100%" style="margin: 0px 0px 10px 0px">
						<tr><td style="text-align:Left; width:33%">
								<cc2:HorizontalActionContainer ID="ContextObjectsCreationActionContainer" runat="server"
									ContainerId="ObjectsCreation" CssClass="HContainer" BorderWidth="0px" CellPadding="0" CellSpacing="1">
								</cc2:HorizontalActionContainer>
							</td>
							<td style="text-align:center; width:33%">
            					<table cellpadding="0" cellspacing="0" border="0" width="100%" style="margin: 0px 0px 0px 0px">
            					    <tr>
            					        <td>
								            <cc2:HorizontalActionContainer ID="ListViewDataManagementActionContainer" runat="server"
									            ContainerId="Filters" CssClass="HContainer" BorderWidth="0px" CellPadding="0" CellSpacing="1">
								            </cc2:HorizontalActionContainer>
            					        </td>
            					        <td>
								            <cc2:HorizontalActionContainer ID="TopRecordEditActionContainer" runat="server" HorizontalAlign="Center"
									            CssClass="HContainer" ContainerId="RecordEdit" BorderWidth="0px" CellPadding="0" CellSpacing="1">
								            </cc2:HorizontalActionContainer>
            					        </td>
            					    </tr>
            					</table>
							</td>
							<td style="text-align:right; width:33%">
								<cc2:HorizontalActionContainer ID="ViewPresentationActionContainer" runat="server"
									ContainerId="View" CssClass="HContainer" BorderWidth="0px" CellPadding="0" CellSpacing="1">
								</cc2:HorizontalActionContainer>
							</td>
						</tr>
					</table>
					<tc:ErrorInfoControl ID="ErrorInfo" style="margin: 10px 0px 10px 0px" runat="server">
                    </tc:ErrorInfoControl>
                    <asp:Table ID="Table1" runat="server" Width="100%">
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server" ID="ViewSite">views content here</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
					<cc2:HorizontalActionContainer ID="BottomRecordEditActionContainer" runat="server"
						HorizontalAlign="Center" Visible="false" CssClass="HContainer" Style="padding-top: 10px"
						ContainerId="RecordEdit" BorderWidth="0px" CellPadding="0" CellSpacing="1">
					</cc2:HorizontalActionContainer>
				</td>
			</tr>
			<tr>
				<td>
					<div class="Spacer NullSize" style="width: 200px"></div>
				</td>
				<td align="center" style="padding-top: 20px">
            	    <div id="Spacer" class="Spacer"></div>
    				<cc2:NavigationLinksActionContainer CssClass="NavigationLinks" ID="NavigationLinksActionContainer" runat="server" ContainerId="ViewsNavigation">
					</cc2:NavigationLinksActionContainer>
				</td>
			</tr>
		</table>
		<div id="Footer" class="Footer">
		<table cellpadding="0" cellspacing="0" border="0" width="100%"><tr>
		<td align="left"><div class="FooterCopyright"><asp:Literal runat="server" ID="Copyright">Copyright text</asp:Literal></div></td>
		<td><cc2:WrappedHorizontalActionContainer ID="DiagnosticActionContainer" runat="server"
						HorizontalAlign="Left" ContainerId="Diagnostic" CssClass="HContainer" BorderWidth="0px" CellPadding="0" CellSpacing="1">
					</cc2:WrappedHorizontalActionContainer>
        </td>
		<td align="right"><asp:Image ID="LogoImage" runat="server" /></td>
		</tr></table></div>
	</form>
		</td></tr></table>
	<script type="text/javascript">
	<!--
	    movefooter();
        DXattachEventToElement(document.getElementById('formTable'), "resize", DXWindowOnResize);
        DXattachEventToElement(window, "resize", DXWindowOnResize);
    //-->	    
	</script>
</body>
</html>
