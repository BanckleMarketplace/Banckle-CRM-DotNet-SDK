using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banckle
{
	/// <summary>
	/// Company Details of the Contacts
	/// </summary>
	public class Company : BanckleCRM
	{
		public string industry { get; set; }				// "industry": "comp science",
		public Employee[] employees { get; set; }		//  "employees": [],
		public string established { get; set; }			//    "established": "2014-01-05T06:17:22.3030000Z",
		public CustomField[] customFields { get; set; }	//  "customFields": [],
		public Phone[] phone { get; set; }				//  "phones": [],
		public Address[] address { get; set; }			//  "addresses": [],
		public Website[] websites { get; set; }		//  "websites": [],
		public Note[] notes { get; set; }				//  "notes": [],
		public Social[] socials { get; set; }			//  "socials": [],
		public Deal[] deals { get; set; }				//  "deals": [],
		public Task[] tasks { get; set; }				//  "tasks": [],
		public AssociatedFile associatedFiles { get; set; }//  "associatedFiles": {},
		public string type { get; set; }				//  "type": "CompanyFullDto",
		public string tenantId { get; set; }			//      "tenantId": "56dc07c434c94bc094f96d93f0c20342",
		public string userId { get; set; }				//      "userId": "31dc674c93e045afaac319a5c8413506",
		public string name { get; set; }				//      "name": "Imran Anwar",
		public string description { get; set; }			//      "description": "imran anwar as IT",
		public bool isPrivate { get; set; }				//    "isPrivate": false,
		public bool favorite { get; set; }				//    "favorite": false,
		public string version { get; set; }				//      "version": 4,
		public string creatorId { get; set; }			//      "creatorId": "56dc07c434c94bc094f96d93f0c20342",
		public string creatorName { get; set; }			//      "creatorName": "imranwar",
		public Email[] emails { get; set; }				//      "emails": [],
		public Tags[] tags { get; set; }				//      "tags": [],
		public string id { get; set; }					//    "id": "4685bff4f3994a30b385a3493f3c392c",
		public string created { get; set; }				//    "created": "2014-01-05T06:17:22.3030000Z",
		public string updated { get; set; }				//    "updated": "2014-01-05T06:17:22.3030000Z"

		public Company(string companyId)
		{
			this.id = companyId;
		}


	}
}