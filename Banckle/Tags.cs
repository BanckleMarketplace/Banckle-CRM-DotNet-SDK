using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banckle
{
	/// <summary>
	/// 
	/// </summary>
	public class Tags : BanckleCRM
	{
		/// <summary>
		/// 
		/// </summary>
		public string name { get; set; }				//"name":			"client",
		/// <summary>
		/// 
		/// </summary>
		public string tenantId { get; set; }			//"tenantId":		"00000000000000000000000000000000",
		/// <summary>
		/// 
		/// </summary>
		public string parentId { get; set; }			//"parentId":		"00000000000000000000000000000000",
		/// <summary>
		/// 
		/// </summary>
		public string id { get; set; }					//"id":				"b1d68de477ea442c9e4d6fe613c95d43",
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
		public Tags()
		{ 
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		public Tags(string name)
		{
		}

	}
}