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
		/// InvoiceXpress <a href="https://invoicexpress.com/api/proformas">Proformas</a> module
		/// </summary>
		public static partial class Proformas
		{

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/proformas/create">Proformas Create</a> Method
			/// </summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Create(string apiKey, string accountName, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/proformas.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpPost(inputData);
				if ((int) result.StatusCode != 201)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)201)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/proformas/create">Proformas Create</a> Method
			/// </summary>
			public static ProformaDto Create(string apiKey, string accountName, ProformaDto inputData)
			{
				HttpResponseInfo result = Rest_Create(apiKey, accountName, inputData.XmlSerializeToString());
			    return result.Text.DeserializeXml<ProformaDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/proformas/get">Proformas Get</a> Method
			/// </summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Get(string apiKey, string accountName, int proformaId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoices/{2}.xml?api_key={0}", apiKey, accountName, proformaId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/proformas/get">Proformas Get</a> Method
			/// </summary>
			public static ProformaDto Get(string apiKey, string accountName, int proformaId)
			{
				HttpResponseInfo result = Rest_Get(apiKey, accountName, proformaId);
			    return result.Text.DeserializeXml<ProformaDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/proformas/update">Proformas Update</a> Method
			/// </summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Update(string apiKey, string accountName, int proformaId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/invoices/{2}.xml?api_key={0}", apiKey, accountName, proformaId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/proformas/update">Proformas Update</a> Method
			/// </summary>
			public static void Update(string apiKey, string accountName, int proformaId, ProformaDto inputData)
			{
				Rest_Update(apiKey, accountName, proformaId, inputData.XmlSerializeToString());
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/proformas/list">Proformas List</a> Method
			/// </summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_List(string apiKey, string accountName)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/proformas.xml?api_key={0}", apiKey, accountName);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/proformas/list">Proformas List</a> Method
			/// </summary>
			public static ProformasDto List(string apiKey, string accountName)
			{
				HttpResponseInfo result = Rest_List(apiKey, accountName);
			    return result.Text.DeserializeXml<ProformasDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/proformas/change-state">Proformas ChangeState</a> Method
			/// </summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_ChangeState(string apiKey, string accountName, int proformaId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/proformas/{2}/change-state.xml?api_key={0}", apiKey, accountName, proformaId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/proformas/change-state">Proformas ChangeState</a> Method
			/// </summary>
			public static ProformaChangeStateDto ChangeState(string apiKey, string accountName, int proformaId, ProformaChangeStateDto inputData)
			{
				HttpResponseInfo result = Rest_ChangeState(apiKey, accountName, proformaId, inputData.XmlSerializeToString());
			    return result.Text.DeserializeXml<ProformaChangeStateDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/proformas/email">Proformas EmailInvoice</a> Method
			/// </summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_EmailInvoice(string apiKey, string accountName, int proformaId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/proformas/{2}/email-document.xml?api_key={0}", apiKey, accountName, proformaId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/proformas/email">Proformas EmailInvoice</a> Method
			/// </summary>
			public static void EmailInvoice(string apiKey, string accountName, int proformaId, EmailMessageDto inputData)
			{
				Rest_EmailInvoice(apiKey, accountName, proformaId, inputData.XmlSerializeToString());
			}

	}
}
}