// This file was automatically generated
// Do not write any custom code here.
// https://invoicexpress.com/api/credit-notes/create
namespace InvoicExpress.Net.R.CreditNotes.Create
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class credit_note {
	    private string idField;
	    private string statusField;
	    private bool archivedField;
	    private string typeField;
	    private string sequence_numberField;
	    private string dateField;
	    private string due_dateField;
	    private string referenceField;
	    private string observationsField;
	    private decimal retentionField;
	    private string permalinkField;
	    private credit_noteClient clientField;
	    private string currencyField;
	    private credit_noteItems itemsField;
	    private decimal sumField;
	    private decimal discountField;
	    private decimal before_taxesField;
	    private decimal taxesField;
	    private decimal totalField;
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
	    public string status {
	        get {
	            return this.statusField;
	        }
	        set {
	            this.statusField = value;
	        }
	    }
	    /// <remarks/>
	    public bool archived {
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
	    public string permalink {
	        get {
	            return this.permalinkField;
	        }
	        set {
	            this.permalinkField = value;
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
	    public string currency {
	        get {
	            return this.currencyField;
	        }
	        set {
	            this.currencyField = value;
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
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class credit_noteClient {
	    private string idField;
	    private string nameField;
	    private string codeField;
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
	    private string nameField;
	    private string descriptionField;
	    private decimal unit_priceField;
	    private string unitField;
	    private decimal quantityField;
	    private credit_noteItemsItemTax taxField;
	    private decimal discountField;
	    private decimal subtotalField;
	    private decimal tax_amountField;
	    private decimal discount_amountField;
	    private decimal totalField;
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
	    public string unit {
	        get {
	            return this.unitField;
	        }
	        set {
	            this.unitField = value;
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
	    public credit_noteItemsItemTax tax {
	        get {
	            return this.taxField;
	        }
	        set {
	            this.taxField = value;
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
	    public decimal subtotal {
	        get {
	            return this.subtotalField;
	        }
	        set {
	            this.subtotalField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal tax_amount {
	        get {
	            return this.tax_amountField;
	        }
	        set {
	            this.tax_amountField = value;
	        }
	    }
	    /// <remarks/>
	    public decimal discount_amount {
	        get {
	            return this.discount_amountField;
	        }
	        set {
	            this.discount_amountField = value;
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
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class credit_noteItemsItemTax {
	    private string idField;
	    private string nameField;
	    private decimal valueField;
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
	    public decimal value {
	        get {
	            return this.valueField;
	        }
	        set {
	            this.valueField = value;
	        }
	    }
	}
}