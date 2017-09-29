<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Richtext.aspx.cs" Inherits="DXWebForms.Richtext" %>

<%@ Register Assembly="DevExpress.Web.ASPxRichEdit.v16.2, Version=16.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRichEdit" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="row">
        <div class="twelve columns">
            <h4>Richtext Editing</h4>
            <div>
				<dx:ASPxRichEdit ID="ASPxRichEdit1" runat="server" WorkDirectory="~\App_Data\WorkDirectory" Width="100%"></dx:ASPxRichEdit>
			</div>
		</div>
	</div>
</asp:Content>
