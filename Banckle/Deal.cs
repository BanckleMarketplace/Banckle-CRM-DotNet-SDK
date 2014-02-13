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
		/// <summary>
		/// 
		/// </summary>
		public string version { get; set; }				//      "version": 4,
		/// <summary>
		/// 
		/// </summary>
		public bool isHot { get; set; }					//		"isHot": false,
		/// <summary>
		/// 
		/// </summary>
		public string name { get; set; }				//      "name": "New Plan",
		/// <summary>
		/// 
		/// </summary>
		public ContactDetails[] contacts { get; set; }	//      "contacts": [],
		/// <summary>
		/// 
		/// </summary>
		public string stageId { get; set; }				//      "stageId": "84bdeebab20848aaa58be174ed44da00",
		/// <summary>
		/// 
		/// </summary>
		public string stageName { get; set; }			//      "stageName": "Incoming",
		/// <summary>
		/// 
		/// </summary>
		public string stageDate { get; set; }			//      "stageDate": "2014-01-05T07:48:37.6220000Z",
		/// <summary>
		/// 
		/// </summary>
		public string dealSourceId { get; set; }		//      "dealSourceId": "a87d3a0d6f784b4c95098871714bc189",
		/// <summary>
		/// 
		/// </summary>
		public string dealSourceName { get; set; }		//      "dealSourceName": "Operating Activities",
		/// <summary>
		/// 
		/// </summary>
		public string lossReasonId { get; set; }		//      "lossReasonId": "00000000000000000000000000000000",
		/// <summary>
		/// 
		/// </summary>
		public string value { get; set; }				//      "value": "99",
		/// <summary>
		/// 
		/// </summary>
		public string creatorId { get; set; }			//      "creatorId": "56dc07c434c94bc094f96d93f0c20342",
		/// <summary>
		/// 
		/// </summary>
		public string creatorName { get; set; }			//      "creatorName": "imranwar",
		/// <summary>
		/// 
		/// </summary>
		public string assigneeId { get; set; }			//      "assigneeId": "31dc674c93e045afaac319a5c8413506",
		/// <summary>
		/// 
		/// </summary>
		public string assigneeName { get; set; }		//      "assigneeName": "imranwar",
		/// <summary>
		/// 
		/// </summary>
		public Tags[] tags { get; set; }				//      "tags": [],
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
	}
}