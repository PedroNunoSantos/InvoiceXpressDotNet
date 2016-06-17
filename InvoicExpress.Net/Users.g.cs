using System;
using System.Net;
namespace InvoicExpress.Net
{
	public static partial class InvoiceExpress
    {
		public static class Users
		{
		        
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/users/login">Users Login</a> Method
			/// </summary>
			public static string Login(string inputData)
			{
				string url = string.Format("https://www.app.invoicexpress.com/login.xml");
				var result = url.HttpPost(inputData);
				if((int)result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						,new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/users/login">Users Login</a> Method
			/// </summary>
			public static R.Users.Login.accounts LoginTyped(I.Users.Login.credentials inputData)
			{
				return Login(inputData.XmlSerializeToString()).DeserializeXml<R.Users.Login.accounts>();
			}
			        
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/users/accounts">Users Accounts</a> Method
			/// </summary>
			public static string Accounts(string inputData)
			{
				string url = string.Format("https://www.app.invoicexpress.com/users/accounts.xml?api_key?api_key={apiKey}");
				var result = url.HttpGet(inputData);
				if((int)result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						,new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/users/accounts">Users Accounts</a> Method
			/// </summary>
			public static R.Users.Accounts.accounts AccountsTyped(I.Users.Accounts.credentials inputData)
			{
				return Accounts(inputData.XmlSerializeToString()).DeserializeXml<R.Users.Accounts.accounts>();
			}
			        
			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/users/change-account">Users ChangeAccount</a> Method
			/// </summary>
			public static string ChangeAccount(string inputData)
			{
				string url = string.Format("https://{accountName}.app.invoicexpress.com/users/change_account.xml?api_key?api_key={apiKey}");
				var result = url.HttpPut(inputData);
				if((int)result.StatusCode != 200)
					throw new System.Exception(string.Format("Invalid HttpStatusCode. Expected {0}", (HttpStatusCode)200)
						,new Exception(result.Text));
				return result.Text;
			}

			/// <summary>
			/// InvoiceExpress <a href="https://invoicexpress.com/api/users/change-account">Users ChangeAccount</a> Method
			/// </summary>
			public static void ChangeAccountTyped(I.Users.ChangeAccount.change_account_to inputData)
			{
				ChangeAccount(inputData.XmlSerializeToString());
			}
				}
	}
}