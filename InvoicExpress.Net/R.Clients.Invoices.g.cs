// This file was automatically generated
// Do not write any custom code here.
// https://invoicexpress.com/api/clients/list-invoice
namespace InvoicExpress.Net.R.Clients.Invoices
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class invoices {
	    private invoicesResults resultsField;
	    private invoicesInvoice invoiceField;
	    private string typeField;
	    /// <remarks/>
	    public invoicesResults results {
	        get {
	            return this.resultsField;
	        }
	        set {
	            this.resultsField = value;
	        }
	    }
	    /// <remarks/>
	    public invoicesInvoice invoice {
	        get {
	            return this.invoiceField;
	        }
	        set {
	            this.invoiceField = value;
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
	public partial class invoicesResults {
	    private byte current_pageField;
	    private byte entriesField;
	    private byte total_entriesField;
	    private byte total_pagesField;
	    private byte per_pageField;
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
	    public byte entries {
	        get {
	            return this.entriesField;
	        }
	        set {
	            this.entriesField = value;
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
	    public byte total_pages {
	        get {
	            return this.total_pagesField;
	        }
	        set {
	            this.total_pagesField = value;
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
	public partial class invoicesInvoice {
	    private string idField;
	    private string statusField;
	    private string typeField;
	    private string sequence_numberField;
	    private string dateField;
	    private string due_dateField;
	    private uint referenceField;
	    private string observationsField;
	    private decimal retentionField;
	    private invoicesInvoiceClient clientField;
	    private string currencyField;
	    private invoicesInvoiceItem[] itemsField;
	    private decimal sumField;
	    private decimal discountField;
	    private decimal before_taxesField;
	    private decimal taxesField;
	    private decimal totalField;
	    private invoicesInvoiceMb_reference mb_referenceField;
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
	    public uint reference {
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
	    public invoicesInvoiceClient client {
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
	    [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
	    public invoicesInvoiceItem[] items {
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
	    /// <remarks/>
	    public invoicesInvoiceMb_reference mb_reference {
	        get {
	            return this.mb_referenceField;
	        }
	        set {
	            this.mb_referenceField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class invoicesInvoiceClient {
	    private string idField;
	    private string nameField;
	    private string emailField;
	    private string addressField;
	    private string cityField;
	    private string postal_codeField;
	    private string countryField;
	    private uint fiscal_idField;
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
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class invoicesInvoiceItem {
	    private string nameField;
	    private string descriptionField;
	    private decimal unit_priceField;
	    private string unitField;
	    private decimal quantityField;
	    private invoicesInvoiceItemTax taxField;
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
	    public invoicesInvoiceItemTax tax {
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
	public partial class invoicesInvoiceItemTax {
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
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class invoicesInvoiceMb_reference {
	    private uint referenceField;
	    private ushort entityField;
	    private decimal valueField;
	    /// <remarks/>
	    public uint reference {
	        get {
	            return this.referenceField;
	        }
	        set {
	            this.referenceField = value;
	        }
	    }
	    /// <remarks/>
	    public ushort entity {
	        get {
	            return this.entityField;
	        }
	        set {
	            this.entityField = value;
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