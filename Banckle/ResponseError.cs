using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banckle
{
	/// <summary>
	/// 
	/// </summary>
	public class ResponseError
	{
		//ErrorCode (string, optional),
		/// <summary>
		/// 
		/// </summary>
		string ErrorCode { get; set; }
		//FieldName (string, optional),
		/// <summary>
		/// 
		/// </summary>
		string FieldName { get; set; }
		//Message (string, optional)
		/// <summary>
		/// 
		/// </summary>
		string Message { get; set; }
	}
}
