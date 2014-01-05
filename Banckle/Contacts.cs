using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;


///
namespace Banckle
{
	/// <summary>
	/// Contacts Class
	/// </summary>
	/// 
	public class Contacts : BanckleCRM
	{
		public string json = "";
		//public CONTACTSRESULT contactsResult { get; set; }
		public string APIKey;
		public Contacts(){}

		/// <summary>
		/// Gets all the Contacts.
		/// </summary>
		/// <returns>A List of objects of ContactDetails Class</returns>
		public List<ContactDetails> GetContacts()
		{
			JavaScriptSerializer serializer = new JavaScriptSerializer();
			// Deserialize
			json = banckleRequest("https://crm-api.banckle.com/api/contacts"+ "?format=json",APIKey);

			//var deserializedResult = serializer.Deserialize<List<Person>>(serializedResult);
			List<ContactDetails> contactDetails = serializer.Deserialize<List<ContactDetails>>(json);
			return contactDetails;
		}


		/// <summary>
		/// Gets a contact from the specified id.
		/// </summary>
		/// <param name="id">Id of the Contact</param>
		/// <returns>An object of ContactDetails class</returns>
		public ContactDetails GetContactById(string id)
		{
			JavaScriptSerializer serializer = new JavaScriptSerializer();
			// Deserialize
			json = banckleRequest("https://crm-api.banckle.com/api/contacts/"+ id + "?format=json", APIKey);

			//var deserializedResult = serializer.Deserialize<List<Person>>(serializedResult);
			ContactDetails contactDetails = serializer.Deserialize<ContactDetails>(json);
			return contactDetails;
		}

		/// <summary>
		/// Delete's a contact by id.
		/// </summary>
		/// <param name="id">Id of the Contact</param>
		/// <returns>An object of ContactDetails class</returns>
		public string DeleteContactById(string id)
		{
			JavaScriptSerializer serializer = new JavaScriptSerializer();
			// Deserialize
			//json = banckleDELETERequest("https://crm-api.banckle.com/api/contacts/" + id + "?format=json", APIKey);
			json = banckleDELETERequest("https://crm-api.banckle.com/api/contacts/" + id + "?format=json", APIKey);
									//   https://crm-api.banckle.com/api/contacts/aadab26ea6654ba49c999872?api_key=
			return json;
		}

		/// <summary>
		/// Get's a contact by Name.
		/// </summary>
		/// <param name="name">Name of the Contact</param>
		/// <returns>An object of ContactDetails class</returns>
		public ContactDetails GetContactByName(string name)
		{
			JavaScriptSerializer serializer = new JavaScriptSerializer();
			// Deserialize
			json = banckleRequest("https://crm-api.banckle.com/api/contacts/byname/" + name + "?format=json", APIKey);

			//var deserializedResult = serializer.Deserialize<List<Person>>(serializedResult);
			ContactDetails contactDetails = serializer.Deserialize<ContactDetails>(json);
			return contactDetails;

		}

		/// <summary>
		/// Creates a Contact for a Company
		/// </summary>
		/// <param name="name">Name of the Company</param>
		/// <param name="description">Description of the Company</param>
		/// <param name="industry">Industry whome this Company belongs to</param>
		/// <param name="established">Establishment date</param>
		/// <returns>string: Id of the company</returns>
		public string CreateCompany(string name, string description, string industry, string established)
		{
			JavaScriptSerializer serializer = new JavaScriptSerializer();
			// Deserialize
			string DATA = "{\"name\":\"" + name + "\",\"description\":\"" + description + "\", \"industry\":\"" + industry + "\",\"established\":\"" + established + "\"}";

			json = bancklePOSTRequest("https://crm-api.banckle.com/api/contacts/company" + "?format=json", APIKey, DATA);

			//var deserializedResult = serializer.Deserialize<List<Person>>(serializedResult);
			//ContactDetails contactDetails = serializer.Deserialize<ContactDetails>(json);
			return json;

		}


		/// <summary>
		/// Gets the Compay Details from Comany Name.
		/// </summary>
		/// <param name="name">Name of the Company</param>
		/// <returns>Object of type CompayDetails</returns>
		public Company GetCompanyByName(string name)
		{
			JavaScriptSerializer serializer = new JavaScriptSerializer();
			// Deserialize
			json = banckleRequest("https://crm-api.banckle.com/api/contacts/company/" + name + "?format=json", APIKey);

			//var deserializedResult = serializer.Deserialize<List<Person>>(serializedResult);
			Company companyDetails = serializer.Deserialize<Company>(json);
			return companyDetails;
		}

		/// <summary>
		/// Gets the Compay Details from Comany Name.
		/// </summary>
		/// <param name="name">Name of the Company</param>
		/// <returns>Object of type CompayDetails</returns>
		public List<Employee> GetEmployeesByCompanyName(string name)
		{
			JavaScriptSerializer serializer = new JavaScriptSerializer();
			// Deserialize
			json = banckleRequest("https://crm-api.banckle.com/api/contacts/company/" + name + "/employees" + "?format=json", APIKey);

			//var deserializedResult = serializer.Deserialize<List<Person>>(serializedResult);
			List<Employee> employees = serializer.Deserialize<List<Employee>>(json);
			return employees;
		}

		/// <summary>
		/// Gets an Object of Employee and creates an Employee.
		/// </summary>
		/// <param name="employee">Object of the Employee class</param>
		/// <returns></returns>
		public string CreateEmpolyee(Employee employee)
		{
			JavaScriptSerializer serializer = new JavaScriptSerializer();
			// Deserialize
			string DATA = serializer.Serialize(employee);

			json = bancklePOSTRequest("https://crm-api.banckle.com/api/contacts/company/" + employee.companyName + "/employees" + "?format=json", APIKey, DATA);

			//var deserializedResult = serializer.Deserialize<List<Person>>(serializedResult);
			//ContactDetails contactDetails = serializer.Deserialize<ContactDetails>(json);
			return json;

		}

		/// <summary>
		/// Updates the specified Company
		/// </summary>
		/// <param name="company">Object of the Company class</param>
		/// <returns></returns>
		public string UpdateCompany(Company company)
		{
			JavaScriptSerializer serializer = new JavaScriptSerializer();
			// Deserialize
			string DATA = serializer.Serialize(company);

			json = bancklePUTRequest("https://crm-api.banckle.com/api/contacts/company/" + company.id + "?format=json", APIKey, DATA);

			//var deserializedResult = serializer.Deserialize<List<Person>>(serializedResult);
			//ContactDetails contactDetails = serializer.Deserialize<ContactDetails>(json);
			return json;

		}

		/// <summary>
		/// Creates a persone
		/// </summary>
		/// <param name="person">Object of the Person class</param>
		/// <returns>String Id...</returns>
		public string CreatePerson(Person person)
		{
			JavaScriptSerializer serializer = new JavaScriptSerializer();
			// Deserialize
			string DATA = serializer.Serialize(person);

			json = bancklePOSTRequest("https://crm-api.banckle.com/api/contacts/person/" + "?format=json", APIKey, DATA);

			//var deserializedResult = serializer.Deserialize<List<Person>>(serializedResult);
			//ContactDetails contactDetails = serializer.Deserialize<ContactDetails>(json);
			return json;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="person"></param>
		/// <returns></returns>
		public string UpdatePerson(Person person)
		{
			JavaScriptSerializer serializer = new JavaScriptSerializer();
			// Deserialize
			string DATA = serializer.Serialize(person);

			json = bancklePUTRequest("https://crm-api.banckle.com/api/contacts/person/" + person.id + "?format=json", APIKey, DATA);

			//var deserializedResult = serializer.Deserialize<List<Person>>(serializedResult);
			//ContactDetails contactDetails = serializer.Deserialize<ContactDetails>(json);
			return json;

		}

		/// <summary>
		/// Get Person details by a specific Name.
		/// </summary>
		/// <param name="name">Name of the person</param>
		/// <returns>Object of the type Person</returns>
		public Person GetPersonByName(string name)
		{
			JavaScriptSerializer serializer = new JavaScriptSerializer();
			// Deserialize
			json = banckleRequest("https://crm-api.banckle.com/api/contacts/person/" + name + "?format=json", APIKey);

			//var deserializedResult = serializer.Deserialize<List<Person>>(serializedResult);
			Person person = serializer.Deserialize<Person>(json);
			return person;
		}

		/// <summary>
		/// Get Colleagues by Person Name.
		/// </summary>
		/// <param name="name">Name of the person</param>
		/// <returns>List of Colleague</returns>
		public List<Colleague> GetColleaguesByPersonName(string name)
		{
			JavaScriptSerializer serializer = new JavaScriptSerializer();
			// Deserialize
			json = banckleRequest("https://crm-api.banckle.com/api/contacts/person/" + name + "/colleagues" + "?format=json", APIKey);

			//var deserializedResult = serializer.Deserialize<List<Person>>(serializedResult);
			List<Colleague> colleague = serializer.Deserialize<List<Colleague>>(json);
			return colleague;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="colleague"></param>
		/// <returns></returns>
		public string CreateColleague(Colleague colleague)
		{
			JavaScriptSerializer serializer = new JavaScriptSerializer();
			// Deserialize
			string DATA = serializer.Serialize(colleague);

			json = bancklePOSTRequest("https://crm-api.banckle.com/api/contacts/person/" + colleague.name + "/colleagues" + "?format=json", APIKey, DATA);

			//var deserializedResult = serializer.Deserialize<List<Person>>(serializedResult);
			//ContactDetails contactDetails = serializer.Deserialize<ContactDetails>(json);
			return json;

		}


	}

}