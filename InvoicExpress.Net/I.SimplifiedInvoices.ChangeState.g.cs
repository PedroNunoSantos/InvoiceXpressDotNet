// This file was automatically generated
// Do not write any custom code here.
// https://invoicexpress.com/api/simplified-invoices/change-state
namespace InvoicExpress.Net.I.SimplifiedInvoices.ChangeState
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class simplified_invoice {
	    private string stateField;
	    private string messageField;
	    /// <remarks/>
	    public string state {
	        get {
	            return this.stateField;
	        }
	        set {
	            this.stateField = value;
	        }
	    }
	    /// <remarks/>
	    public string message {
	        get {
	            return this.messageField;
	        }
	        set {
	            this.messageField = value;
	        }
	    }
	}
}