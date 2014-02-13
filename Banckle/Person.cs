using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banckle
{
	/// <summary>
	/// 
	/// </summary>
	public class Person : BanckleCRM
	{
		/// <summary>
		/// 
		/// </summary>
		public string companyId { get; set; }				//      "companyId": "84bdeebab20848aaa58be174ed44da00",
		//public string companyName { get; set; }			//      "companyName": "imrans",
		/// <summary>
		/// 
		/// </summary>
		public string title { get; set; }					//      "title": "Mr",
		/// <summary>
		/// 
		/// </summary>
		public string role { get; set; }					//      "role": "IT",
		/// <summary>
		/// 
		/// </summary>
		public string lastName { get; set; }				//      "lastName": "Anwar",
		/// <summary>
		/// 
		/// </summary>
		public string firstName { get; set; }				//      "firstName": "Imran",
		/// <summary>
		/// 
		/// </summary>
		public string birthDay { get; set; }				//      "birthDay": "2014-01-02T00:00:00.0000000Z",
		/// <summary>
		/// 
		/// </summary>
		public CustomField[] customFields { get; set; }		//     "customFields": [],
		/// <summary>
		/// 
		/// </summary>
		public Phone[] phones { get; set; }								//     "phones": [],
		/// <summary>
		/// 
		/// </summary>
		public Address[] addresses { get; set; }							//     "addresses": [],
		/// <summary>
		/// 
		/// </summary>
		public Website[] websites { get; set; }				//     "websites": [],
		/// <summary>
		/// 
		/// </summary>
		public Note[] notes { get; set; }					//     "notes": [],
		/// <summary>
		/// 
		/// </summary>
		public Social[] socials { get; set; }				//     "socials": [],
		/// <summary>
		/// 
		/// </summary>
		public Deal[] deals { get; set; }					//     "deals": [],
		/// <summary>
		/// 
		/// </summary>
		public Task[] tasks { get; set; }					//     "tasks": [],
		/// <summary>
		/// 
		/// </summary>
		public AssociatedFile associatedFiles { get; set; }	//     "associatedFiles": {},
		/// <summary>
		/// 
		/// </summary>
		public string skypeId { get; set; }					//      "skypeId": "dashing",
		/// <summary>
		/// 
		/// </summary>
		public string type { get; set; }					//      "type": "PersonDto",
		/// <summary>
		/// 
		/// </summary>
		public string tenantId { get; set; }				//      "tenantId": "56dc07c434c94bc094f96d93f0c20342",
		/// <summary>
		/// 
		/// </summary>
		public string userId { get; set; }					//      "userId": "31dc674c93e045afaac319a5c8413506",
		/// <summary>
		/// 
		/// </summary>
		public string name { get; set; }					//      "name": "Imran Anwar",
		/// <summary>
		/// 
		/// </summary>
		public string description { get; set; }				//      "description": "imran anwar as IT",
		/// <summary>
		/// 
		/// </summary>
		public bool isPrivate { get; set; }					//      "isPrivate": false,
		/// <summary>
		/// 
		/// </summary>
		public bool favorite { get; set; }					//      "favorite": false,
		/// <summary>
		/// 
		/// </summary>
		public string version { get; set; }					//      "version": 4,
		/// <summary>
		/// 
		/// </summary>
		public string creatorId { get; set; }				//      "creatorId": "00000000000000000000000000000000",
		/// <summary>
		/// 
		/// </summary>
		public string creatorName { get; set; }				//      "creatorName": "  imranwar",
		/// <summary>
		/// 
		/// </summary>
		public Email[] emails { get; set; }								//      "emails": [],
		/// <summary>
		/// 
		/// </summary>
		public Tags[] tags { get; set; }					//      "tags": [],
		/// <summary>
		/// 
		/// </summary>
		public string id { get; set; }						//      "id": "5221049114214c0dab27068e22f4ad76",
		/// <summary>
		/// 
		/// </summary>
		public string created { get; set; }					//      "created": "2014-01-05T06:16:17.2040000Z",
		/// <summary>
		/// 
		/// </summary>
		public string updated { get; set; }					//      "updated": "2014-01-05T06:16:17.2040000Z"
		/// <summary>
		/// 
		/// </summary>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		public Person(string firstName, string lastName)
		{
			this.firstName = firstName;
			this.lastName = lastName;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="personId"></param>
		public Person(string personId)
		{
			this.id = personId;
		}
		/// <summary>
		/// 
		/// </summary>
		public Person()
		{
		}
	}
}