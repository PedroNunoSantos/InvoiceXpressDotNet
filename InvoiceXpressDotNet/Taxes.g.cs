// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Net;
using System.ComponentModel;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.DataTransferObjects;

namespace InvoiceXpressDotNet
{
	public static partial class InvoiceXpress
    {
		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/taxes">Taxes</a> module
		/// </summary>
		public static partial class Taxes
		{

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/taxes/create">Taxes Create</a> Method
			/// </summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Create(string apiKey, string accountName, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/taxes.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpPost(inputData);
				if ((int) result.StatusCode != 201)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)201)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/taxes/create">Taxes Create</a> Method
			/// </summary>
			public static TaxDto Create(string apiKey, string accountName, TaxDto inputData)
			{
				HttpResponseInfo result = Rest_Create(apiKey, accountName, inputData.XmlSerializeToString());
			    return result.Text.DeserializeXml<TaxDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/taxes/get">Taxes Get</a> Method
			/// </summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Get(string apiKey, string accountName, int taxId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/taxes/{2}.xml?api_key={0}", apiKey, accountName, taxId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/taxes/get">Taxes Get</a> Method
			/// </summary>
			public static TaxDto Get(string apiKey, string accountName, int taxId)
			{
				HttpResponseInfo result = Rest_Get(apiKey, accountName, taxId);
			    return result.Text.DeserializeXml<TaxDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/taxes/update">Taxes Update</a> Method
			/// </summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Update(string apiKey, string accountName, int taxId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/taxes/{2}.xml?api_key={0}", apiKey, accountName, taxId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/taxes/update">Taxes Update</a> Method
			/// </summary>
			public static void Update(string apiKey, string accountName, int taxId, TaxDto inputData)
			{
				Rest_Update(apiKey, accountName, taxId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/taxes/create">Taxes Delete</a> Method
			/// </summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Delete(string apiKey, string accountName, int taxId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/taxes/{2}.xml?api_key={0}", apiKey, accountName, taxId);
				var result = url.HttpDelete(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/taxes/create">Taxes Delete</a> Method
			/// </summary>
			public static TaxDto Delete(string apiKey, string accountName, int taxId, TaxDto inputData)
			{
				HttpResponseInfo result = Rest_Delete(apiKey, accountName, taxId, inputData.XmlSerializeToString());
			    return result.Text.DeserializeXml<TaxDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/taxes/list">Taxes List</a> Method
			/// </summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_List(string apiKey, string accountName)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/taxes.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/taxes/list">Taxes List</a> Method
			/// </summary>
			public static TaxesDto List(string apiKey, string accountName)
			{
				HttpResponseInfo result = Rest_List(apiKey, accountName);
			    return result.Text.DeserializeXml<TaxesDto>();
			}

	}
}
}