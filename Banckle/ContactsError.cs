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
		public string message { get; set; }
		public string errorCode { get; set; }
	}
}