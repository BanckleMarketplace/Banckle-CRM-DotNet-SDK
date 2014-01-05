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
		public string parentId { get; set; }				// "parentId":		"8e56f7bea6f44388ab50c5fadeed406d",
		public string type { get; set; }					//"type":			"Office",
		public string address { get; set; }				//"address":		"waqas@testmail.com",
		public string id { get; set; }					//"id":				"f4cb2f20448a40538ae0aed9e44dc249",
		public string created { get; set; }				//"created":		"2014-01-02T05:08:55.7140000Z",
		public string updated { get; set; }				//"updated":		"2014-01-02T05:08:55.7140000Z"
	}

}