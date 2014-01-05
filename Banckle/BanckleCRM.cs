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
	public class BanckleCRM
	{
		protected String banckleCRMAPIUrl = "https://crm-api.banckle.com/api/";
		protected string banckleCRMAPIKey = "";

		public BanckleCRM()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="URL"></param>
		/// <param name="APIKey"></param>
		/// <param name="method"></param>
		/// <returns></returns>
		public string banckleRequest(string URL, string APIKey)
		{
			string responseFromServer;
			this.banckleCRMAPIKey = APIKey;
			try
			{
				// Create a request for the URL. 		
				// https://crm-api.banckle.com/api/contacts?api_key=
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
				return ex.Message;
			}
			return responseFromServer;

		}


		public string bancklePOSTRequest(string URL, string APIKey, string DATA)
		{

			string responseFromServer;
			this.banckleCRMAPIKey = APIKey;
			try
			{
				// Create a request for the URL. 		
				// https://crm-api.banckle.com/api/contacts?api_key=
				WebRequest request = WebRequest.Create(URL + "&api_key=" + HttpUtility.UrlEncode(APIKey));

				request.Method = "POST";
				request.ContentType = "application/json";
				request.ContentLength = DATA.Length;
				StreamWriter requestWriter = new StreamWriter(request.GetRequestStream(), System.Text.Encoding.ASCII);
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
				return ex.Message;
			}
			return responseFromServer;
		}

		public string bancklePUTRequest(string URL, string APIKey, string DATA)
		{

			string responseFromServer;
			this.banckleCRMAPIKey = APIKey;
			try
			{
				// Create a request for the URL. 		
				// https://crm-api.banckle.com/api/contacts?api_key=
				WebRequest request = WebRequest.Create(URL + "&api_key=" + HttpUtility.UrlEncode(APIKey));

				request.Method = "PUT";
				request.ContentType = "application/json";
				request.ContentLength = DATA.Length;
				StreamWriter requestWriter = new StreamWriter(request.GetRequestStream(), System.Text.Encoding.ASCII);
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
				return ex.Message;
			}
			return responseFromServer;
		}

		public string banckleDELETERequest(string URL, string APIKey)
		{

			string responseFromServer;
			this.banckleCRMAPIKey = APIKey;
			try
			{
				// Create a request for the URL. 		
				// https://crm-api.banckle.com/api/contacts?api_key=
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
				return ex.Message;
			}
			return responseFromServer;
		}

	}
}