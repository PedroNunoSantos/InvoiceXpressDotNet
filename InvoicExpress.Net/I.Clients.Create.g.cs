// This file was automatically generated
// Do not write any custom code here.
// https://invoicexpress.com/api/clients/create
namespace InvoicExpress.Net.I.Clients.Create
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class client {
	    private string nameField;
	    private string languageField;
	    private string codeField;
	    private string emailField;
	    private string addressField;
	    private string cityField;
	    private string postal_codeField;
	    private uint fiscal_idField;
	    private string websiteField;
	    private long phoneField;
	    private long faxField;
	    private clientPreferred_contact preferred_contactField;
	    private string observationsField;
	    private byte send_optionsField;
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
	    public string language {
	        get {
	            return this.languageField;
	        }
	        set {
	            this.languageField = value;
	        }
	    }
	    /// <remarks/>
	    public string code {
	        get {
	            return this.codeField;
	        }
	        set {
	            this.codeField = value;
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
	    public string address {
	        get {
	            return this.addressField;
	        }
	        set {
	            this.addressField = value;
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
	    public string postal_code {
	        get {
	            return this.postal_codeField;
	        }
	        set {
	            this.postal_codeField = value;
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
	    public string website {
	        get {
	            return this.websiteField;
	        }
	        set {
	            this.websiteField = value;
	        }
	    }
	    /// <remarks/>
	    public long phone {
	        get {
	            return this.phoneField;
	        }
	        set {
	            this.phoneField = value;
	        }
	    }
	    /// <remarks/>
	    public long fax {
	        get {
	            return this.faxField;
	        }
	        set {
	            this.faxField = value;
	        }
	    }
	    /// <remarks/>
	    public clientPreferred_contact preferred_contact {
	        get {
	            return this.preferred_contactField;
	        }
	        set {
	            this.preferred_contactField = value;
	        }
	    }
	    /// <remarks/>
	    public string observations {
	        get {
	            return this.observationsField;
	        }
	        set {
	            this.observationsField = value;
	        }
	    }
	    /// <remarks/>
	    public byte send_options {
	        get {
	            return this.send_optionsField;
	        }
	        set {
	            this.send_optionsField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class clientPreferred_contact {
	    private string nameField;
	    private string emailField;
	    private long phoneField;
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
	    public string email {
	        get {
	            return this.emailField;
	        }
	        set {
	            this.emailField = value;
	        }
	    }
	    /// <remarks/>
	    public long phone {
	        get {
	            return this.phoneField;
	        }
	        set {
	            this.phoneField = value;
	        }
	    }
	}
}