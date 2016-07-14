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
		/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/create">InvoiceReceipts</a> module
		/// </summary>
		public static partial class InvoiceReceipts
		{

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/create">InvoiceReceipts Create</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Create(string apiKey, string accountName, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoice_receipts.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpPost(inputData);
				if ((int) result.StatusCode != 201)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)201)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/create">InvoiceReceipts Create</a> Method
			/// </summary>
			public static InvoiceReceiptDto Create(string apiKey, string accountName, InvoiceReceiptDto inputData)
			{
				HttpResponseInfo result = Rest_Create(apiKey, accountName, inputData.XmlSerializeToString());
			    return result.Text.DeserializeXml<InvoiceReceiptDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/get">InvoiceReceipts Get</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Get(string apiKey, string accountName, int invoiceReceiptId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoice_receipts/{2}.xml?api_key={0}", apiKey, accountName, invoiceReceiptId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/get">InvoiceReceipts Get</a> Method
			/// </summary>
			public static InvoiceReceiptDto Get(string apiKey, string accountName, int invoiceReceiptId)
			{
				HttpResponseInfo result = Rest_Get(apiKey, accountName, invoiceReceiptId);
			    return result.Text.DeserializeXml<InvoiceReceiptDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/update">InvoiceReceipts Update</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Update(string apiKey, string accountName, int invoiceReceiptId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoice_receipts/{2}.xml?api_key={0}", apiKey, accountName, invoiceReceiptId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/update">InvoiceReceipts Update</a> Method
			/// </summary>
			public static void Update(string apiKey, string accountName, int invoiceReceiptId, InvoiceReceiptDto inputData)
			{
				Rest_Update(apiKey, accountName, invoiceReceiptId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/list">InvoiceReceipts List</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_List(string apiKey, string accountName)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoice_receipts.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/list">InvoiceReceipts List</a> Method
			/// </summary>
			public static InvoiceReceiptsDto List(string apiKey, string accountName)
			{
				HttpResponseInfo result = Rest_List(apiKey, accountName);
			    return result.Text.DeserializeXml<InvoiceReceiptsDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/change-state">InvoiceReceipts ChangeState</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_ChangeState(string apiKey, string accountName, int invoiceReceiptId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoice_receipts/{2}/change-state.xml?api_key={0}", apiKey, accountName, invoiceReceiptId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/change-state">InvoiceReceipts ChangeState</a> Method
			/// </summary>
			public static InvoiceReceiptChangeStateDto ChangeState(string apiKey, string accountName, int invoiceReceiptId, InvoiceReceiptChangeStateDto inputData)
			{
				HttpResponseInfo result = Rest_ChangeState(apiKey, accountName, invoiceReceiptId, inputData.XmlSerializeToString());
			    return result.Text.DeserializeXml<InvoiceReceiptChangeStateDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/email">InvoiceReceipts EmailInvoice</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_EmailInvoice(string apiKey, string accountName, int invoiceReceiptId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoice_receipts/{2}/email-document.xml?api_key={0}", apiKey, accountName, invoiceReceiptId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/email">InvoiceReceipts EmailInvoice</a> Method
			/// </summary>
			public static void EmailInvoice(string apiKey, string accountName, int invoiceReceiptId, EmailMessageDto inputData)
			{
				Rest_EmailInvoice(apiKey, accountName, invoiceReceiptId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/related-documents">InvoiceReceipts RelatedDocuments</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_RelatedDocuments(string apiKey, string accountName, int invoiceReceiptId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/document/{2}/related_documents.xml?api_key={0}", apiKey, accountName, invoiceReceiptId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/related-documents">InvoiceReceipts RelatedDocuments</a> Method
			/// </summary>
			public static InvoicesDto RelatedDocuments(string apiKey, string accountName, int invoiceReceiptId)
			{
				HttpResponseInfo result = Rest_RelatedDocuments(apiKey, accountName, invoiceReceiptId);
			    return result.Text.DeserializeXml<InvoicesDto>();
			}

	}
}
}