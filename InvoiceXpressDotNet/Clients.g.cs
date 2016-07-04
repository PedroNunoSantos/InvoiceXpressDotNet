// Connector API InvoiceXpressDotNet developed by EventKey,Lda http://www.eventkey.pt
using System;
using System.Net;
namespace InvoiceXpressDotNet
{
	public static partial class InvoiceExpress
    {
		public static class Clients
		{

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/create">Clients Create</a> Method
			/// </summary>
			public static string Create(string apiKey, string accountName, string inputData)
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
			public static ClientDto CreateTyped(string apiKey, string accountName, ClientDto inputData)
			{
				return Create(apiKey, accountName, inputData.XmlSerializeToString()).DeserializeXml<ClientDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/get">Clients Get</a> Method
			/// </summary>
			public static string Get(string apiKey, string accountName, string clientId)
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
			public static ClientDto GetTyped(string apiKey, string accountName, string clientId)
			{
				return Get(apiKey, accountName, clientId).DeserializeXml<ClientDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/update">Clients Update</a> Method
			/// </summary>
			public static string Update(string apiKey, string accountName, string clientId, string inputData)
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
			public static void UpdateTyped(string apiKey, string accountName, string clientId, ClientDto inputData)
			{
				Update(apiKey, accountName, clientId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/list">Clients List</a> Method
			/// </summary>
			public static string List(string apiKey, string accountName, int? page, int? perPage, string inputData)
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
			public static void ListTyped(string apiKey, string accountName, int? page, int? perPage, ClientsDto inputData)
			{
				List(apiKey, accountName, page, perPage, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/list-invoice">Clients Invoices</a> Method
			/// </summary>
			public static string Invoices(string apiKey, string accountName, string clientId, int? page, int? perPage)
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
			public static InvoicesDto InvoicesTyped(string apiKey, string accountName, string clientId, int? page, int? perPage)
			{
				return Invoices(apiKey, accountName, clientId, page, perPage).DeserializeXml<InvoicesDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/find-by-name">Clients FindByName</a> Method
			/// </summary>
			public static string FindByName(string apiKey, string accountName, string clientName)
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
			public static ClientDto FindByNameTyped(string apiKey, string accountName, string clientName)
			{
				return FindByName(apiKey, accountName, clientName).DeserializeXml<ClientDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/find-by-code">Clients FindByCode</a> Method
			/// </summary>
			public static string FindByCode(string apiKey, string accountName, string clientCode)
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
			public static ClientDto FindByCodeTyped(string apiKey, string accountName, string clientCode)
			{
				return FindByCode(apiKey, accountName, clientCode).DeserializeXml<ClientDto>();
			}

	}
}
}