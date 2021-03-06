﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Text;


namespace Banckle
{

	/// <summary>
	/// 
	/// </summary>
	public class Auth : BanckleCRM
	{
		/// <summary>
		/// 
		/// </summary>
		public string json = "";
		/// <summary>
		/// 
		/// </summary>
		public string APIKey;

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string getToken(string username, string password)
		{
            string payload = "{\"userEmail\":\""+username+"\",\"password\":\""+password+"\"}";

			JavaScriptSerializer serializer = new JavaScriptSerializer();
			// Deserialize
            json = bancklePOSTRequest("https://apps.banckle.com/api/v2/auth/token" + "?format=json", APIKey, "", payload);

			TokenResponse authResponse = serializer.Deserialize<TokenResponse>(json);

			if (!String.IsNullOrEmpty(authResponse.status))
				return authResponse.authorization.token;
			else
				return authResponse.status;
		}
	}
}
