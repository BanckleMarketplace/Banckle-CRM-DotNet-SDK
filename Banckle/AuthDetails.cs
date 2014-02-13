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
	public class AuthDetails : BanckleCRM
	{
		/// <summary>
		/// 
		/// </summary>
		public string provider { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string State { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string oauth_token { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string oauth_verifier { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string UserName { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Password { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string RememberMe { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Continue { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string nonce { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string uri { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string response { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string qop { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string nc { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string cnonce { get; set; }
	}
}
