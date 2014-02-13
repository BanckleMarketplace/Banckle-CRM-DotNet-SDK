using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banckle
{
	/// <summary>
	/// Notes about the contact
	/// </summary>
	public class Note : BanckleCRM
	{
		/// <summary>
		/// 
		/// </summary>
		public string parentId { get; set; }			//    "parentId": "84bdeebab20848aaa58be174ed44da00",
		/// <summary>
		/// 
		/// </summary>
		public string content { get; set; }				//    "content": "This is a note  to test this feature ",
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
		public Note()
		{
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="content"></param>
		public Note(string content)
		{
			this.content = content;
		}
	}
}