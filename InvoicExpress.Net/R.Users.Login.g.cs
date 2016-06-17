// This file was automatically generated
// Do not write any custom code here.
// https://invoicexpress.com/api/users/login
namespace InvoicExpress.Net.R.Users.Login
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class accounts {
	    private accountsAccount[] accountField;
	    /// <remarks/>
	    [System.Xml.Serialization.XmlElementAttribute("account")]
	    public accountsAccount[] account {
	        get {
	            return this.accountField;
	        }
	        set {
	            this.accountField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class accountsAccount {
	    private string idField;
	    private string nameField;
	    private string urlField;
	    private string api_keyField;
	    private string stateField;
	    private bool blockedField;
	    private accountsAccountRoles rolesField;
	    /// <remarks/>
	    public string id {
	        get {
	            return this.idField;
	        }
	        set {
	            this.idField = value;
	        }
	    }
	    /// <remarks/>
	    public string name {
	        get {
	            return this.nameField;
	        }
	        set {
	            this.nameField = value;
	        }
	    }
	    /// <remarks/>
	    public string url {
	        get {
	            return this.urlField;
	        }
	        set {
	            this.urlField = value;
	        }
	    }
	    /// <remarks/>
	    public string api_key {
	        get {
	            return this.api_keyField;
	        }
	        set {
	            this.api_keyField = value;
	        }
	    }
	    /// <remarks/>
	    public string state {
	        get {
	            return this.stateField;
	        }
	        set {
	            this.stateField = value;
	        }
	    }
	    /// <remarks/>
	    public bool blocked {
	        get {
	            return this.blockedField;
	        }
	        set {
	            this.blockedField = value;
	        }
	    }
	    /// <remarks/>
	    public accountsAccountRoles roles {
	        get {
	            return this.rolesField;
	        }
	        set {
	            this.rolesField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class accountsAccountRoles {
	    private string roleField;
	    /// <remarks/>
	    public string role {
	        get {
	            return this.roleField;
	        }
	        set {
	            this.roleField = value;
	        }
	    }
	}
}