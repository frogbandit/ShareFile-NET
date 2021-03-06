// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2015 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;

namespace ShareFile.Api.Models 
{
	public class ItemInfo : ODataObject 
	{

		public AccessControl CurrentAccessControl { get; set; }

		public bool? HasVroot { get; set; }

		public bool? IsSystemRoot { get; set; }

		public bool? IsAccountRoot { get; set; }

		public bool? IsVRoot { get; set; }

		public bool? IsMyFolders { get; set; }

		public bool? IsAHomeFolder { get; set; }

		public bool? IsMyHomeFolder { get; set; }

		public bool? IsAStartFolder { get; set; }

		public bool? IsSharedFolder { get; set; }

		public bool? IsPassthrough { get; set; }

		public bool? IsVersioned { get; set; }

		public bool? CanAddFolder { get; set; }

		public bool? CanAddNode { get; set; }

		public bool? CanView { get; set; }

		public bool? CanDownload { get; set; }

		public bool? CanWatermarkDownload { get; set; }

		public bool? CanDocViewerPrint { get; set; }

		public bool? CanUpload { get; set; }

		public bool? CanSend { get; set; }

		public bool? CanDeleteCurrentItem { get; set; }

		public bool? CanDeleteChildItems { get; set; }

		public bool? CanManagePermissions { get; set; }

		public bool? CanEditFolderOpts { get; set; }

		public string FolderPayID { get; set; }

		public bool? ShowFolderPayBuyButton { get; set; }

		public SafeEnum<TreeMode> TreeMode { get; set; }

		public bool? TreeModeOperationAllowed { get; set; }

		public string TreeModeSourceId { get; set; }

		public string ForcedSortField { get; set; }

		public string ForcedSortOrder { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as ItemInfo;
			if(typedSource != null)
			{
				CurrentAccessControl = typedSource.CurrentAccessControl;
				HasVroot = typedSource.HasVroot;
				IsSystemRoot = typedSource.IsSystemRoot;
				IsAccountRoot = typedSource.IsAccountRoot;
				IsVRoot = typedSource.IsVRoot;
				IsMyFolders = typedSource.IsMyFolders;
				IsAHomeFolder = typedSource.IsAHomeFolder;
				IsMyHomeFolder = typedSource.IsMyHomeFolder;
				IsAStartFolder = typedSource.IsAStartFolder;
				IsSharedFolder = typedSource.IsSharedFolder;
				IsPassthrough = typedSource.IsPassthrough;
				IsVersioned = typedSource.IsVersioned;
				CanAddFolder = typedSource.CanAddFolder;
				CanAddNode = typedSource.CanAddNode;
				CanView = typedSource.CanView;
				CanDownload = typedSource.CanDownload;
				CanWatermarkDownload = typedSource.CanWatermarkDownload;
				CanDocViewerPrint = typedSource.CanDocViewerPrint;
				CanUpload = typedSource.CanUpload;
				CanSend = typedSource.CanSend;
				CanDeleteCurrentItem = typedSource.CanDeleteCurrentItem;
				CanDeleteChildItems = typedSource.CanDeleteChildItems;
				CanManagePermissions = typedSource.CanManagePermissions;
				CanEditFolderOpts = typedSource.CanEditFolderOpts;
				FolderPayID = typedSource.FolderPayID;
				ShowFolderPayBuyButton = typedSource.ShowFolderPayBuyButton;
				TreeMode = typedSource.TreeMode;
				TreeModeOperationAllowed = typedSource.TreeModeOperationAllowed;
				TreeModeSourceId = typedSource.TreeModeSourceId;
				ForcedSortField = typedSource.ForcedSortField;
				ForcedSortOrder = typedSource.ForcedSortOrder;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("CurrentAccessControl", out token) && token.Type != JTokenType.Null)
				{
					CurrentAccessControl = (AccessControl)serializer.Deserialize(token.CreateReader(), typeof(AccessControl));
				}
				if(source.TryGetProperty("HasVroot", out token) && token.Type != JTokenType.Null)
				{
					HasVroot = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("IsSystemRoot", out token) && token.Type != JTokenType.Null)
				{
					IsSystemRoot = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("IsAccountRoot", out token) && token.Type != JTokenType.Null)
				{
					IsAccountRoot = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("IsVRoot", out token) && token.Type != JTokenType.Null)
				{
					IsVRoot = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("IsMyFolders", out token) && token.Type != JTokenType.Null)
				{
					IsMyFolders = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("IsAHomeFolder", out token) && token.Type != JTokenType.Null)
				{
					IsAHomeFolder = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("IsMyHomeFolder", out token) && token.Type != JTokenType.Null)
				{
					IsMyHomeFolder = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("IsAStartFolder", out token) && token.Type != JTokenType.Null)
				{
					IsAStartFolder = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("IsSharedFolder", out token) && token.Type != JTokenType.Null)
				{
					IsSharedFolder = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("IsPassthrough", out token) && token.Type != JTokenType.Null)
				{
					IsPassthrough = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("IsVersioned", out token) && token.Type != JTokenType.Null)
				{
					IsVersioned = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("CanAddFolder", out token) && token.Type != JTokenType.Null)
				{
					CanAddFolder = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("CanAddNode", out token) && token.Type != JTokenType.Null)
				{
					CanAddNode = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("CanView", out token) && token.Type != JTokenType.Null)
				{
					CanView = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("CanDownload", out token) && token.Type != JTokenType.Null)
				{
					CanDownload = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("CanWatermarkDownload", out token) && token.Type != JTokenType.Null)
				{
					CanWatermarkDownload = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("CanDocViewerPrint", out token) && token.Type != JTokenType.Null)
				{
					CanDocViewerPrint = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("CanUpload", out token) && token.Type != JTokenType.Null)
				{
					CanUpload = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("CanSend", out token) && token.Type != JTokenType.Null)
				{
					CanSend = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("CanDeleteCurrentItem", out token) && token.Type != JTokenType.Null)
				{
					CanDeleteCurrentItem = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("CanDeleteChildItems", out token) && token.Type != JTokenType.Null)
				{
					CanDeleteChildItems = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("CanManagePermissions", out token) && token.Type != JTokenType.Null)
				{
					CanManagePermissions = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("CanEditFolderOpts", out token) && token.Type != JTokenType.Null)
				{
					CanEditFolderOpts = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("FolderPayID", out token) && token.Type != JTokenType.Null)
				{
					FolderPayID = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("ShowFolderPayBuyButton", out token) && token.Type != JTokenType.Null)
				{
					ShowFolderPayBuyButton = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("TreeMode", out token) && token.Type != JTokenType.Null)
				{
					TreeMode = (SafeEnum<TreeMode>)serializer.Deserialize(token.CreateReader(), typeof(SafeEnum<TreeMode>));
				}
				if(source.TryGetProperty("TreeModeOperationAllowed", out token) && token.Type != JTokenType.Null)
				{
					TreeModeOperationAllowed = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("TreeModeSourceId", out token) && token.Type != JTokenType.Null)
				{
					TreeModeSourceId = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("ForcedSortField", out token) && token.Type != JTokenType.Null)
				{
					ForcedSortField = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("ForcedSortOrder", out token) && token.Type != JTokenType.Null)
				{
					ForcedSortOrder = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
			}
		}
	}
}