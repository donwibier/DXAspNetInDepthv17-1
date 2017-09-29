<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Agenda.aspx.cs" Inherits="DXWebForms.Agenda" %>

<%@ Register Assembly="DevExpress.Web.ASPxScheduler.v16.2, Version=16.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxScheduler" TagPrefix="dxwschs" %>
<%@ Register assembly="DevExpress.XtraScheduler.v16.2.Core, Version=16.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraScheduler" tagprefix="cc1" %>
<%@ Register assembly="DevExpress.Xpo.v16.2, Version=16.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Xpo" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="row">
        <div class="twelve columns">
            <h4>Agenda</h4>
            <div>
				<dxwschs:ASPxScheduler ID="ASPxScheduler1" runat="server" AppointmentDataSourceID="XpoAppointments" ClientIDMode="AutoID" DataMember="" DataSourceID="" OnAppointmentsChanged="ASPxScheduler1_AppointmentsChanged" OnAppointmentsDeleted="ASPxScheduler1_AppointmentsDeleted" OnAppointmentsInserted="ASPxScheduler1_AppointmentsInserted" OnResourcesChanged="ASPxScheduler1_ResourcesChanged" OnResourcesDeleted="ASPxScheduler1_ResourcesDeleted" OnResourcesInserted="ASPxScheduler1_ResourcesInserted" Start="2017-09-29" Width="100%">
					<Storage>
						<Appointments AutoRetrieveId="True">
							<Mappings AllDay="AllDay" AppointmentId="UniqueID" Description="Description" End="EndDate" Label="Label" Location="Location" RecurrenceInfo="RecurrenceInfo" ReminderInfo="ReminderInfo" ResourceId="ResourceID" Start="StartDate" Status="Status" Subject="Subject" Type="Type" />
						</Appointments>
					</Storage>
					<Views>
<DayView><TimeRulers>
<cc1:TimeRuler></cc1:TimeRuler>
</TimeRulers>

<AppointmentDisplayOptions ColumnPadding-Left="2" ColumnPadding-Right="4"></AppointmentDisplayOptions>
</DayView>

<WorkWeekView><TimeRulers>
<cc1:TimeRuler></cc1:TimeRuler>
</TimeRulers>

<AppointmentDisplayOptions ColumnPadding-Left="2" ColumnPadding-Right="4"></AppointmentDisplayOptions>
</WorkWeekView>

						<WeekView Enabled="false"></WeekView>
						<FullWeekView Enabled="true">
							<TimeRulers>
<cc1:TimeRuler></cc1:TimeRuler>
</TimeRulers>

<AppointmentDisplayOptions ColumnPadding-Left="2" ColumnPadding-Right="4"></AppointmentDisplayOptions>
						</FullWeekView>
					</Views>

				</dxwschs:ASPxScheduler>
				<dx:XpoDataSource ID="XpoAppointments" runat="server" DefaultSorting="" OnInit="xpDatasource_Init" TypeName="DXData.Chinook.XPOAppointment">
				</dx:XpoDataSource>
			</div>
		</div>
	</div>
</asp:Content>
