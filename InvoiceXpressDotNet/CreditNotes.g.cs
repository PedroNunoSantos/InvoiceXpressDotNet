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
		/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes">CreditNotes</a> module
		/// </summary>
		public static partial class CreditNotes
		{

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/create">CreditNotes Create</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Create(string apiKey, string accountName, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/credit_notes.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpPost(inputData);
				if ((int) result.StatusCode != 201)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)201)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/create">CreditNotes Create</a> Method
			/// </summary>
			public static CreditNoteDto Create(string apiKey, string accountName, CreditNoteDto inputData)
			{
				HttpResponseInfo result = Rest_Create(apiKey, accountName, inputData.XmlSerializeToString());
			    return result.Text.DeserializeXml<CreditNoteDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/get">CreditNotes Get</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Get(string apiKey, string accountName, int creditNoteId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/credit_notes/{2}.xml?api_key={0}", apiKey, accountName, creditNoteId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/get">CreditNotes Get</a> Method
			/// </summary>
			public static CreditNoteDto Get(string apiKey, string accountName, int creditNoteId)
			{
				HttpResponseInfo result = Rest_Get(apiKey, accountName, creditNoteId);
			    return result.Text.DeserializeXml<CreditNoteDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/update">CreditNotes Update</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Update(string apiKey, string accountName, int creditNoteId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/credit_notes/{2}.xml?api_key={0}", apiKey, accountName, creditNoteId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/simplified-invoices/update">CreditNotes Update</a> Method
			/// </summary>
			public static void Update(string apiKey, string accountName, int creditNoteId, CreditNoteDto inputData)
			{
				Rest_Update(apiKey, accountName, creditNoteId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/list">CreditNotes List</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_List(string apiKey, string accountName, int? page, int? perPage)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/credit_notes.xml?api_key={0}&page={2}&per_page={3}", apiKey, accountName, page, perPage);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/list">CreditNotes List</a> Method
			/// </summary>
			public static CreditNotesDto List(string apiKey, string accountName, int? page, int? perPage)
			{
				HttpResponseInfo result = Rest_List(apiKey, accountName, page, perPage);
			    return result.Text.DeserializeXml<CreditNotesDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/change-state">CreditNotes ChangeState</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_ChangeState(string apiKey, string accountName, int creditNoteId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/credit_notes/{2}/change-state.xml?api_key={0}", apiKey, accountName, creditNoteId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/change-state">CreditNotes ChangeState</a> Method
			/// </summary>
			public static void ChangeState(string apiKey, string accountName, int creditNoteId, CreditNoteChangeStateDto inputData)
			{
				Rest_ChangeState(apiKey, accountName, creditNoteId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/email">CreditNotes EmailDocument</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_EmailDocument(string apiKey, string accountName, int creditNoteId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/credit_notes/{2}/email-document.xml?api_key={0}", apiKey, accountName, creditNoteId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/email">CreditNotes EmailDocument</a> Method
			/// </summary>
			public static void EmailDocument(string apiKey, string accountName, int creditNoteId, EmailMessageDto inputData)
			{
				Rest_EmailDocument(apiKey, accountName, creditNoteId, inputData.XmlSerializeToString());
			}

	}
}
}