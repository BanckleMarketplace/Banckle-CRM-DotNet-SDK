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
		/// <summary>
		/// 
		/// </summary>
		public string industry { get; set; }				// "industry": "comp science",
		/// <summary>
		/// 
		/// </summary>
		public Employee[] employees { get; set; }		//  "employees": [],
		/// <summary>
		/// 
		/// </summary>
		public string established { get; set; }			//    "established": "2014-01-05T06:17:22.3030000Z",
		/// <summary>
		/// 
		/// </summary>
		public CustomField[] customFields { get; set; }	//  "customFields": [],
		/// <summary>
		/// 
		/// </summary>
		public Phone[] phones { get; set; }				//  "phones": [],
		/// <summary>
		/// 
		/// </summary>
		public Address[] addresses { get; set; }			//  "addresses": [],
		/// <summary>
		/// 
		/// </summary>
		public Website[] websites { get; set; }		//  "websites": [],
		/// <summary>
		/// 
		/// </summary>
		public Note[] notes { get; set; }				//  "notes": [],
		/// <summary>
		/// 
		/// </summary>
		public Social[] socials { get; set; }			//  "socials": [],
		/// <summary>
		/// 
		/// </summary>
		public Deal[] deals { get; set; }				//  "deals": [],
		/// <summary>
		/// 
		/// </summary>
		public Task[] tasks { get; set; }				//  "tasks": [],
		/// <summary>
		/// 
		/// </summary>
		public AssociatedFile associatedFiles { get; set; }//  "associatedFiles": {},
		/// <summary>
		/// 
		/// </summary>
		public string type { get; set; }				//  "type": "CompanyFullDto",
		/// <summary>
		/// 
		/// </summary>
		public string tenantId { get; set; }			//      "tenantId": "56dc07c434c94bc094f96d93f0c20342",
		/// <summary>
		/// 
		/// </summary>
		public string userId { get; set; }				//      "userId": "31dc674c93e045afaac319a5c8413506",
		/// <summary>
		/// 
		/// </summary>
		public string name { get; set; }				//      "name": "Imran Anwar",
		/// <summary>
		/// 
		/// </summary>
		public string description { get; set; }			//      "description": "imran anwar as IT",
		/// <summary>
		/// 
		/// </summary>
		public bool isPrivate { get; set; }				//    "isPrivate": false,
		/// <summary>
		/// 
		/// </summary>
		public bool favorite { get; set; }				//    "favorite": false,
		/// <summary>
		/// 
		/// </summary>
		public string version { get; set; }				//      "version": 4,
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
		public Email[] emails { get; set; }				//      "emails": [],
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
		/// <summary>
		/// 
		/// </summary>
		/// <param name="companyId"></param>
		public Company(string companyId)
		{
			this.id = companyId;
		}


	}
}