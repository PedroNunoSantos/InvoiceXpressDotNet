// Connector API InvoiceXpressDotNet developed by EventKey,Lda http://www.eventkey.pt
using System;
using System.Net;
using System.ComponentModel;
using InvoiceXpressDotNet.Extensions;

namespace InvoiceXpressDotNet
{
	public static partial class InvoiceXpress
    {
		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/items/create">Items</a> module
		/// </summary>
		public static partial class Items
		{

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/items/create">Items Create</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Create(string apiKey, string accountName, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/items.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpPost(inputData);
				if ((int) result.StatusCode != 201)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)201)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/items/create">Items Create</a> Method
			/// </summary>
			public static ItemDto Create(string apiKey, string accountName, ItemDto inputData)
			{
				HttpResponseInfo result = Rest_Create(apiKey, accountName, inputData.XmlSerializeToString());
			    return result.Text.DeserializeXml<ItemDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/items/get">Items Get</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Get(string apiKey, string accountName, int itemId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/items/{2}.xml?api_key={0}", apiKey, accountName, itemId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/items/get">Items Get</a> Method
			/// </summary>
			public static ItemDto Get(string apiKey, string accountName, int itemId)
			{
				HttpResponseInfo result = Rest_Get(apiKey, accountName, itemId);
			    return result.Text.DeserializeXml<ItemDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/items/update">Items Update</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Update(string apiKey, string accountName, int itemId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/clients/{clientId}.xml?api_key={0}", apiKey, accountName, itemId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/items/update">Items Update</a> Method
			/// </summary>
			public static void Update(string apiKey, string accountName, int itemId, ItemDto inputData)
			{
				Rest_Update(apiKey, accountName, itemId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/items/delete">Items Delete</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Delete(string apiKey, string accountName, int itemId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/items/{2}.xml?api_key={0}", apiKey, accountName, itemId);
				var result = url.HttpDelete();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/items/delete">Items Delete</a> Method
			/// </summary>
			public static void Delete(string apiKey, string accountName, int itemId)
			{
				Rest_Delete(apiKey, accountName, itemId);
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/list">Items List</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_List(string apiKey, string accountName)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/items.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/clients/list">Items List</a> Method
			/// </summary>
			public static ItemsDto List(string apiKey, string accountName)
			{
				HttpResponseInfo result = Rest_List(apiKey, accountName);
			    return result.Text.DeserializeXml<ItemsDto>();
			}

	}
}
}