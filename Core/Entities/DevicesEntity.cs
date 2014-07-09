// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2014 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using ShareFile.Api.Models;
using ShareFile.Api.Client;
using ShareFile.Api.Client.Requests;
using ShareFile.Api.Client.Extensions;

namespace ShareFile.Api.Client.Entities
{

	public interface IDevicesEntity : IEntityBase
	{
		/// <summary>
		/// Get Device Users for Current User
		/// </summary>
		/// <returns>
		/// A feed of DeviceUser objects
		/// </returns>
		IQuery<ODataFeed<DeviceUser>> Get();
		/// <summary>
		/// Get Device by ID
		/// </summary>
		/// <param name="url"></param>
		/// <returns>
		/// Device
		/// </returns>
		IQuery<Device> Get(Uri url);
		IQuery<ODataFeed<DeviceUser>> GetByUser(Uri url);
		/// <summary>
		/// Delete Device
		/// </summary>
		/// <param name="url"></param>
		/// <returns>
		/// no data on success
		/// </returns>
		IQuery Delete(Uri url);
		IQuery DeleteByUser(Uri url, string deviceId);
		IQuery<DeviceUser> CreateByUser(Uri url, DeviceUser du);
		/// <summary>
		/// Wipe Device
		/// </summary>
		/// <param name="deviceUrl"></param>
		/// <param name="userid"></param>
		/// <returns>
		/// no data on success
		/// </returns>
		IQuery Wipe(Uri deviceUrl, string userid = null);
		/// <summary>
		/// Signal Wipe Done
		/// </summary>
		/// <example>
		/// {
		/// "Logs" :
		/// [
		/// { "FileName":"fileA",
		/// "FileID":"id",
		/// "Timestamp":0,
		/// "AccountID":"id",
		/// "UserID":"userId1",
		/// "Action":"OpenGeneric",
		/// "AdditionalInfo":""
		/// },
		/// ...
		/// ],
		/// "WipeResults" :
		/// [
		/// {"id":"userId1", "WipeToken":"token1", "Success":"true", "ErrorMessage":"" },
		/// {"id":"userId1", "WipeToken":"token2", "Success":"false", "ErrorMessage":"some error" },
		/// ...
		/// ]
		/// }
		/// </example>
		/// <remarks>
		/// Signal that a device wipe has been completed
		/// </remarks>
		/// <param name="deviceUrl"></param>
		/// <param name="deviceWipeReport"></param>
		/// <param name="singlePlane"></param>
		/// <returns>
		/// no data on success
		/// </returns>
		IQuery WipeDone(Uri deviceUrl, DeviceWipeReport deviceWipeReport, bool singlePlane = false);
		/// <summary>
		/// Check Device Status
		/// </summary>
		/// <param name="deviceUrl"></param>
		/// <param name="singlePlane"></param>
		/// <returns>
		/// DeviceStatus
		/// </returns>
		IQuery<DeviceStatus> Status(Uri deviceUrl, bool singlePlane = false);
	}

	public class DevicesEntity : EntityBase, IDevicesEntity
	{
		public DevicesEntity(IShareFileClient client)
			: base (client, "Devices")
			
		{

		}

		/// <summary>
		/// Get Device Users for Current User
		/// </summary>
		/// <returns>
		/// A feed of DeviceUser objects
		/// </returns>
		public IQuery<ODataFeed<DeviceUser>> Get()
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<DeviceUser>>(Client);
			sfApiQuery.From("Devices");
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get Device by ID
		/// </summary>
		/// <param name="url"></param>
		/// <returns>
		/// Device
		/// </returns>
		public IQuery<Device> Get(Uri url)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Device>(Client);
			sfApiQuery.Uri(url);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		public IQuery<ODataFeed<DeviceUser>> GetByUser(Uri url)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<DeviceUser>>(Client);
			sfApiQuery.Action("Devices");
			sfApiQuery.Uri(url);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Delete Device
		/// </summary>
		/// <param name="url"></param>
		/// <returns>
		/// no data on success
		/// </returns>
		public IQuery Delete(Uri url)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.Uri(url);
			sfApiQuery.HttpMethod = "DELETE";
			return sfApiQuery;
		}

		public IQuery DeleteByUser(Uri url, string deviceId)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.Action("Devices");
			sfApiQuery.Uri(url);
			sfApiQuery.ActionIds(deviceId);
			sfApiQuery.HttpMethod = "DELETE";
			return sfApiQuery;
		}

		public IQuery<DeviceUser> CreateByUser(Uri url, DeviceUser du)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<DeviceUser>(Client);
			sfApiQuery.Action("Devices");
			sfApiQuery.Uri(url);
			sfApiQuery.Body = du;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Wipe Device
		/// </summary>
		/// <param name="deviceUrl"></param>
		/// <param name="userid"></param>
		/// <returns>
		/// no data on success
		/// </returns>
		public IQuery Wipe(Uri deviceUrl, string userid = null)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.Action("Wipe");
			sfApiQuery.Uri(deviceUrl);
			sfApiQuery.QueryString("userid", userid);
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Signal Wipe Done
		/// </summary>
		/// <example>
		/// {
		/// "Logs" :
		/// [
		/// { "FileName":"fileA",
		/// "FileID":"id",
		/// "Timestamp":0,
		/// "AccountID":"id",
		/// "UserID":"userId1",
		/// "Action":"OpenGeneric",
		/// "AdditionalInfo":""
		/// },
		/// ...
		/// ],
		/// "WipeResults" :
		/// [
		/// {"id":"userId1", "WipeToken":"token1", "Success":"true", "ErrorMessage":"" },
		/// {"id":"userId1", "WipeToken":"token2", "Success":"false", "ErrorMessage":"some error" },
		/// ...
		/// ]
		/// }
		/// </example>
		/// <remarks>
		/// Signal that a device wipe has been completed
		/// </remarks>
		/// <param name="deviceUrl"></param>
		/// <param name="deviceWipeReport"></param>
		/// <param name="singlePlane"></param>
		/// <returns>
		/// no data on success
		/// </returns>
		public IQuery WipeDone(Uri deviceUrl, DeviceWipeReport deviceWipeReport, bool singlePlane = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.Action("WipeDone");
			sfApiQuery.Uri(deviceUrl);
			sfApiQuery.QueryString("singlePlane", singlePlane);
			sfApiQuery.Body = deviceWipeReport;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Check Device Status
		/// </summary>
		/// <param name="deviceUrl"></param>
		/// <param name="singlePlane"></param>
		/// <returns>
		/// DeviceStatus
		/// </returns>
		public IQuery<DeviceStatus> Status(Uri deviceUrl, bool singlePlane = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<DeviceStatus>(Client);
			sfApiQuery.Action("Status");
			sfApiQuery.Uri(deviceUrl);
			sfApiQuery.QueryString("singlePlane", singlePlane);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

	}
}