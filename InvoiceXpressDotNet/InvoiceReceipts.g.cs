// Connector API InvoiceXpressDotNet developed by EventKey,Lda http://www.eventkey.pt
using System;
using System.Net;
namespace InvoiceXpressDotNet
{
	public static partial class InvoiceExpress
    {
		public static class InvoiceReceipts
		{

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/create">InvoiceReceipts Create</a> Method
			/// </summary>
			public static string Create(string apiKey, string accountName, string inputData)
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
			public static InvoiceReceiptDto CreateTyped(string apiKey, string accountName, InvoiceReceiptDto inputData)
			{
				return Create(apiKey, accountName, inputData.XmlSerializeToString()).DeserializeXml<InvoiceReceiptDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/get">InvoiceReceipts Get</a> Method
			/// </summary>
			public static string Get(string apiKey, string accountName, int invoiceReceiptId)
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
			public static InvoiceReceiptDto GetTyped(string apiKey, string accountName, int invoiceReceiptId)
			{
				return Get(apiKey, accountName, invoiceReceiptId).DeserializeXml<InvoiceReceiptDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/update">InvoiceReceipts Update</a> Method
			/// </summary>
			public static string Update(string apiKey, string accountName, int invoiceReceiptId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoice_receipts/{2}.xml", apiKey, accountName, invoiceReceiptId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/update">InvoiceReceipts Update</a> Method
			/// </summary>
			public static void UpdateTyped(string apiKey, string accountName, int invoiceReceiptId, InvoiceReceiptDto inputData)
			{
				Update(apiKey, accountName, invoiceReceiptId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/list">InvoiceReceipts List</a> Method
			/// </summary>
			public static string List(string apiKey, string accountName)
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
			public static InvoiceReceiptsDto ListTyped(string apiKey, string accountName)
			{
				return List(apiKey, accountName).DeserializeXml<InvoiceReceiptsDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/change-state">InvoiceReceipts ChangeState</a> Method
			/// </summary>
			public static string ChangeState(string apiKey, string accountName, int invoiceReceiptId, string inputData)
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
			public static InvoiceReceiptChangeStateDto ChangeStateTyped(string apiKey, string accountName, int invoiceReceiptId, InvoiceReceiptChangeStateDto inputData)
			{
				return ChangeState(apiKey, accountName, invoiceReceiptId, inputData.XmlSerializeToString()).DeserializeXml<InvoiceReceiptChangeStateDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/email">InvoiceReceipts EmailInvoice</a> Method
			/// </summary>
			public static string EmailInvoice(string apiKey, string accountName, int invoiceReceiptId, string inputData)
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
			public static void EmailInvoiceTyped(string apiKey, string accountName, int invoiceReceiptId, EmailMessageDto inputData)
			{
				EmailInvoice(apiKey, accountName, invoiceReceiptId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/related-documents">InvoiceReceipts RelatedDocuments</a> Method
			/// </summary>
			public static string RelatedDocuments(string apiKey, string accountName, int invoiceReceiptId)
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
			public static InvoicesDto RelatedDocumentsTyped(string apiKey, string accountName, int invoiceReceiptId)
			{
				return RelatedDocuments(apiKey, accountName, invoiceReceiptId).DeserializeXml<InvoicesDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/documents-pdf">InvoiceReceipts Pdf</a> Method
			/// </summary>
			public static string Pdf(string apiKey, string accountName, int invoiceReceiptId)
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
			public static PdfOutputDto PdfTyped(string apiKey, string accountName, int invoiceReceiptId)
			{
				return Pdf(apiKey, accountName, invoiceReceiptId).DeserializeXml<PdfOutputDto>();
			}

	}
}
}