﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DXData.Chinook
{

	[Persistent(@"Appointments")]
	public partial class XPOAppointment : XPLiteObject
	{
		int _UniqueID;
		[Key(true)]
		public int UniqueID
		{
			get { return _UniqueID; }
			set { SetPropertyValue<int>("UniqueID", ref _UniqueID, value); }
		}
		int _Type;
		public int Type
		{
			get { return _Type; }
			set { SetPropertyValue<int>("Type", ref _Type, value); }
		}
		DateTime _StartDate;
		public DateTime StartDate
		{
			get { return _StartDate; }
			set { SetPropertyValue<DateTime>("StartDate", ref _StartDate, value); }
		}
		DateTime _EndDate;
		public DateTime EndDate
		{
			get { return _EndDate; }
			set { SetPropertyValue<DateTime>("EndDate", ref _EndDate, value); }
		}
		bool _AllDay;
		public bool AllDay
		{
			get { return _AllDay; }
			set { SetPropertyValue<bool>("AllDay", ref _AllDay, value); }
		}
		string _Subject;
		[Size(50)]
		public string Subject
		{
			get { return _Subject; }
			set { SetPropertyValue<string>("Subject", ref _Subject, value); }
		}
		string _Location;
		[Size(50)]
		public string Location
		{
			get { return _Location; }
			set { SetPropertyValue<string>("Location", ref _Location, value); }
		}
		string _Description;
		[Size(SizeAttribute.Unlimited)]
		public string Description
		{
			get { return _Description; }
			set { SetPropertyValue<string>("Description", ref _Description, value); }
		}
		int _Status;
		public int Status
		{
			get { return _Status; }
			set { SetPropertyValue<int>("Status", ref _Status, value); }
		}
		int _Label;
		public int Label
		{
			get { return _Label; }
			set { SetPropertyValue<int>("Label", ref _Label, value); }
		}
		int _ResourceID;
		public int ResourceID
		{
			get { return _ResourceID; }
			set { SetPropertyValue<int>("ResourceID", ref _ResourceID, value); }
		}
		string _ResourceIDs;
		[Size(SizeAttribute.Unlimited)]
		public string ResourceIDs
		{
			get { return _ResourceIDs; }
			set { SetPropertyValue<string>("ResourceIDs", ref _ResourceIDs, value); }
		}
		string _ReminderInfo;
		[Size(SizeAttribute.Unlimited)]
		public string ReminderInfo
		{
			get { return _ReminderInfo; }
			set { SetPropertyValue<string>("ReminderInfo", ref _ReminderInfo, value); }
		}
		string _RecurrenceInfo;
		[Size(SizeAttribute.Unlimited)]
		public string RecurrenceInfo
		{
			get { return _RecurrenceInfo; }
			set { SetPropertyValue<string>("RecurrenceInfo", ref _RecurrenceInfo, value); }
		}
		string _CustomField1;
		[Size(SizeAttribute.Unlimited)]
		public string CustomField1
		{
			get { return _CustomField1; }
			set { SetPropertyValue<string>("CustomField1", ref _CustomField1, value); }
		}
	}

}
