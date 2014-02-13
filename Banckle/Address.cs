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

		/// <summary>
		/// 
		/// </summary>
		public string parentId { get; set; }			//    "parentId": "84bdeebab20848aaa58be174ed44da00",
		/// <summary>
		/// 
		/// </summary>
		public string type { get; set; }				//    "type": "Home",
		/// <summary>
		/// 
		/// </summary>
		public string building { get; set; }			//    "building": "",
		/// <summary>
		/// 
		/// </summary>
		public string street { get; set; }				//    "street": "fsd colony",
		/// <summary>
		/// 
		/// </summary>
		public string city { get; set; }				//    "city": "fsd",
		/// <summary>
		/// 
		/// </summary>
		public string zip { get; set; }					//    "zip": "38000",
		/// <summary>
		/// 
		/// </summary>
		public string country { get; set; }				//    "country": "Pakistan",
		/// <summary>
		/// 
		/// </summary>
		public string state { get; set; }				//    "state": "punjab",
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
		public Address()
		{
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="type"></param>
		/// <param name="building"></param>
		/// <param name="street"></param>
		/// <param name="city"></param>
		/// <param name="zip"></param>
		/// <param name="state"></param>
		/// <param name="country"></param>
		public Address(string type, string building, string street, string city, string zip, string state, string country)
		{
			this.type = type;
			this.building = building;
			this.street = street;
			this.city = city;
			this.zip = zip;
			this.state = state;
			this.country = country;
		}

	}
}