// This file was automatically generated
// Do not write any custom code here.
// https://invoicexpress.com/api/simplified-invoices/create
namespace InvoicExpress.Net.I.SimplifiedInvoices.Create
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class simplified_invoice {
	    private string dateField;
	    private string due_dateField;
	    private string referenceField;
	    private string observationsField;
	    private decimal retentionField;
	    private string tax_exemptionField;
	    private string sequence_idField;
	    private string manual_sequence_numberField;
	    private simplified_invoiceClient clientField;
	    private simplified_invoiceItems itemsField;
	    /// <remarks/>
	    public string date {
	        get {
	            return this.dateField;
	        }
	        set {
	            this.dateField = value;
	        }
	    }
	    /// <remarks/>
	    public string due_date {
	        get {
	            return this.due_dateField;
	        }
	        set {
	            this.due_dateField = value;
	        }
	    }
	    /// <remarks/>
	    public string reference {
	        get {
	            return this.referenceField;
	        }
	        set {
	            this.referenceField = value;
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
	    public decimal retention {
	        get {
	            return this.retentionField;
	        }
	        set {
	            this.retentionField = value;
	        }
	    }
	    /// <remarks/>
	    public string tax_exemption {
	        get {
	            return this.tax_exemptionField;
	        }
	        set {
	            this.tax_exemptionField = value;
	        }
	    }
	    /// <remarks/>
	    public string sequence_id {
	        get {
	            return this.sequence_idField;
	        }
	        set {
	            this.sequence_idField = value;
	        }
	    }
	    /// <remarks/>
	    public string manual_sequence_number {
	        get {
	            return this.manual_sequence_numberField;
	        }
	        set {
	            this.manual_sequence_numberField = value;
	        }
	    }
	    /// <remarks/>
	    public simplified_invoiceClient client {
	        get {
	            return this.clientField;
	        }
	        set {
	            this.clientField = value;
	        }
	    }
	    /// <remarks/>
	    public simplified_invoiceItems items {
	        get {
	            return this.itemsField;
	        }
	        set {
	            this.itemsField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class simplified_invoiceClient {
	    private string idField;
	    private string nameField;
	    private string codeField;
	    private string emailField;
	    private string addressField;
	    private string cityField;
	    private string postal_codeField;
	    private string countryField;
	    private uint fiscal_idField;
	    private string websiteField;
	    private long phoneField;
	    private long faxField;
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
	    public string country {
	        get {
	            return this.countryField;
	        }
	        set {
	            this.countryField = value;
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
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class simplified_invoiceItems {
	    private simplified_invoiceItemsItem[] itemField;
	    private string typeField;
	    /// <remarks/>
	    [System.Xml.Serialization.XmlElementAttribute("item")]
	    public simplified_invoiceItemsItem[] item {
	        get {
	            return this.itemField;
	        }
	        set {
	            this.itemField = value;
	        }
	    }
	    /// <remarks/>
	    [System.Xml.Serialization.XmlAttributeAttribute()]
	    public string type {
	        get {
	            return this.typeField;
	        }
	        set {
	            this.typeField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class simplified_invoiceItemsItem {
	    private string nameField;
	    private string descriptionField;
	    private decimal unit_priceField;
	    private decimal quantityField;
	    private simplified_invoiceItemsItemTax taxField;
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
	    public string description {
	        get {
	            return this.descriptionField;
	        }
	        set {
	            this.descriptionField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal unit_price {
	        get {
	            return this.unit_priceField;
	        }
	        set {
	            this.unit_priceField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal quantity {
	        get {
	            return this.quantityField;
	        }
	        set {
	            this.quantityField = value;
	        }
	    }
	    /// <remarks/>
	    public simplified_invoiceItemsItemTax tax {
	        get {
	            return this.taxField;
	        }
	        set {
	            this.taxField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class simplified_invoiceItemsItemTax {
	    private string nameField;
	    /// <remarks/>
	    public string name {
	        get {
	            return this.nameField;
	        }
	        set {
	            this.nameField = value;
	        }
	    }
	}
}