// This file was automatically generated
// Do not write any custom code here.
// https://invoicexpress.com/api/clients/list
namespace InvoicExpress.Net.R.Items.List
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class items {
	    private itemsItem[] itemField;
	    /// <remarks/>
	    [System.Xml.Serialization.XmlElementAttribute("item")]
	    public itemsItem[] item {
	        get {
	            return this.itemField;
	        }
	        set {
	            this.itemField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class itemsItem {
	    private string idField;
	    private string nameField;
	    private string descriptionField;
	    private decimal unit_priceField;
	    private string unitField;
	    private itemsItemTax taxField;
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
	    public itemsItemTax tax {
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
	public partial class itemsItemTax {
	    private string nameField;
	    private decimal valueField;
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