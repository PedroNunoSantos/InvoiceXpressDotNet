// This file was automatically generated
// Do not write any custom code here.
// https://invoicexpress.com/api/invoices/partial-payment
namespace InvoicExpress.Net.R.Invoices.PartialPayment
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class receipt {
	    private receiptID idField;
	    private string statusField;
	    private receiptArchived archivedField;
	    private string typeField;
	    private string sequence_numberField;
	    private string dateField;
	    private string due_dateField;
	    private string observationsField;
	    private receiptRetention retentionField;
	    private string permalinkField;
	    private decimal sumField;
	    private decimal discountField;
	    private decimal before_taxesField;
	    private decimal taxesField;
	    private decimal totalField;
	    private string currencyField;
	    private receiptClient clientField;
	    private receiptMulticurrency multicurrencyField;
	    private receiptEvents eventsField;
	    /// <remarks/>
	    public receiptID id {
	        get {
	            return this.idField;
	        }
	        set {
	            this.idField = value;
	        }
	    }
	    /// <remarks/>
	    public string status {
	        get {
	            return this.statusField;
	        }
	        set {
	            this.statusField = value;
	        }
	    }
	    /// <remarks/>
	    public receiptArchived archived {
	        get {
	            return this.archivedField;
	        }
	        set {
	            this.archivedField = value;
	        }
	    }
	    /// <remarks/>
	    public string type {
	        get {
	            return this.typeField;
	        }
	        set {
	            this.typeField = value;
	        }
	    }
	    /// <remarks/>
	    public string sequence_number {
	        get {
	            return this.sequence_numberField;
	        }
	        set {
	            this.sequence_numberField = value;
	        }
	    }
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
	    public string observations {
	        get {
	            return this.observationsField;
	        }
	        set {
	            this.observationsField = value;
	        }
	    }
	    /// <remarks/>
	    public receiptRetention retention {
	        get {
	            return this.retentionField;
	        }
	        set {
	            this.retentionField = value;
	        }
	    }
	    /// <remarks/>
	    public string permalink {
	        get {
	            return this.permalinkField;
	        }
	        set {
	            this.permalinkField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal sum {
	        get {
	            return this.sumField;
	        }
	        set {
	            this.sumField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal discount {
	        get {
	            return this.discountField;
	        }
	        set {
	            this.discountField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal before_taxes {
	        get {
	            return this.before_taxesField;
	        }
	        set {
	            this.before_taxesField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal taxes {
	        get {
	            return this.taxesField;
	        }
	        set {
	            this.taxesField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal total {
	        get {
	            return this.totalField;
	        }
	        set {
	            this.totalField = value;
	        }
	    }
	    /// <remarks/>
	    public string currency {
	        get {
	            return this.currencyField;
	        }
	        set {
	            this.currencyField = value;
	        }
	    }
	    /// <remarks/>
	    public receiptClient client {
	        get {
	            return this.clientField;
	        }
	        set {
	            this.clientField = value;
	        }
	    }
	    /// <remarks/>
	    public receiptMulticurrency multicurrency {
	        get {
	            return this.multicurrencyField;
	        }
	        set {
	            this.multicurrencyField = value;
	        }
	    }
	    /// <remarks/>
	    public receiptEvents events {
	        get {
	            return this.eventsField;
	        }
	        set {
	            this.eventsField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class receiptID {
	    private string typeField;
	    private uint valueField;
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
	    /// <remarks/>
	    [System.Xml.Serialization.XmlTextAttribute()]
	    public uint Value {
	        get {
	            return this.valueField;
	        }
	        set {
	            this.valueField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class receiptArchived {
	    private string typeField;
	    private bool valueField;
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
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class receiptRetention {
	    private bool nilField;
	    /// <remarks/>
	    [System.Xml.Serialization.XmlAttributeAttribute()]
	    public bool nil {
	        get {
	            return this.nilField;
	        }
	        set {
	            this.nilField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class receiptClient {
	    private receiptClientID idField;
	    private string nameField;
	    private string emailField;
	    private string addressField;
	    private string cityField;
	    private string postal_codeField;
	    private string countryField;
	    /// <remarks/>
	    public receiptClientID id {
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
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class receiptClientID {
	    private string typeField;
	    private uint valueField;
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
	    /// <remarks/>
	    [System.Xml.Serialization.XmlTextAttribute()]
	    public uint Value {
	        get {
	            return this.valueField;
	        }
	        set {
	            this.valueField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class receiptMulticurrency {
	    private decimal rateField;
	    private string currencyField;
	    /// <remarks/>
	    public decimal rate {
	        get {
	            return this.rateField;
	        }
	        set {
	            this.rateField = value;
	        }
	    }
	    /// <remarks/>
	    public string currency {
	        get {
	            return this.currencyField;
	        }
	        set {
	            this.currencyField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class receiptEvents {
	    private receiptEventsEvent[] eventField;
	    private string typeField;
	    /// <remarks/>
	    [System.Xml.Serialization.XmlElementAttribute("event")]
	    public receiptEventsEvent[] @event {
	        get {
	            return this.eventField;
	        }
	        set {
	            this.eventField = value;
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
	public partial class receiptEventsEvent {
	    private string typeField;
	    private string dateField;
	    private string timeField;
	    private string userField;
	    /// <remarks/>
	    public string type {
	        get {
	            return this.typeField;
	        }
	        set {
	            this.typeField = value;
	        }
	    }
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
	    public string time {
	        get {
	            return this.timeField;
	        }
	        set {
	            this.timeField = value;
	        }
	    }
	    /// <remarks/>
	    public string user {
	        get {
	            return this.userField;
	        }
	        set {
	            this.userField = value;
	        }
	    }
	}
}