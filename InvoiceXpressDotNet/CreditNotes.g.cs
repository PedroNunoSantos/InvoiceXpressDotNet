// Connector API InvoiceXpressDotNet developed by EventKey,Lda http://www.eventkey.pt
using System;
using System.Net;
namespace InvoiceXpressDotNet
{
	public static partial class InvoiceExpress
    {
		public static class CreditNotes
		{

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/create">CreditNotes Create</a> Method
			/// </summary>
			public static string Create(string apiKey, string accountName, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/credit_notes.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpPost(inputData);
				if ((int) result.StatusCode != 201)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)201)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/create">CreditNotes Create</a> Method
			/// </summary>
			public static CreditNoteDto CreateTyped(string apiKey, string accountName, CreditNoteDto inputData)
			{
				return Create(apiKey, accountName, inputData.XmlSerializeToString()).DeserializeXml<CreditNoteDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/get">CreditNotes Get</a> Method
			/// </summary>
			public static string Get(string apiKey, string accountName, string creditNoteId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/credit_notes/{2}.xml", apiKey, accountName, creditNoteId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/get">CreditNotes Get</a> Method
			/// </summary>
			public static CreditNoteDto GetTyped(string apiKey, string accountName, string creditNoteId)
			{
				return Get(apiKey, accountName, creditNoteId).DeserializeXml<CreditNoteDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/update">CreditNotes Update</a> Method
			/// </summary>
			public static string Update(string apiKey, string accountName, string creditNoteId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/credit_notes/{2}.xml", apiKey, accountName, creditNoteId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/update">CreditNotes Update</a> Method
			/// </summary>
			public static void UpdateTyped(string apiKey, string accountName, string creditNoteId, CreditNoteDto inputData)
			{
				Update(apiKey, accountName, creditNoteId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/list">CreditNotes List</a> Method
			/// </summary>
			public static string List(string apiKey, string accountName, int? page, int? perPage)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/credit_notes.xml?api_key={0}&page={2}&per_page={3}", apiKey, accountName, page, perPage);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/list">CreditNotes List</a> Method
			/// </summary>
			public static CreditNotesDto ListTyped(string apiKey, string accountName, int? page, int? perPage)
			{
				return List(apiKey, accountName, page, perPage).DeserializeXml<CreditNotesDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/change-state">CreditNotes ChangeState</a> Method
			/// </summary>
			public static string ChangeState(string apiKey, string accountName, string creditNoteId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/credit_notes/{2}/change-state.xml?api_key={0}", apiKey, accountName, creditNoteId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/change-state">CreditNotes ChangeState</a> Method
			/// </summary>
			public static void ChangeStateTyped(string apiKey, string accountName, string creditNoteId, CreditNoteChangeStateDto inputData)
			{
				ChangeState(apiKey, accountName, creditNoteId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/email">CreditNotes EmailDocument</a> Method
			/// </summary>
			public static string EmailDocument(string apiKey, string accountName, string creditNoteId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/credit_notes/{2}/email-document.xml?api_key={0}", apiKey, accountName, creditNoteId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/email">CreditNotes EmailDocument</a> Method
			/// </summary>
			public static void EmailDocumentTyped(string apiKey, string accountName, string creditNoteId, EmailMessageDto inputData)
			{
				EmailDocument(apiKey, accountName, creditNoteId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/documents-pdf">CreditNotes Pdf</a> Method
			/// </summary>
			public static string Pdf(string apiKey, string accountName, string simplifiedInvoiceId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/api/pdf/{creditNoteId}.xml?api_key={0}", apiKey, accountName, simplifiedInvoiceId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/documents-pdf">CreditNotes Pdf</a> Method
			/// </summary>
			public static PdfOutputDto PdfTyped(string apiKey, string accountName, string simplifiedInvoiceId)
			{
				return Pdf(apiKey, accountName, simplifiedInvoiceId).DeserializeXml<PdfOutputDto>();
			}

	}
}
}