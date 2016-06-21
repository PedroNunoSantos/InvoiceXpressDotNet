// Connector API InvoicExpress.Net developed by EventKey,Lda http://www.eventkey.pt
using System;
using System.Net;
namespace InvoicExpress.Net
{
	public static partial class InvoiceExpress
    {
		public static class Invoices
		{
	
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/create">Invoices Create</a> Method
			/// </summary>
			public static string Create(string apiKey, string accountName, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoices.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpPost(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/create">Invoices Create</a> Method
			/// </summary>
			public static InvoiceDto CreateTyped(string apiKey, string accountName, InvoiceDto inputData)
			{
				return Create(apiKey, accountName, inputData.XmlSerializeToString()).DeserializeXml<InvoiceDto>();
			}
		
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/get">Invoices Get</a> Method
			/// </summary>
			public static string Get(string apiKey, string accountName, string invoiceId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoices/{2}.xml?api_key={0}", apiKey, accountName, invoiceId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/get">Invoices Get</a> Method
			/// </summary>
			public static InvoiceDto GetTyped(string apiKey, string accountName, string invoiceId)
			{
				return Get(apiKey, accountName, invoiceId).DeserializeXml<InvoiceDto>();
			}
		
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/update">Invoices Update</a> Method
			/// </summary>
			public static string Update(string apiKey, string accountName, string invoiceId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoices/{2}.xml?api_key={0}", apiKey, accountName, invoiceId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/update">Invoices Update</a> Method
			/// </summary>
			public static void UpdateTyped(string apiKey, string accountName, string invoiceId, InvoiceDto inputData)
			{
				Update(apiKey, accountName, invoiceId, inputData.XmlSerializeToString());
			}
		
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/list">Invoices List</a> Method
			/// </summary>
			public static string List(string apiKey, string accountName)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoices.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/list">Invoices List</a> Method
			/// </summary>
			public static InvoicesDto ListTyped(string apiKey, string accountName)
			{
				return List(apiKey, accountName).DeserializeXml<InvoicesDto>();
			}
		
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/change-state">Invoices ChangeState</a> Method
			/// </summary>
			public static string ChangeState(string apiKey, string accountName, string invoiceId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoice/{2}/change-state.xml?api_key={0}", apiKey, accountName, invoiceId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/change-state">Invoices ChangeState</a> Method
			/// </summary>
			public static InvoiceChangeStateDto ChangeStateTyped(string apiKey, string accountName, string invoiceId, InvoiceChangeStateDto inputData)
			{
				return ChangeState(apiKey, accountName, invoiceId, inputData.XmlSerializeToString()).DeserializeXml<InvoiceChangeStateDto>();
			}
		
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/email-invoice">Invoices EmailInvoice</a> Method
			/// </summary>
			public static string EmailInvoice(string apiKey, string accountName, string invoiceId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoices/{2}/email-document.xml?api_key={0}", apiKey, accountName, invoiceId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/email-invoice">Invoices EmailInvoice</a> Method
			/// </summary>
			public static void EmailInvoiceTyped(string apiKey, string accountName, string invoiceId, EmailMessageDto inputData)
			{
				EmailInvoice(apiKey, accountName, invoiceId, inputData.XmlSerializeToString());
			}
		
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/related-documents">Invoices RelatedDocuments</a> Method
			/// </summary>
			public static string RelatedDocuments(string apiKey, string accountName, string invoiceId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/document/{2}/related_documents.xml?api_key={0}", apiKey, accountName, invoiceId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/related-documents">Invoices RelatedDocuments</a> Method
			/// </summary>
			public static InvoicesDto RelatedDocumentsTyped(string apiKey, string accountName, string invoiceId)
			{
				return RelatedDocuments(apiKey, accountName, invoiceId).DeserializeXml<InvoicesDto>();
			}
		
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/documents-pdf">Invoices Pdf</a> Method
			/// </summary>
			public static string Pdf(string apiKey, string accountName, string invoiceId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/api/pdf/{2}.xml?api_key={0}", apiKey, accountName, invoiceId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/documents-pdf">Invoices Pdf</a> Method
			/// </summary>
			public static PdfOutputDto PdfTyped(string apiKey, string accountName, string invoiceId)
			{
				return Pdf(apiKey, accountName, invoiceId).DeserializeXml<PdfOutputDto>();
			}
		
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/archive">Invoices Archive</a> Method
			/// </summary>
			public static string Archive(string apiKey, string accountName, string documentType, string documentId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/{2}/{3}/archive.xml?api_key={0}", apiKey, accountName, documentType, documentId);
				var result = url.HttpPut();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/archive">Invoices Archive</a> Method
			/// </summary>
			public static void ArchiveTyped(string apiKey, string accountName, string documentType, string documentId)
			{
				Archive(apiKey, accountName, documentType, documentId);
			}
		
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/unarchive">Invoices Unarchive</a> Method
			/// </summary>
			public static string Unarchive(string apiKey, string accountName, string documentType, string documentId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/{2}/{3}/unarchive.xml?api_key={0}", apiKey, accountName, documentType, documentId);
				var result = url.HttpPut();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/unarchive">Invoices Unarchive</a> Method
			/// </summary>
			public static void UnarchiveTyped(string apiKey, string accountName, string documentType, string documentId)
			{
				Unarchive(apiKey, accountName, documentType, documentId);
			}
		
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/partial-payment">Invoices PartialPayment</a> Method
			/// </summary>
			public static string PartialPayment(string apiKey, string accountName, string documentId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/documents/{2}/partial_payments.xml", apiKey, accountName, documentId);
				var result = url.HttpPost(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/partial-payment">Invoices PartialPayment</a> Method
			/// </summary>
			public static PartialPaymentReceiptDto PartialPaymentTyped(string apiKey, string accountName, string documentId, PartialPaymentDto inputData)
			{
				return PartialPayment(apiKey, accountName, documentId, inputData.XmlSerializeToString()).DeserializeXml<PartialPaymentReceiptDto>();
			}
		
		}
	}
}