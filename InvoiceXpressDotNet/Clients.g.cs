// Connector API InvoiceXpressDotNet developed by EventKey,Lda http://www.eventkey.pt
using System;
using System.Net;
using System.ComponentModel;

namespace InvoiceXpressDotNet
{
	public static partial class InvoiceExpress
    {
		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/clients">Clients</a> module
		/// </summary>
		public static class Clients
		{

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/create">Clients Create</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static string Rest_Create(string apiKey, string accountName, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/clients.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpPost(inputData);
				if ((int) result.StatusCode != 201)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)201)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/create">Clients Create</a> Method
			/// </summary>
			public static ClientDto Create(string apiKey, string accountName, ClientDto inputData)
			{
				string xmlResult = Rest_Create(apiKey, accountName, inputData.XmlSerializeToString());
			    return xmlResult.DeserializeXml<ClientDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/get">Clients Get</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static string Rest_Get(string apiKey, string accountName, string clientId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/clients/{2}.xml?api_key={0}", apiKey, accountName, clientId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/get">Clients Get</a> Method
			/// </summary>
			public static ClientDto Get(string apiKey, string accountName, string clientId)
			{
				string xmlResult = Rest_Get(apiKey, accountName, clientId);
			    return xmlResult.DeserializeXml<ClientDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/update">Clients Update</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static string Rest_Update(string apiKey, string accountName, string clientId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/clients/{2}.xml?api_key={0}", apiKey, accountName, clientId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/update">Clients Update</a> Method
			/// </summary>
			public static void Update(string apiKey, string accountName, string clientId, ClientDto inputData)
			{
				Rest_Update(apiKey, accountName, clientId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/list">Clients List</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static string Rest_List(string apiKey, string accountName, int? page, int? perPage, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/clients.xml?api_key={0}&page={2}&per_page={3}", apiKey, accountName, page, perPage);
				var result = url.HttpGet(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/list">Clients List</a> Method
			/// </summary>
			public static void List(string apiKey, string accountName, int? page, int? perPage, ClientsDto inputData)
			{
				Rest_List(apiKey, accountName, page, perPage, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/list-invoice">Clients Invoices</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static string Rest_Invoices(string apiKey, string accountName, string clientId, int? page, int? perPage)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/clients/{2}/invoices.xml?api_key={0}&page={3}&per_page={4}", apiKey, accountName, clientId, page, perPage);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/list-invoice">Clients Invoices</a> Method
			/// </summary>
			public static InvoicesDto Invoices(string apiKey, string accountName, string clientId, int? page, int? perPage)
			{
				string xmlResult = Rest_Invoices(apiKey, accountName, clientId, page, perPage);
			    return xmlResult.DeserializeXml<InvoicesDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/find-by-name">Clients FindByName</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static string Rest_FindByName(string apiKey, string accountName, string clientName)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/clients/find-by-name.xml?api_key={0}&client_name={2}", apiKey, accountName, clientName);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/find-by-name">Clients FindByName</a> Method
			/// </summary>
			public static ClientDto FindByName(string apiKey, string accountName, string clientName)
			{
				string xmlResult = Rest_FindByName(apiKey, accountName, clientName);
			    return xmlResult.DeserializeXml<ClientDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/find-by-code">Clients FindByCode</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static string Rest_FindByCode(string apiKey, string accountName, string clientCode)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/clients/find-by-code.xml?api_key={0}&client_code={2}", apiKey, accountName, clientCode);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/find-by-code">Clients FindByCode</a> Method
			/// </summary>
			public static ClientDto FindByCode(string apiKey, string accountName, string clientCode)
			{
				string xmlResult = Rest_FindByCode(apiKey, accountName, clientCode);
			    return xmlResult.DeserializeXml<ClientDto>();
			}

	}
}
}