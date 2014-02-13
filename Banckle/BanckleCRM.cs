using System;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace Banckle
{
	/// <summary>
	/// Banckle CRM Main Class
	/// </summary>
	public class BanckleCRM
	{
		/// <summary>
		/// Banckle CRM API URL
		/// </summary>
		/// 
		protected String banckleCRMAPIUrl = "https://crm-api.banckle.com/v1.0/";
		/// <summary>
		/// BanckleCRM API Key
		/// </summary>
		protected string banckleCRMAPIKey = "";

		/// <summary>
		/// BanckleCRM constructor
		/// </summary>
		public BanckleCRM()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		/// <summary>
		/// Banckle Get Request.
		/// </summary>
		/// <param name="URL">API call URL</param>
		/// <param name="APIKey">API Key for the URL</param>
		/// <returns>Returns a String containing the JSON response</returns>
		public string banckleRequest(string URL, string APIKey)
		{
			string responseFromServer;
			this.banckleCRMAPIKey = APIKey;
			try
			{
				// Create a request for the URL. 		
				// https://crm-api.banckle.com/v1.0/contacts?api_key=
				WebRequest request = WebRequest.Create(URL+"&api_key="+ HttpUtility.UrlEncode(APIKey));
				// If required by the server, set the credentials.
				request.Credentials = CredentialCache.DefaultCredentials;
				// Get the response.
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();

				// Display the status.
				Console.WriteLine(response.StatusDescription);
				// Get the stream containing content returned by the server.
				Stream dataStream = response.GetResponseStream();
				// Open the stream using a StreamReader for easy access.
				StreamReader reader = new StreamReader(dataStream);
				// Read the content.
				responseFromServer = reader.ReadToEnd();
				responseFromServer.Replace("return", "returnValue");
				// Cleanup the streams and the response.
				reader.Close();
				dataStream.Close();
				response.Close();
				//JavaScriptSerializer jss = JavaScriptSerializer();
				//Mapview

			}
			catch (Exception ex)
			{
				return ex.Message + "\r" + ex.StackTrace;
			}
			return responseFromServer;

		}

		/// <summary>
		/// Banckle Post Request
		/// </summary>
		/// <param name="URL">API call URL</param>
		/// <param name="APIKey">API Key for the URL</param>
		/// <param name="DATA">A JSON formated string</param>
		/// <returns>Returns a String containing the JSON response</returns>
		public string bancklePOSTRequest(string URL, string APIKey, string DATA)
		{

			string responseFromServer;
			this.banckleCRMAPIKey = APIKey;
			try
			{
				// Create a request for the URL. 		
				// https://crm-api.banckle.com/v1.0/contacts?api_key=
				WebRequest request = WebRequest.Create(URL + "&api_key=" + HttpUtility.UrlEncode(APIKey));

				request.Method = "POST";
				request.ContentType = "application/json";
				// Create a byte array of the data we want to send  
				byte[] byteData = UTF8Encoding.UTF8.GetBytes(DATA);  
				request.ContentLength = DATA.Length;
				StreamWriter requestWriter = new StreamWriter(request.GetRequestStream());
				requestWriter.Write(DATA);
				requestWriter.Close();


				// If required by the server, set the credentials.
				request.Credentials = CredentialCache.DefaultCredentials;
				// Get the response.
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();

				// Display the status.
				Console.WriteLine(response.StatusDescription);
				// Get the stream containing content returned by the server.
				Stream dataStream = response.GetResponseStream();
				// Open the stream using a StreamReader for easy access.
				StreamReader reader = new StreamReader(dataStream);
				// Read the content.
				responseFromServer = reader.ReadToEnd();
				responseFromServer.Replace("return", "returnValue");
				// Cleanup the streams and the response.
				reader.Close();
				dataStream.Close();
				response.Close();
				//JavaScriptSerializer jss = JavaScriptSerializer();
				//Mapview

			}
			catch (Exception ex)
			{
				return ex.Message + "\r" + ex.StackTrace;
			}
			return responseFromServer;
		}

		/// <summary>
		/// Banckle Put Request Method
		/// </summary>
		/// <param name="URL">API call URL</param>
		/// <param name="APIKey">API Key for the URL</param>
		/// <param name="DATA">A JSON formated string</param>
		/// <returns>Returns a String containing the JSON response</returns>
		public string bancklePUTRequest(string URL, string APIKey, string DATA)
		{

			string responseFromServer;
			this.banckleCRMAPIKey = APIKey;
			try
			{
				// Create a request for the URL. 		
				// https://crm-api.banckle.com/v1.0/contacts?api_key=
				WebRequest request = WebRequest.Create(URL + "&api_key=" + HttpUtility.UrlEncode(APIKey));

				request.Method = "PUT";
				request.ContentType = "application/json";
				// Create a byte array of the data we want to send  
				byte[] byteData = UTF8Encoding.UTF8.GetBytes(DATA);  
				request.ContentLength = DATA.Length;
				StreamWriter requestWriter = new StreamWriter(request.GetRequestStream());
				requestWriter.Write(DATA);
				requestWriter.Close();


				// If required by the server, set the credentials.
				request.Credentials = CredentialCache.DefaultCredentials;
				// Get the response.
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();

				// Display the status.
				Console.WriteLine(response.StatusDescription);
				// Get the stream containing content returned by the server.
				Stream dataStream = response.GetResponseStream();
				// Open the stream using a StreamReader for easy access.
				StreamReader reader = new StreamReader(dataStream);
				// Read the content.
				responseFromServer = reader.ReadToEnd();
				responseFromServer.Replace("return", "returnValue");
				// Cleanup the streams and the response.
				reader.Close();
				dataStream.Close();
				response.Close();
				//JavaScriptSerializer jss = JavaScriptSerializer();
				//Mapview

			}
			catch (Exception ex)
			{
				return ex.Message + "\r" + ex.StackTrace;
			}
			return responseFromServer;
		}

		/// <summary>
		/// Banckle Delete Request
		/// </summary>
		/// <param name="URL">API call URL</param>
		/// <param name="APIKey">API Key for the URL</param>
		/// <returns>Returns a String containing the JSON response</returns>
		public string banckleDELETERequest(string URL, string APIKey)
		{

			string responseFromServer;
			this.banckleCRMAPIKey = APIKey;
			try
			{
				// Create a request for the URL. 		
				// https://crm-api.banckle.com/v1.0/contacts?api_key=
				WebRequest request = WebRequest.Create(URL + "&api_key=" + HttpUtility.UrlEncode(APIKey));

				request.Method = "DELETE";
				request.ContentType = "application/json";
				// If required by the server, set the credentials.
				request.Credentials = CredentialCache.DefaultCredentials;
				// Get the response.
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();

				// Display the status.
				Console.WriteLine("From banckleDELETERequest:" + response.StatusDescription);
				// Get the stream containing content returned by the server.
				Stream dataStream = response.GetResponseStream();
				// Open the stream using a StreamReader for easy access.
				StreamReader reader = new StreamReader(dataStream);
				// Read the content.
				responseFromServer = reader.ReadToEnd();
				responseFromServer.Replace("return", "returnValue");
				// Cleanup the streams and the response.
				reader.Close();
				dataStream.Close();
				response.Close();
				//JavaScriptSerializer jss = JavaScriptSerializer();
				//Mapview

			}
			catch (Exception ex)
			{
				return ex.Message + "\r" + ex.StackTrace;
			}
			return responseFromServer;
		}

	}
}