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
		public string parentId { get; set; }			//    "parentId": "84bdeebab20848aaa58be174ed44da00",
		public string type { get; set; }				//    "type": "office",
		public string network { get; set; }				//    "network": "facebook",
		public string address { get; set; }				//    "address": "http   banckle.com",
		public string id { get; set; }					//    "id": "4685bff4f3994a30b385a3493f3c392c",
		public string created { get; set; }				//    "created": "2014-01-05T06:17:22.3030000Z",
		public string updated { get; set; }				//    "updated": "2014-01-05T06:17:22.3030000Z"
	}
}