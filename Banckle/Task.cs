using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banckle
{
	/// <summary>
	/// Task Details
	/// </summary>
	public class Task : BanckleCRM
	{
		/// <summary>
		/// "tenantId": "56dc07c434c94bc094f96d93f0c20342",
		/// </summary>
		public string tenantId { get; set; }
		public string version { get; set; }				//      "version": 4,
		public string name { get; set; }				//      "name": "New Plan",
		public bool favorite { get; set; }				//    "favorite": false,
		public ContactDetails[] contacts { get; set; }	//      "contacts": [],
		public Deal[] deals { get; set; }					//    "deals": [],
		public string startDate { get; set; }			//    "startDate": "2014-01-05T07:49:00.0000000Z",
		public string endDate { get; set; }				//    "finishDate": "2014-01-05T07:49:00.0000000Z",
		public bool done { get; set; }					//    "done": false,
		public string creatorId { get; set; }			//      "creatorId": "56dc07c434c94bc094f96d93f0c20342",
		public string creatorName { get; set; }			//      "creatorName": "imranwar",
		public string assigneeId { get; set; }			//      "assigneeId": "31dc674c93e045afaac319a5c8413506",
		public string assigneeName { get; set; }		//      "assigneeName": "imranwar",
		public Tags[] tags { get; set; }				//      "tags": [],
		public string id { get; set; }					//    "id": "4685bff4f3994a30b385a3493f3c392c",
		public string created { get; set; }				//    "created": "2014-01-05T06:17:22.3030000Z",
		public string updated { get; set; }				//    "updated": "2014-01-05T06:17:22.3030000Z"


	}
}