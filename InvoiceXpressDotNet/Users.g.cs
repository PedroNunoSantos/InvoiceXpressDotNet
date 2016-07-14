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
		/// InvoiceXpress <a href="https://invoicexpress.com/api/users">Users</a> module
		/// </summary>
		public static partial class Users
		{

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/users/login">Users Login</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Login(string inputData)
			{
				string url = string.Format("https://www.app.invoicexpress.com/login.xml");
				var result = url.HttpPost(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/users/login">Users Login</a> Method
			/// </summary>
			public static UserAccountDto Login(CredentialsDto inputData)
			{
				HttpResponseInfo result = Rest_Login(inputData.XmlSerializeToString());
			    return result.Text.DeserializeXml<UserAccountDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/users/accounts">Users Accounts</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_Accounts()
			{
				string url = string.Format("https://www.app.invoicexpress.com/users/accounts.xml?api_key?api_key={apiKey}");
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/users/accounts">Users Accounts</a> Method
			/// </summary>
			public static UserAccountsDto Accounts()
			{
				HttpResponseInfo result = Rest_Accounts();
			    return result.Text.DeserializeXml<UserAccountsDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/users/change-account">Users ChangeAccount</a> Method
			/// </summary>
			[EditorBrowsableAttribute(EditorBrowsableState.Never)]
			public static HttpResponseInfo Rest_ChangeAccount(string inputData)
			{
				string url = string.Format("https://{accountName}.app.invoicexpress.com/users/change_account.xml?api_key?api_key={apiKey}");
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/users/change-account">Users ChangeAccount</a> Method
			/// </summary>
			public static void ChangeAccount(ChangeAccountToDto inputData)
			{
				Rest_ChangeAccount(inputData.XmlSerializeToString());
			}

	}
}
}