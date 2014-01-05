using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banckle
{
	/// <summary>
	/// 
	/// </summary>
	public class ContactDetails : BanckleCRM
	{
		public ContactDetails() { }
		public string type { get; set; }				//	"type":			"CompanyDto",
		public string tenantId { get; set; }			//	"tenantId":		"56sadfasdfssssxxeeffacccfffeeerz",
		public string userId { get; set; }				//	"userId":		"31asdfasdfdfasdfwertwerwerdfadsf",
		public string name { get; set; }				//	"name":			"Acne",		
		public string description { get; set; }			//	"description":	"Acne Corp",
		public bool isPrivate { get; set; }				//	"isPrivate":	false,
		public bool favorite { get; set; }				//	"favorite":		false,
		public string version { get; set; }				//	"version":		4,
		public string creatorId { get; set; }			//	"creatorId":	"00000000000000000000000000000000",
		public string creatorName { get; set; }			//	"creatorName":	"imranwar",
		public Email[] emails { get; set; }				//	"emails":		[],
		public Tags[] tags { get; set; }				//	"tags":			[],
		public string id { get; set; }					//	"id":			"2bsdafasdfsdfsdfasdfasdfasdfasdf",
		public string created { get; set; }				//	"created":		"2014-01-01T04:26:56.5400000Z",
		public string updated { get; set; }				//	"updated":		"2014-01-01T04:26:56.5400000Z"
	}
}