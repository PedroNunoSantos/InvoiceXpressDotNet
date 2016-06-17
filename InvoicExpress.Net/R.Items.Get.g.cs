// This file was automatically generated
// Do not write any custom code here.
// https://invoicexpress.com/api/items/get
namespace InvoicExpress.Net.R.Items.Get
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class item {
	    private string idField;
	    private string nameField;
	    private string descriptionField;
	    private decimal unit_priceField;
	    private string unitField;
	    private itemTax taxField;
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
	    public itemTax tax {
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
	public partial class itemTax {
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