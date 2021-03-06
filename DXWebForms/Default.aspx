﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DXWebForms.Default" %>

<%@ Register Assembly="DevExpress.Xpo.v17.1, Version=17.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Xpo" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="row">
        <div class="twelve columns">
            <h4>Orders</h4>
            <div>				
				<span class="show-me-the-hint">Show the hint</span>
				<dx:ASPxHint runat="server" ID="showMeHint" TargetSelector=".show-me-the-hint" Content="Here is your hint"></dx:ASPxHint>

				<dx:ASPxHint ID="gridHint" runat="server" TargetSelector=".dx-ellipsis"  />
				<dx:XpoDataSource ID="xpInvoices" runat="server" OnInit="xpDatasource_Init" TypeName="DXData.Chinook.XPOInvoice" ServerMode="True"></dx:XpoDataSource>
				<dx:XpoDataSource ID="xpCustomer" runat="server" OnInit="xpDatasource_Init" TypeName="DXData.Chinook.XPOCustomer"></dx:XpoDataSource>
				<dx:ASPxGridView ID="gridTracks" runat="server" DataSourceID="xpInvoices" AutoGenerateColumns="False" Width="100%" 
					KeyFieldName="InvoiceId" 
					OnRowDeleted="grid_RowDeleted" OnRowInserted="grid_RowInserted" OnRowUpdated="grid_RowUpdated">					
					<SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="True">
					</SettingsAdaptivity>
					<SettingsEditing Mode="PopupEditForm">
					</SettingsEditing>
					<Settings ShowFilterRow="True" />
					<SettingsCustomizationDialog Enabled="True" />
					<SettingsBehavior ConfirmDelete="True" AllowEllipsisInText="true" AllowFocusedRow="True" />
					<SettingsPopup>
						<EditForm HorizontalAlign="WindowCenter" Modal="True" VerticalAlign="WindowCenter" />
					</SettingsPopup>
					<SettingsSearchPanel Visible="True" />
					<ClientSideEvents EndCallback="function(s, e) { ASPxClientHint.Update(); }" />
					<EditFormLayoutProperties ColCount="2">
						<Items>
							<dx:GridViewColumnLayoutItem ColumnName="InvoiceDate">
							</dx:GridViewColumnLayoutItem>
							<dx:GridViewColumnLayoutItem ColumnName="Total">
							</dx:GridViewColumnLayoutItem>
							<dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="CustomerId!Key">
							</dx:GridViewColumnLayoutItem>
							<dx:GridViewLayoutGroup Caption="Billing info" ColCount="3" ColSpan="2">
								<Items>
									<dx:GridViewColumnLayoutItem Caption="Address" ColSpan="3" ColumnName="BillingAddress">
									</dx:GridViewColumnLayoutItem>
									<dx:GridViewColumnLayoutItem Caption="Zip code" ColumnName="BillingPostalCode" ColSpan="1">
									</dx:GridViewColumnLayoutItem>
									<dx:GridViewColumnLayoutItem Caption="City" ColumnName="BillingCity" ColSpan="1">
									</dx:GridViewColumnLayoutItem>
									<dx:GridViewColumnLayoutItem Caption="State" ColumnName="BillingState" ColSpan="1">
										
									</dx:GridViewColumnLayoutItem>
									<dx:GridViewColumnLayoutItem Caption="Country" ColSpan="3" ColumnName="BillingCountry">
									</dx:GridViewColumnLayoutItem>
								</Items>
								<SettingsItemCaptions Location="Top" />
								<SettingsItems ShowCaption="False" />
							</dx:GridViewLayoutGroup>
							<dx:EditModeCommandLayoutItem ColSpan="2" HorizontalAlign="Right">
							</dx:EditModeCommandLayoutItem>
						</Items>						
					</EditFormLayoutProperties>
					
					<Columns>
						<%--<dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="True" ShowNewButtonInHeader="True" 
							VisibleIndex="1" >
						</dx:GridViewCommandColumn>--%>
						<dx:GridViewDataDateColumn FieldName="InvoiceDate" 
							VisibleIndex="3" >
						</dx:GridViewDataDateColumn>
						<dx:GridViewDataComboBoxColumn AllowTextTruncationInAdaptiveMode="True" Caption="Customer" 
								FieldName="CustomerId!Key" VisibleIndex="4" AdaptivePriority="1">
							<PropertiesComboBox DataSourceID="xpCustomer" TextField="Company" ValueField="CustomerId" 
								TextFormatString="{1}, {2}" LoadDropDownOnDemand="True">
								<Columns>
									<dx:ListBoxColumn FieldName="Company">
									</dx:ListBoxColumn>
									<dx:ListBoxColumn FieldName="LastName">
									</dx:ListBoxColumn>
									<dx:ListBoxColumn FieldName="FirstName">
									</dx:ListBoxColumn>
								</Columns>
							</PropertiesComboBox>
						</dx:GridViewDataComboBoxColumn>
						<dx:GridViewDataTextColumn AllowTextTruncationInAdaptiveMode="True" FieldName="BillingAddress" 
							VisibleIndex="5" AdaptivePriority="3">
							<PropertiesTextEdit NullText="Address">
							</PropertiesTextEdit>
						</dx:GridViewDataTextColumn>
						<dx:GridViewDataTextColumn AllowTextTruncationInAdaptiveMode="True" FieldName="BillingCity" VisibleIndex="6" 
							AdaptivePriority="3">
							<PropertiesTextEdit NullText="City">
							</PropertiesTextEdit>
						</dx:GridViewDataTextColumn>
						<dx:GridViewDataTextColumn AllowTextTruncationInAdaptiveMode="True" FieldName="BillingState" VisibleIndex="7" 
							AdaptivePriority="3">
							<PropertiesTextEdit NullText="State" NullTextDisplayMode="UnfocusedAndFocused">
							</PropertiesTextEdit>
						</dx:GridViewDataTextColumn>
						<dx:GridViewDataTextColumn AllowTextTruncationInAdaptiveMode="True" FieldName="BillingCountry" VisibleIndex="8" AdaptivePriority="3">
							<PropertiesTextEdit NullText="Country">
							</PropertiesTextEdit>
						</dx:GridViewDataTextColumn>
						<dx:GridViewDataTextColumn AllowTextTruncationInAdaptiveMode="True" FieldName="BillingPostalCode" VisibleIndex="9" AdaptivePriority="3">
							<PropertiesTextEdit NullText="Zip code">
							</PropertiesTextEdit>
						</dx:GridViewDataTextColumn>
						<dx:GridViewDataSpinEditColumn FieldName="Total" VisibleIndex="10">
							<PropertiesSpinEdit DecimalPlaces="2" DisplayFormatString="c" NumberFormat="Custom">
							</PropertiesSpinEdit>
						</dx:GridViewDataSpinEditColumn>
					</Columns>
					
					<Toolbars>
						<dx:GridViewToolbar EnableAdaptivity="True" ItemAlign="Right">
							<Items>
								<dx:GridViewToolbarItem Command="New">
								</dx:GridViewToolbarItem>
								<dx:GridViewToolbarItem Command="Edit">
								</dx:GridViewToolbarItem>
								<dx:GridViewToolbarItem Command="Delete">
								</dx:GridViewToolbarItem>
								<dx:GridViewToolbarItem BeginGroup="True" Command="ShowCustomizationDialog">
								</dx:GridViewToolbarItem>
							</Items>
						</dx:GridViewToolbar>
					</Toolbars>
					
				</dx:ASPxGridView>
				<span class="show-me-the-hint">Show the same hint</span>
            </div>
        </div>
    </div>
</asp:Content>

