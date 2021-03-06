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
	public class ToolInformation : ODataObject 
	{

		public string ToolName { get; set; }

		public string Version { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as ToolInformation;
			if(typedSource != null)
			{
				ToolName = typedSource.ToolName;
				Version = typedSource.Version;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("ToolName", out token) && token.Type != JTokenType.Null)
				{
					ToolName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Version", out token) && token.Type != JTokenType.Null)
				{
					Version = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
			}
		}
	}
}