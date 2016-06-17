// This file was automatically generated
// Do not write any custom code here.
// https://invoicexpress.com/api/accounts/update
namespace InvoicExpress.Net.I.Accounts.Update
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class account {
	    private string organization_nameField;
	    private uint fiscal_idField;
	    private string addressField;
	    private string postal_codeField;
	    private string cityField;
	    private string emailField;
	    /// <remarks/>
	    public string organization_name {
	        get {
	            return this.organization_nameField;
	        }
	        set {
	            this.organization_nameField = value;
	        }
	    }
	    /// <remarks/>
	    public uint fiscal_id {
	        get {
	            return this.fiscal_idField;
	        }
	        set {
	            this.fiscal_idField = value;
	        }
	    }
	    /// <remarks/>
	    public string address {
	        get {
	            return this.addressField;
	        }
	        set {
	            this.addressField = value;
	        }
	    }
	    /// <remarks/>
	    public string postal_code {
	        get {
	            return this.postal_codeField;
	        }
	        set {
	            this.postal_codeField = value;
	        }
	    }
	    /// <remarks/>
	    public string city {
	        get {
	            return this.cityField;
	        }
	        set {
	            this.cityField = value;
	        }
	    }
	    /// <remarks/>
	    public string email {
	        get {
	            return this.emailField;
	        }
	        set {
	            this.emailField = value;
	        }
	    }
	}
}