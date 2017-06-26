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
		/// InvoiceXpress <a href="https://invoicexpress.com/api/accounts">Accounts</a> module
		/// </summary>
		public static partial class Accounts
		{

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/accounts/create">Accounts Create</a> Method
			/// </summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Create(string apiKey, string inputData)
			{
				string url = string.Format("https://www.app.invoicexpress.com/api/accounts/create.xml?api_key={0}", apiKey);
				var result = url.HttpPost(inputData);
				if ((int) result.StatusCode != 201)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)201)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/accounts/create">Accounts Create</a> Method
			/// </summary>
			public static AccountDto Create(string apiKey, AccountDto inputData)
			{
				HttpResponseInfo result = Rest_Create(apiKey, inputData.XmlSerializeToString());
			    return result.Text.DeserializeXml<AccountDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/accounts/get">Accounts Get</a> Method
			/// </summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Get(string apiKey, string accountName, string accountId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/api/accounts/{2}/get.xml?api_key={0}", apiKey, accountName, accountId);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/accounts/get">Accounts Get</a> Method
			/// </summary>
			public static AccountDto Get(string apiKey, string accountName, string accountId)
			{
				HttpResponseInfo result = Rest_Get(apiKey, accountName, accountId);
			    return result.Text.DeserializeXml<AccountDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/accounts/stats">Accounts Stats</a> Method
			/// </summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Stats(string accountName, string accountId, string apiKey)
			{
				string url = string.Format("https://{0}.app.invoicexpress.com/api/accounts/{1}/stats.xml?api_key={2}", accountName, accountId, apiKey);
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/accounts/stats">Accounts Stats</a> Method
			/// </summary>
			public static AccountStatsDto Stats(string accountName, string accountId, string apiKey)
			{
				HttpResponseInfo result = Rest_Stats(accountName, accountId, apiKey);
			    return result.Text.DeserializeXml<AccountStatsDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/accounts/suspend">Accounts Suspend</a> Method
			/// </summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Suspend(string apiKey, string accountName, string accountId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/api/accounts/{2}/suspend.xml?api_key={0}", apiKey, accountName, accountId);
				var result = url.HttpPut();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/accounts/suspend">Accounts Suspend</a> Method
			/// </summary>
			public static void Suspend(string apiKey, string accountName, string accountId)
			{
				Rest_Suspend(apiKey, accountName, accountId);
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/accounts/activate">Accounts Activate</a> Method
			/// </summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Activate(string apiKey, string accountName, string accountId)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/api/accounts/{2}/activate.xml?api_key={0}", apiKey, accountName, accountId);
				var result = url.HttpPut();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/accounts/activate">Accounts Activate</a> Method
			/// </summary>
			public static void Activate(string apiKey, string accountName, string accountId)
			{
				Rest_Activate(apiKey, accountName, accountId);
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/accounts/update">Accounts Update</a> Method
			/// </summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Update(string apiKey, string accountName, string accountId, string inputData)
			{
				string url = string.Format("https://{1}.app.invoicexpress.com/api/accounts/{2}/update.xml?api_key={0}", apiKey, accountName, accountId);
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/accounts/update">Accounts Update</a> Method
			/// </summary>
			public static void Update(string apiKey, string accountName, string accountId, AccountDto inputData)
			{
				Rest_Update(apiKey, accountName, accountId, inputData.XmlSerializeToString());
			}

	}
}
}