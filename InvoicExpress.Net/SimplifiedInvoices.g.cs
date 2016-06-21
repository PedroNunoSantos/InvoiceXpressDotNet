// Connector API InvoicExpress.Net developed by EventKey,Lda http://www.eventkey.pt
using System;
using System.Net;
namespace InvoicExpress.Net
{
	public static partial class InvoiceExpress
    {
		public static class SimplifiedInvoices
		{
	
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/simplified-invoices/create">SimplifiedInvoices Create</a> Method
			/// </summary>
			public static string Create(string apiKey, string accountName, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpPost(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/simplified-invoices/create">SimplifiedInvoices Create</a> Method
			/// </summary>
			public static SimplifiedInvoiceDto CreateTyped(string apiKey, string accountName, SimplifiedInvoiceDto inputData)
			{
				return Create(apiKey, accountName, inputData.XmlSerializeToString()).DeserializeXml<SimplifiedInvoiceDto>();
			}
		
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/simplified-invoices/get">SimplifiedInvoices Get</a> Method
			/// </summary>
			public static string Get(string apiKey, string accountName, string simplifiedInvoiceId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices/{2}.xml", apiKey, accountName, simplifiedInvoiceId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/simplified-invoices/get">SimplifiedInvoices Get</a> Method
			/// </summary>
			public static SimplifiedInvoiceDto GetTyped(string apiKey, string accountName, string simplifiedInvoiceId)
			{
				return Get(apiKey, accountName, simplifiedInvoiceId).DeserializeXml<SimplifiedInvoiceDto>();
			}
		
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/simplified-invoices/update">SimplifiedInvoices Update</a> Method
			/// </summary>
			public static string Update(string apiKey, string accountName, string simplifiedInvoiceId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices/{2}.xml", apiKey, accountName, simplifiedInvoiceId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/simplified-invoices/update">SimplifiedInvoices Update</a> Method
			/// </summary>
			public static void UpdateTyped(string apiKey, string accountName, string simplifiedInvoiceId, SimplifiedInvoiceDto inputData)
			{
				Update(apiKey, accountName, simplifiedInvoiceId, inputData.XmlSerializeToString());
			}
		
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/simplified-invoices/list">SimplifiedInvoices List</a> Method
			/// </summary>
			public static string List(string apiKey, string accountName, int page, int perPage)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices.xml?api_key={0}&page={2}&per_page={3}", apiKey, accountName, page, perPage);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/simplified-invoices/list">SimplifiedInvoices List</a> Method
			/// </summary>
			public static SimplifiedInvoicesDto ListTyped(string apiKey, string accountName, int page, int perPage)
			{
				return List(apiKey, accountName, page, perPage).DeserializeXml<SimplifiedInvoicesDto>();
			}
		
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/simplified-invoices/change-state">SimplifiedInvoices ChangeState</a> Method
			/// </summary>
			public static string ChangeState(string apiKey, string accountName, string simplifiedInvoiceId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices/{2}/change-state.xml", apiKey, accountName, simplifiedInvoiceId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/simplified-invoices/change-state">SimplifiedInvoices ChangeState</a> Method
			/// </summary>
			public static void ChangeStateTyped(string apiKey, string accountName, string simplifiedInvoiceId, SimplifiedInvoiceChangeStateDto inputData)
			{
				ChangeState(apiKey, accountName, simplifiedInvoiceId, inputData.XmlSerializeToString());
			}
		
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/simplified-invoices/change-state">SimplifiedInvoices EmailInvoice</a> Method
			/// </summary>
			public static string EmailInvoice(string apiKey, string accountName, string simplifiedInvoiceId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/simplified_invoices/{2}/email-document.xml?api_key={0}", apiKey, accountName, simplifiedInvoiceId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/simplified-invoices/change-state">SimplifiedInvoices EmailInvoice</a> Method
			/// </summary>
			public static void EmailInvoiceTyped(string apiKey, string accountName, string simplifiedInvoiceId, EmailMessageDto inputData)
			{
				EmailInvoice(apiKey, accountName, simplifiedInvoiceId, inputData.XmlSerializeToString());
			}
		
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/documents-pdf">SimplifiedInvoices Pdf</a> Method
			/// </summary>
			public static string Pdf(string apiKey, string accountName, string simplifiedInvoiceId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/api/pdf/{2}.xml?api_key={0}", apiKey, accountName, simplifiedInvoiceId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/invoices/documents-pdf">SimplifiedInvoices Pdf</a> Method
			/// </summary>
			public static PdfOutputDto PdfTyped(string apiKey, string accountName, string simplifiedInvoiceId)
			{
				return Pdf(apiKey, accountName, simplifiedInvoiceId).DeserializeXml<PdfOutputDto>();
			}
		
		}
	}
}