// This file was automatically generated
// Do not write any custom code here.
// https://invoicexpress.com/api/invoices/partial-payment
namespace InvoicExpress.Net.I.Invoices.PartialPayment
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class partial_payment {
	    private string payment_mechanismField;
	    private string noteField;
	    private string serieField;
	    private string amountField;
	    private string payment_dateField;
	    /// <remarks/>
	    public string payment_mechanism {
	        get {
	            return this.payment_mechanismField;
	        }
	        set {
	            this.payment_mechanismField = value;
	        }
	    }
	    /// <remarks/>
	    public string note {
	        get {
	            return this.noteField;
	        }
	        set {
	            this.noteField = value;
	        }
	    }
	    /// <remarks/>
	    public string serie {
	        get {
	            return this.serieField;
	        }
	        set {
	            this.serieField = value;
	        }
	    }
	    /// <remarks/>
	    public string amount {
	        get {
	            return this.amountField;
	        }
	        set {
	            this.amountField = value;
	        }
	    }
	    /// <remarks/>
	    public string payment_date {
	        get {
	            return this.payment_dateField;
	        }
	        set {
	            this.payment_dateField = value;
	        }
	    }
	}
}