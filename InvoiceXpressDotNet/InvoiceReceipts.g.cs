// Connector API InvoiceXpressDotNet developed by EventKey,Lda http://www.eventkey.pt
using System;
using System.Net;
using System.ComponentModel;

namespace InvoiceXpressDotNet
{
	public static partial class InvoiceExpress
    {
		/// <summary>
		/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/create">InvoiceReceipts</a> module
		/// </summary>
		public static class InvoiceReceipts
		{

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/create">InvoiceReceipts Create</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static string Rest_Create(string apiKey, string accountName, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoice_receipts.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpPost(inputData);
				if ((int) result.StatusCode != 201)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)201)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/create">InvoiceReceipts Create</a> Method
			/// </summary>
			public static InvoiceReceiptDto Create(string apiKey, string accountName, InvoiceReceiptDto inputData)
			{
				string xmlResult = Rest_Create(apiKey, accountName, inputData.XmlSerializeToString());
			    return xmlResult.DeserializeXml<InvoiceReceiptDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/get">InvoiceReceipts Get</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static string Rest_Get(string apiKey, string accountName, int invoiceReceiptId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoice_receipts/{2}.xml?api_key={0}", apiKey, accountName, invoiceReceiptId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/get">InvoiceReceipts Get</a> Method
			/// </summary>
			public static InvoiceReceiptDto Get(string apiKey, string accountName, int invoiceReceiptId)
			{
				string xmlResult = Rest_Get(apiKey, accountName, invoiceReceiptId);
			    return xmlResult.DeserializeXml<InvoiceReceiptDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/update">InvoiceReceipts Update</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static string Rest_Update(string apiKey, string accountName, int invoiceReceiptId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoice_receipts/{2}.xml?api_key={0}", apiKey, accountName, invoiceReceiptId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
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
			public static string Rest_List(string apiKey, string accountName)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoice_receipts.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/list">InvoiceReceipts List</a> Method
			/// </summary>
			public static InvoiceReceiptsDto List(string apiKey, string accountName)
			{
				string xmlResult = Rest_List(apiKey, accountName);
			    return xmlResult.DeserializeXml<InvoiceReceiptsDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/change-state">InvoiceReceipts ChangeState</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static string Rest_ChangeState(string apiKey, string accountName, int invoiceReceiptId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoice_receipts/{2}/change-state.xml?api_key={0}", apiKey, accountName, invoiceReceiptId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/change-state">InvoiceReceipts ChangeState</a> Method
			/// </summary>
			public static InvoiceReceiptChangeStateDto ChangeState(string apiKey, string accountName, int invoiceReceiptId, InvoiceReceiptChangeStateDto inputData)
			{
				string xmlResult = Rest_ChangeState(apiKey, accountName, invoiceReceiptId, inputData.XmlSerializeToString());
			    return xmlResult.DeserializeXml<InvoiceReceiptChangeStateDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/email">InvoiceReceipts EmailInvoice</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static string Rest_EmailInvoice(string apiKey, string accountName, int invoiceReceiptId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoice_receipts/{2}/email-document.xml?api_key={0}", apiKey, accountName, invoiceReceiptId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
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
			public static string Rest_RelatedDocuments(string apiKey, string accountName, int invoiceReceiptId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/document/{2}/related_documents.xml?api_key={0}", apiKey, accountName, invoiceReceiptId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/related-documents">InvoiceReceipts RelatedDocuments</a> Method
			/// </summary>
			public static InvoicesDto RelatedDocuments(string apiKey, string accountName, int invoiceReceiptId)
			{
				string xmlResult = Rest_RelatedDocuments(apiKey, accountName, invoiceReceiptId);
			    return xmlResult.DeserializeXml<InvoicesDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/documents-pdf">InvoiceReceipts Pdf</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static string Rest_Pdf(string apiKey, string accountName, int invoiceReceiptId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/api/pdf/{2}.xml?api_key={0}", apiKey, accountName, invoiceReceiptId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/documents-pdf">InvoiceReceipts Pdf</a> Method
			/// </summary>
			public static PdfOutputDto Pdf(string apiKey, string accountName, int invoiceReceiptId)
			{
				string xmlResult = Rest_Pdf(apiKey, accountName, invoiceReceiptId);
			    return xmlResult.DeserializeXml<PdfOutputDto>();
			}

	}
}
}