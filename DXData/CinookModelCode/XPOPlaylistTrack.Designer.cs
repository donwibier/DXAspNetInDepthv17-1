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

	[Persistent(@"PlaylistTrack")]
	public partial class XPOPlaylistTrack : XPLiteObject
	{
		public struct CompoundKey1Struct
		{
			[Persistent("PlaylistId")]
			public int PlaylistId { get; set; }
			[Persistent("TrackId")]
			public int TrackId { get; set; }
		}
		[Key, Persistent]
		public CompoundKey1Struct CompoundKey1;
	}

}
