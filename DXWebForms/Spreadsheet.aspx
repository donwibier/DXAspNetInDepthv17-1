<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Spreadsheet.aspx.cs" Inherits="DXWebForms.Spreadsheet" %>

<%@ Register Assembly="DevExpress.Web.ASPxSpreadsheet.v16.2, Version=16.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxSpreadsheet" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="row">
        <div class="twelve columns">
            <h4>Calculating</h4>
            <div>
				<dx:ASPxSpreadsheet ID="ASPxSpreadsheet1" runat="server" WorkDirectory="~/App_Data/WorkDirectory" Width="100%" Height="579px"></dx:ASPxSpreadsheet>
			</div>
		</div>
	</div>

</asp:Content>
