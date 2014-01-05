using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Banckle
{
	/// <summary>
	/// 
	/// </summary>
	public class Colleague : BanckleCRM
	{
		public string companyId { get; set; }				//      "companyId": "84bdeebab20848aaa58be174ed44da00",
		public string companyName { get; set; }			//      "companyName": "imrans",
		public string title { get; set; }				//      "title": "Mr",
		public string role { get; set; }					//      "role": "IT",
		public string lastName { get; set; }				//      "lastName": "Anwar",
		public string firstName { get; set; }				//      "firstName": "Imran",
		public string birthDay { get; set; }				//      "birthDay": "2014-01-02T00:00:00.0000000Z",
		public string skypeId { get; set; }				//      "skypeId": "dashing",
		public string type { get; set; }					//      "type": "PersonDto",
		public string tenantId { get; set; }				//      "tenantId": "56dc07c434c94bc094f96d93f0c20342",
		public string userId { get; set; }				//      "userId": "31dc674c93e045afaac319a5c8413506",
		public string name { get; set; }					//      "name": "Imran Anwar",
		public string description { get; set; }			//      "description": "imran anwar as IT",
		public bool isPrivate { get; set; }				//      "isPrivate": false,
		public bool favorite { get; set; }				//      "favorite": false,
		public string version { get; set; }				//      "version": 4,
		public string creatorId { get; set; }				//      "creatorId": "00000000000000000000000000000000",
		public string creatorName { get; set; }			//      "creatorName": "  imranwar",
		public Email[] emails { get; set; }				//      "emails": [],
		public Tags[] tags { get; set; }					//      "tags": [],
		public string id { get; set; }					//      "id": "5221049114214c0dab27068e22f4ad76",
		public string created { get; set; }				//      "created": "2014-01-05T06:16:17.2040000Z",
		public string updated { get; set; }				//      "updated": "2014-01-05T06:16:17.2040000Z"

		public Colleague(string personName)
		{
			this.name = personName;
		}
		public Colleague()
		{
		}

	}
}