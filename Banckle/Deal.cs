using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banckle
{
	/// <summary>
	/// Deal details
	/// </summary>
	public class Deal : BanckleCRM
	{
		/// <summary>
		/// "tenantId": "56dc07c434c94bc094f96d93f0c20342",
		/// </summary>
		public string tenantId { get; set; }
		public string version { get; set; }				//      "version": 4,
		public bool isHot { get; set; }					//		"isHot": false,
		public string name { get; set; }				//      "name": "New Plan",
		public ContactDetails[] contacts { get; set; }	//      "contacts": [],
		public string stageId { get; set; }				//      "stageId": "84bdeebab20848aaa58be174ed44da00",
		public string stageName { get; set; }			//      "stageName": "Incoming",
		public string stageDate { get; set; }			//      "stageDate": "2014-01-05T07:48:37.6220000Z",
		public string dealSourceId { get; set; }		//      "dealSourceId": "a87d3a0d6f784b4c95098871714bc189",
		public string dealSourceName { get; set; }		//      "dealSourceName": "Operating Activities",
		public string lossReasonId { get; set; }		//      "lossReasonId": "00000000000000000000000000000000",
		public string value { get; set; }				//      "value": "99",
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