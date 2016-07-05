// Connector API InvoiceXpressDotNet developed by EventKey,Lda http://www.eventkey.pt
using System;
using System.Net;
namespace InvoiceXpressDotNet
{
	public static partial class InvoiceExpress
    {
		public static class Items
		{

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/items/create">Items Create</a> Method
			/// </summary>
			public static string Create(string apiKey, string accountName, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/items.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpPost(inputData);
				if ((int) result.StatusCode != 201)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)201)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/items/create">Items Create</a> Method
			/// </summary>
			public static ItemDto CreateTyped(string apiKey, string accountName, ItemDto inputData)
			{
				string xmlResult = Create(apiKey, accountName, inputData.XmlSerializeToString());
			    return xmlResult.DeserializeXml<ItemDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/items/get">Items Get</a> Method
			/// </summary>
			public static string Get(string apiKey, string accountName, string itemId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/items/{2}.xml?api_key={0}", apiKey, accountName, itemId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/items/get">Items Get</a> Method
			/// </summary>
			public static ItemDto GetTyped(string apiKey, string accountName, string itemId)
			{
				string xmlResult = Get(apiKey, accountName, itemId);
			    return xmlResult.DeserializeXml<ItemDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/items/update">Items Update</a> Method
			/// </summary>
			public static string Update(string apiKey, string accountName, string itemId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/clients/{clientId}.xml?api_key={0}", apiKey, accountName, itemId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/items/update">Items Update</a> Method
			/// </summary>
			public static void UpdateTyped(string apiKey, string accountName, string itemId, ItemDto inputData)
			{
				Update(apiKey, accountName, itemId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/items/delete">Items Delete</a> Method
			/// </summary>
			public static string Delete(string apiKey, string accountName, string itemId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/items/{2}.xml?api_key={0}", apiKey, accountName, itemId);
				var result = url.HttpDelete();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/items/delete">Items Delete</a> Method
			/// </summary>
			public static void DeleteTyped(string apiKey, string accountName, string itemId)
			{
				Delete(apiKey, accountName, itemId);
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/list">Items List</a> Method
			/// </summary>
			public static string List(string apiKey, string accountName)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/items.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/list">Items List</a> Method
			/// </summary>
			public static ItemsDto ListTyped(string apiKey, string accountName)
			{
				string xmlResult = List(apiKey, accountName);
			    return xmlResult.DeserializeXml<ItemsDto>();
			}

	}
}
}