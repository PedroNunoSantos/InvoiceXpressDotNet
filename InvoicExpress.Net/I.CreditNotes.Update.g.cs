// This file was automatically generated
// Do not write any custom code here.
// https://invoicexpress.com/api/simplified-invoices/update
namespace InvoicExpress.Net.I.CreditNotes.Update
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class credit_note {
	    private string dateField;
	    private string due_dateField;
	    private string referenceField;
	    private string observationsField;
	    private decimal retentionField;
	    private string tax_exemptionField;
	    private uint sequence_idField;
	    private uint manual_sequence_numberField;
	    private credit_noteClient clientField;
	    private credit_noteItems itemsField;
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
	    public uint sequence_id {
	        get {
	            return this.sequence_idField;
	        }
	        set {
	            this.sequence_idField = value;
	        }
	    }
	    /// <remarks/>
	    public uint manual_sequence_number {
	        get {
	            return this.manual_sequence_numberField;
	        }
	        set {
	            this.manual_sequence_numberField = value;
	        }
	    }
	    /// <remarks/>
	    public credit_noteClient client {
	        get {
	            return this.clientField;
	        }
	        set {
	            this.clientField = value;
	        }
	    }
	    /// <remarks/>
	    public credit_noteItems items {
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
	public partial class credit_noteClient {
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
	    private string observationsField;
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
	    /// <remarks/>
	    public string observations {
	        get {
	            return this.observationsField;
	        }
	        set {
	            this.observationsField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class credit_noteItems {
	    private credit_noteItemsItem[] itemField;
	    private string typeField;
	    /// <remarks/>
	    [System.Xml.Serialization.XmlElementAttribute("item")]
	    public credit_noteItemsItem[] item {
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
	public partial class credit_noteItemsItem {
	    private object[] itemsField;
	    private ItemsChoiceType[] itemsElementNameField;
	    /// <remarks/>
	    [System.Xml.Serialization.XmlElementAttribute("description", typeof(string))]
	    [System.Xml.Serialization.XmlElementAttribute("discount", typeof(decimal))]
	    [System.Xml.Serialization.XmlElementAttribute("name", typeof(string))]
	    [System.Xml.Serialization.XmlElementAttribute("quantity", typeof(decimal))]
	    [System.Xml.Serialization.XmlElementAttribute("tax", typeof(credit_noteItemsItemTax))]
	    [System.Xml.Serialization.XmlElementAttribute("unit", typeof(string))]
	    [System.Xml.Serialization.XmlElementAttribute("unit_price", typeof(decimal))]
	    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
	    public object[] Items {
	        get {
	            return this.itemsField;
	        }
	        set {
	            this.itemsField = value;
	        }
	    }
	    /// <remarks/>
	    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
	    [System.Xml.Serialization.XmlIgnoreAttribute()]
	    public ItemsChoiceType[] ItemsElementName {
	        get {
	            return this.itemsElementNameField;
	        }
	        set {
	            this.itemsElementNameField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class credit_noteItemsItemTax {
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
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
	public enum ItemsChoiceType {
	    /// <remarks/>
	    description,
	    /// <remarks/>
	    discount,
	    /// <remarks/>
	    name,
	    /// <remarks/>
	    quantity,
	    /// <remarks/>
	    tax,
	    /// <remarks/>
	    unit,
	    /// <remarks/>
	    unit_price,
	}
}