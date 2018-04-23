<%@ Control Language="vb" AutoEventWireup="true" Inherits="NestedFrameControl" Codebehind="NestedFrameControl.ascx.vb" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v8.2" Namespace="DevExpress.ExpressApp.Web.Templates.ActionContainers" TagPrefix="cc2" %>
<table class="NestedFrame" cellpadding="0" cellspacing="0">
	<tr>
		<td align="left">
			<table border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td>
						<asp:Image ID="ViewImage" CssClass="NestedViewImage" runat="server" ImageUrl="~/Images/ViewImage.png" />
					</td>
					<td>
						<asp:Label ID="ViewCaption" CssClass="NestedViewCaption" runat="server" Text="Contact list" />
					</td>
				</tr>
			</table>
		</td>
		<td align="right" style="padding-bottom: 4px">
			<cc2:HorizontalActionContainer style="display: inline;" ID="ContextObjectsCreationActionContainer" runat="server" ContainerId="ObjectsCreation"></cc2:HorizontalActionContainer>
			<cc2:HorizontalActionContainer style="display: inline;" ID="RecordEditContainer" runat="server" ContainerId="RecordEdit"></cc2:HorizontalActionContainer>
			<cc2:HorizontalActionContainer style="display: inline;" ID="ViewContainer" runat="server" ContainerId="View"></cc2:HorizontalActionContainer>
			<cc2:HorizontalActionContainer style="display: inline;" ID="DiagnosticActionContainer" runat="server" ContainerId="Diagnostic"></cc2:HorizontalActionContainer>
		</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:Panel ID="ViewSite" runat="server"> </asp:Panel>
		</td>
	</tr>
</table>
