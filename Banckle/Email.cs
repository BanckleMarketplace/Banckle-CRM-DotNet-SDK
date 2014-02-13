using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banckle
{
	/// <summary>
	/// 
	/// </summary>
	public class Email : BanckleCRM
	{
		/// <summary>
		/// 
		/// </summary>
		public string parentId { get; set; }				// "parentId":		"8e56f7bea6f44388ab50c5fadeed406d",
		/// <summary>
		/// 
		/// </summary>
		public string type { get; set; }					//"type":			"Office",
		/// <summary>
		/// 
		/// </summary>
		public string address { get; set; }				//"address":		"waqas@testmail.com",
		/// <summary>
		/// 
		/// </summary>
		public string id { get; set; }					//"id":				"f4cb2f20448a40538ae0aed9e44dc249",
		/// <summary>
		/// 
		/// </summary>
		public string created { get; set; }				//"created":		"2014-01-02T05:08:55.7140000Z",
		/// <summary>
		/// 
		/// </summary>
		public string updated { get; set; }				//"updated":		"2014-01-02T05:08:55.7140000Z"

		/// <summary>
		/// 
		/// </summary>
		/// <param name="type"></param>
		/// <param name="address"></param>
		public Email(string type, string address)
		{
			this.type = type;
			this.address = address;
		}

		/// <summary>
		/// 
		/// </summary>
		public Email()
		{
		}
	}

}