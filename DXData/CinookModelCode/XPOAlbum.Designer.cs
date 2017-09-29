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

	[Persistent(@"Album")]
	public partial class XPOAlbum : XPLiteObject
	{
		int _AlbumId;
		[Key(true)]
		public int AlbumId
		{
			get { return _AlbumId; }
			set { SetPropertyValue<int>("AlbumId", ref _AlbumId, value); }
		}
		string _Title;
		[Size(160)]
		public string Title
		{
			get { return _Title; }
			set { SetPropertyValue<string>("Title", ref _Title, value); }
		}
		XPOArtist _ArtistId;
		[Association(@"XPOAlbumReferencesXPOArtist")]
		public XPOArtist ArtistId
		{
			get { return _ArtistId; }
			set { SetPropertyValue<XPOArtist>("ArtistId", ref _ArtistId, value); }
		}
		[Association(@"XPOTrackReferencesXPOAlbum")]
		public XPCollection<XPOTrack> Tracks { get { return GetCollection<XPOTrack>("Tracks"); } }
	}

}
