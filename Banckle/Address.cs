using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banckle
{
	/// <summary>
	/// Address details of a contact
	/// </summary>
	public class Address : BanckleCRM
	{

		public string parentId { get; set; }			//    "parentId": "84bdeebab20848aaa58be174ed44da00",
		public string building { get; set; }			//    "building": "",
		public string street { get; set; }				//    "street": "fsd colony",
		public string city { get; set; }				//    "city": "fsd",
		public string zip { get; set; }					//    "zip": "38000",
		public string country { get; set; }				//    "country": "Pakistan",
		public string state { get; set; }				//    "state": "punjab",
		public string id { get; set; }					//    "id": "4685bff4f3994a30b385a3493f3c392c",
		public string created { get; set; }				//    "created": "2014-01-05T06:17:22.3030000Z",
		public string updated { get; set; }				//    "updated": "2014-01-05T06:17:22.3030000Z"

	}
}