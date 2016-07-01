// Connector API InvoiceXpressDotNet developed by EventKey,Lda http://www.eventkey.pt
using System;
using System.Net;
namespace InvoiceXpressDotNet
{
	public static partial class InvoiceExpress
    {
		public static class Users
		{

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/users/login">Users Login</a> Method
			/// </summary>
			public static string Login(string inputData)
			{
				string url = string.Format("https://www.app.invoicexpress.com/login.xml");
				var result = url.HttpPost(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/users/login">Users Login</a> Method
			/// </summary>
			public static UserAccountDto LoginTyped(CredentialsDto inputData)
			{
				return Login(inputData.XmlSerializeToString()).DeserializeXml<UserAccountDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/users/accounts">Users Accounts</a> Method
			/// </summary>
			public static string Accounts()
			{
				string url = string.Format("https://www.app.invoicexpress.com/users/accounts.xml?api_key?api_key={apiKey}");
				var result = url.HttpGet();
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/users/accounts">Users Accounts</a> Method
			/// </summary>
			public static UserAccountsDto AccountsTyped()
			{
				return Accounts().DeserializeXml<UserAccountsDto>();
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/users/change-account">Users ChangeAccount</a> Method
			/// </summary>
			public static string ChangeAccount(string inputData)
			{
				string url = string.Format("https://{accountName}.app.invoicexpress.com/users/change_account.xml?api_key?api_key={apiKey}");
				var result = url.HttpPut(inputData);
				if ((int) result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						, new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceXpress <a href="https://invoicexpress.com/api/users/change-account">Users ChangeAccount</a> Method
			/// </summary>
			public static void ChangeAccountTyped(ChangeAccountToDto inputData)
			{
				ChangeAccount(inputData.XmlSerializeToString());
			}

	}
}
}