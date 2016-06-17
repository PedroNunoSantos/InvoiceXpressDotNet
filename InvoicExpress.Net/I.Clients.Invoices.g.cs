// This file was automatically generated
// Do not write any custom code here.
// https://invoicexpress.com/api/clients/list-invoice
namespace InvoicExpress.Net.I.Clients.Invoices
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class filter {
	    private filterStatus statusField;
	    private filterBy_type by_typeField;
	    private filterArchived archivedField;
	    /// <remarks/>
	    public filterStatus status {
	        get {
	            return this.statusField;
	        }
	        set {
	            this.statusField = value;
	        }
	    }
	    /// <remarks/>
	    public filterBy_type by_type {
	        get {
	            return this.by_typeField;
	        }
	        set {
	            this.by_typeField = value;
	        }
	    }
	    /// <remarks/>
	    public filterArchived archived {
	        get {
	            return this.archivedField;
	        }
	        set {
	            this.archivedField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class filterStatus {
	    private string[] optionField;
	    private string typeField;
	    /// <remarks/>
	    [System.Xml.Serialization.XmlElementAttribute("option")]
	    public string[] option {
	        get {
	            return this.optionField;
	        }
	        set {
	            this.optionField = value;
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
	public partial class filterBy_type {
	    private string[] optionField;
	    private string typeField;
	    /// <remarks/>
	    [System.Xml.Serialization.XmlElementAttribute("option")]
	    public string[] option {
	        get {
	            return this.optionField;
	        }
	        set {
	            this.optionField = value;
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
	public partial class filterArchived {
	    private string[] optionField;
	    private string typeField;
	    /// <remarks/>
	    [System.Xml.Serialization.XmlElementAttribute("option")]
	    public string[] option {
	        get {
	            return this.optionField;
	        }
	        set {
	            this.optionField = value;
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
}