// Connector API InvoiceXpressDotNet developed by EventKey,Lda http://www.eventkey.pt
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
		/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices">SimplifiedInvoices</a> module
		/// </summary>
		public static partial class SimplifiedInvoices
		{

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/create">SimplifiedInvoices Create</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Create(string apiKey, string accountName, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpPost(inputData);
				if ((int) result.StatusCode != 201)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)201)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/create">SimplifiedInvoices Create</a> Method
			/// </summary>
			public static SimplifiedInvoiceDto Create(string apiKey, string accountName, SimplifiedInvoiceDto inputData)
			{
				HttpResponseInfo result = Rest_Create(apiKey, accountName, inputData.XmlSerializeToString());
			    return result.Text.DeserializeXml<SimplifiedInvoiceDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/get">SimplifiedInvoices Get</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Get(string apiKey, string accountName, int simplifiedInvoiceId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices/{2}.xml?api_key={0}", apiKey, accountName, simplifiedInvoiceId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/get">SimplifiedInvoices Get</a> Method
			/// </summary>
			public static SimplifiedInvoiceDto Get(string apiKey, string accountName, int simplifiedInvoiceId)
			{
				HttpResponseInfo result = Rest_Get(apiKey, accountName, simplifiedInvoiceId);
			    return result.Text.DeserializeXml<SimplifiedInvoiceDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/update">SimplifiedInvoices Update</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Update(string apiKey, string accountName, int simplifiedInvoiceId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices/{2}.xml?api_key={0}", apiKey, accountName, simplifiedInvoiceId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/update">SimplifiedInvoices Update</a> Method
			/// </summary>
			public static void Update(string apiKey, string accountName, int simplifiedInvoiceId, SimplifiedInvoiceDto inputData)
			{
				Rest_Update(apiKey, accountName, simplifiedInvoiceId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/list">SimplifiedInvoices List</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_List(string apiKey, string accountName, int? page, int? perPage)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices.xml?api_key={0}&page={2}&per_page={3}", apiKey, accountName, page, perPage);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/list">SimplifiedInvoices List</a> Method
			/// </summary>
			public static SimplifiedInvoicesDto List(string apiKey, string accountName, int? page, int? perPage)
			{
				HttpResponseInfo result = Rest_List(apiKey, accountName, page, perPage);
			    return result.Text.DeserializeXml<SimplifiedInvoicesDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/change-state">SimplifiedInvoices ChangeState</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_ChangeState(string apiKey, string accountName, string simplifiedInvoiceId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices/{2}/change-state.xml?api_key={0}", apiKey, accountName, simplifiedInvoiceId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/change-state">SimplifiedInvoices ChangeState</a> Method
			/// </summary>
			public static void ChangeState(string apiKey, string accountName, string simplifiedInvoiceId, SimplifiedInvoiceChangeStateDto inputData)
			{
				Rest_ChangeState(apiKey, accountName, simplifiedInvoiceId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/change-state">SimplifiedInvoices EmailInvoice</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_EmailInvoice(string apiKey, string accountName, int simplifiedInvoiceId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices/{2}/email-document.xml?api_key={0}", apiKey, accountName, simplifiedInvoiceId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/change-state">SimplifiedInvoices EmailInvoice</a> Method
			/// </summary>
			public static void EmailInvoice(string apiKey, string accountName, int simplifiedInvoiceId, EmailMessageDto inputData)
			{
				Rest_EmailInvoice(apiKey, accountName, simplifiedInvoiceId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/related-documents">SimplifiedInvoices RelatedDocuments</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_RelatedDocuments(string apiKey, string accountName, int simplifiedInvoiceId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/document/{2}/related_documents.xml?api_key={0}", apiKey, accountName, simplifiedInvoiceId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/related-documents">SimplifiedInvoices RelatedDocuments</a> Method
			/// </summary>
			public static void RelatedDocuments(string apiKey, string accountName, int simplifiedInvoiceId)
			{
				Rest_RelatedDocuments(apiKey, accountName, simplifiedInvoiceId);
			}

	}
}
}