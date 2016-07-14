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
		/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices">Invoices</a> module
		/// </summary>
		public static partial class Invoices
		{

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/create">Invoices Create</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Create(string apiKey, string accountName, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoices.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpPost(inputData);
				if ((int) result.StatusCode != 201)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)201)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/create">Invoices Create</a> Method
			/// </summary>
			public static InvoiceDto Create(string apiKey, string accountName, InvoiceDto inputData)
			{
				HttpResponseInfo result = Rest_Create(apiKey, accountName, inputData.XmlSerializeToString());
			    return result.Text.DeserializeXml<InvoiceDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/get">Invoices Get</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Get(string apiKey, string accountName, int invoiceId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoices/{2}.xml?api_key={0}", apiKey, accountName, invoiceId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/get">Invoices Get</a> Method
			/// </summary>
			public static InvoiceDto Get(string apiKey, string accountName, int invoiceId)
			{
				HttpResponseInfo result = Rest_Get(apiKey, accountName, invoiceId);
			    return result.Text.DeserializeXml<InvoiceDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/update">Invoices Update</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Update(string apiKey, string accountName, int invoiceId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoices/{2}.xml?api_key={0}", apiKey, accountName, invoiceId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/update">Invoices Update</a> Method
			/// </summary>
			public static void Update(string apiKey, string accountName, int invoiceId, InvoiceDto inputData)
			{
				Rest_Update(apiKey, accountName, invoiceId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/list">Invoices List</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_List(string apiKey, string accountName)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoices.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/list">Invoices List</a> Method
			/// </summary>
			public static InvoicesDto List(string apiKey, string accountName)
			{
				HttpResponseInfo result = Rest_List(apiKey, accountName);
			    return result.Text.DeserializeXml<InvoicesDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/change-state">Invoices ChangeState</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_ChangeState(string apiKey, string accountName, int invoiceId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoice/{2}/change-state.xml?api_key={0}", apiKey, accountName, invoiceId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/change-state">Invoices ChangeState</a> Method
			/// </summary>
			public static InvoiceChangeStateDto ChangeState(string apiKey, string accountName, int invoiceId, InvoiceChangeStateDto inputData)
			{
				HttpResponseInfo result = Rest_ChangeState(apiKey, accountName, invoiceId, inputData.XmlSerializeToString());
			    return result.Text.DeserializeXml<InvoiceChangeStateDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/email-invoice">Invoices EmailInvoice</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_EmailInvoice(string apiKey, string accountName, int invoiceId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoices/{2}/email-document.xml?api_key={0}", apiKey, accountName, invoiceId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/email-invoice">Invoices EmailInvoice</a> Method
			/// </summary>
			public static void EmailInvoice(string apiKey, string accountName, int invoiceId, EmailMessageDto inputData)
			{
				Rest_EmailInvoice(apiKey, accountName, invoiceId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/related-documents">Invoices RelatedDocuments</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_RelatedDocuments(string apiKey, string accountName, int invoiceId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/document/{2}/related_documents.xml?api_key={0}", apiKey, accountName, invoiceId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/related-documents">Invoices RelatedDocuments</a> Method
			/// </summary>
			public static InvoicesDto RelatedDocuments(string apiKey, string accountName, int invoiceId)
			{
				HttpResponseInfo result = Rest_RelatedDocuments(apiKey, accountName, invoiceId);
			    return result.Text.DeserializeXml<InvoicesDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/archive">Invoices Archive</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Archive(string apiKey, string accountName, string documentType, int documentId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/{2}/{3}/archive.xml?api_key={0}", apiKey, accountName, documentType, documentId);
				var result = url.HttpPut();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/archive">Invoices Archive</a> Method
			/// </summary>
			public static void Archive(string apiKey, string accountName, string documentType, int documentId)
			{
				Rest_Archive(apiKey, accountName, documentType, documentId);
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/unarchive">Invoices Unarchive</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Unarchive(string apiKey, string accountName, string documentType, int documentId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/{2}/{3}/unarchive.xml?api_key={0}", apiKey, accountName, documentType, documentId);
				var result = url.HttpPut();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/unarchive">Invoices Unarchive</a> Method
			/// </summary>
			public static void Unarchive(string apiKey, string accountName, string documentType, int documentId)
			{
				Rest_Unarchive(apiKey, accountName, documentType, documentId);
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/partial-payment">Invoices PartialPayment</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_PartialPayment(string apiKey, string accountName, int documentId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/documents/{2}/partial_payments.xml?api_key={0}", apiKey, accountName, documentId);
				var result = url.HttpPost(inputData);
				if ((int) result.StatusCode != 201)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)201)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/partial-payment">Invoices PartialPayment</a> Method
			/// </summary>
			public static PartialPaymentReceiptDto PartialPayment(string apiKey, string accountName, int documentId, PartialPaymentDto inputData)
			{
				HttpResponseInfo result = Rest_PartialPayment(apiKey, accountName, documentId, inputData.XmlSerializeToString());
			    return result.Text.DeserializeXml<PartialPaymentReceiptDto>();
			}

	}
}
}