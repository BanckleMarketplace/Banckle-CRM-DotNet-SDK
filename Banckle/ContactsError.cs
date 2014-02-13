using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banckle
{
	/// <summary>
	/// 
	/// </summary>
	public class ContactsError : BanckleCRM
	{
		/// <summary>
		/// 
		/// </summary>
		public string message { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string errorCode { get; set; }
	}
}