using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banckle
{
	/// <summary>
	/// 
	/// </summary>
	public class AuthResponse
	{
		//"sessionId": "JTHDP58msNbk0oiB/pTe",
		/// <summary>
		/// 
		/// </summary>
		public string sessionId { get; set; }
		//"referrerUrl": "https://crm-api.banckle.com/",
		/// <summary>
		/// 
		/// </summary>
		public string referrerUrl { get; set; }
		///"responseStatus": {}
		/// <summary>
		/// 
		/// </summary>
		public ResponseStatus responseStatus { get; set; }
	}
}
