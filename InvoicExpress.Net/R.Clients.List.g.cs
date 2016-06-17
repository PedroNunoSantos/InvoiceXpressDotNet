// This file was automatically generated
// Do not write any custom code here.
// https://invoicexpress.com/api/clients/list
namespace InvoicExpress.Net.R.Clients.List
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class clients {
	    private clientsClient[] clientField;
	    private byte current_pageField;
	    private byte total_pagesField;
	    private byte total_entriesField;
	    private byte per_pageField;
	    /// <remarks/>
	    [System.Xml.Serialization.XmlElementAttribute("client")]
	    public clientsClient[] client {
	        get {
	            return this.clientField;
	        }
	        set {
	            this.clientField = value;
	        }
	    }
	    /// <remarks/>
	    public byte current_page {
	        get {
	            return this.current_pageField;
	        }
	        set {
	            this.current_pageField = value;
	        }
	    }
	    /// <remarks/>
	    public byte total_pages {
	        get {
	            return this.total_pagesField;
	        }
	        set {
	            this.total_pagesField = value;
	        }
	    }
	    /// <remarks/>
	    public byte total_entries {
	        get {
	            return this.total_entriesField;
	        }
	        set {
	            this.total_entriesField = value;
	        }
	    }
	    /// <remarks/>
	    public byte per_page {
	        get {
	            return this.per_pageField;
	        }
	        set {
	            this.per_pageField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class clientsClient {
	    private string idField;
	    private string nameField;
	    private string codeField;
	    private string emailField;
	    private string languageField;
	    private string addressField;
	    private string cityField;
	    private string postal_codeField;
	    private uint fiscal_idField;
	    private string websiteField;
	    private string countryField;
	    private uint phoneField;
	    private uint faxField;
	    private clientsClientPreferred_contact preferred_contactField;
	    private string observationsField;
	    private byte send_optionsField;
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
	    public string language {
	        get {
	            return this.languageField;
	        }
	        set {
	            this.languageField = value;
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
	    [System.Xml.Serialization.XmlElementAttribute(DataType="gYearMonth")]
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
	    public string country {
	        get {
	            return this.countryField;
	        }
	        set {
	            this.countryField = value;
	        }
	    }
	    /// <remarks/>
	    public uint phone {
	        get {
	            return this.phoneField;
	        }
	        set {
	            this.phoneField = value;
	        }
	    }
	    /// <remarks/>
	    public uint fax {
	        get {
	            return this.faxField;
	        }
	        set {
	            this.faxField = value;
	        }
	    }
	    /// <remarks/>
	    public clientsClientPreferred_contact preferred_contact {
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
	public partial class clientsClientPreferred_contact {
	    private string nameField;
	    private string emailField;
	    private string phoneField;
	    private string mobileField;
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
	    public string phone {
	        get {
	            return this.phoneField;
	        }
	        set {
	            this.phoneField = value;
	        }
	    }
	    /// <remarks/>
	    public string mobile {
	        get {
	            return this.mobileField;
	        }
	        set {
	            this.mobileField = value;
	        }
	    }
	}
}