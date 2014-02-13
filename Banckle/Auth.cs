using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;

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
		public bool authenticate()
		{
			JavaScriptSerializer serializer = new JavaScriptSerializer();
			// Deserialize
			json = banckleRequest("https://crm-api.banckle.com/v1.0/auth" + "?format=json", APIKey);

			//var deserializedResult = serializer.Deserialize<List<Person>>(serializedResult);
			AuthResponse authResponse = serializer.Deserialize<AuthResponse>(json);

			if (!String.IsNullOrEmpty(authResponse.sessionId))
				return true;
			else
				return false;

			//return json;

		}
	}
}
