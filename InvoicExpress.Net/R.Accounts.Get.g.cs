// This file was automatically generated
// Do not write any custom code here.
// https://invoicexpress.com/api/accounts/get
namespace InvoicExpress.Net.R.Accounts.Get
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class account {
	    private string organization_nameField;
	    private uint fiscal_idField;
	    private string emailField;
	    private string stateField;
	    private accountAt_configured at_configuredField;
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
	    public string email {
	        get {
	            return this.emailField;
	        }
	        set {
	            this.emailField = value;
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
	    public accountAt_configured at_configured {
	        get {
	            return this.at_configuredField;
	        }
	        set {
	            this.at_configuredField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class accountAt_configured {
	    private string typeField;
	    private bool valueField;
	    /// <remarks/>
	    [System.Xml.Serialization.XmlAttributeAttribute()]
	    public string Type {
	        get {
	            return this.typeField;
	        }
	        set {
	            this.typeField = value;
	        }
	    }
	    /// <remarks/>
	    [System.Xml.Serialization.XmlTextAttribute()]
	    public bool Value {
	        get {
	            return this.valueField;
	        }
	        set {
	            this.valueField = value;
	        }
	    }
	}
}