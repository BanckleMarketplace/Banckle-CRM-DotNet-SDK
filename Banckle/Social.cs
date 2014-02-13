using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banckle
{
	/// <summary>
	/// Social Networks associations of the contact
	/// </summary>
	public class Social : BanckleCRM
	{
		/// <summary>
		/// 
		/// </summary>
		public string parentId { get; set; }			//    "parentId": "84bdeebab20848aaa58be174ed44da00",
		/// <summary>
		/// 
		/// </summary>
		public string type { get; set; }				//    "type": "office",
		/// <summary>
		/// 
		/// </summary>
		public string network { get; set; }				//    "network": "facebook",
		/// <summary>
		/// 
		/// </summary>
		public string address { get; set; }				//    "address": "http   banckle.com",
		/// <summary>
		/// 
		/// </summary>
		public string id { get; set; }					//    "id": "4685bff4f3994a30b385a3493f3c392c",
		/// <summary>
		/// 
		/// </summary>
		public string created { get; set; }				//    "created": "2014-01-05T06:17:22.3030000Z",
		/// <summary>
		/// 
		/// </summary>
		public string updated { get; set; }				//    "updated": "2014-01-05T06:17:22.3030000Z"

		/// <summary>
		/// 
		/// </summary>
		public Social()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="type"></param>
		/// <param name="network"></param>
		/// <param name="address"></param>
		public Social(string type, string network, string address)
		{
			this.type = type;
			this.network = network;
			this.address = address;
		}
	}
}