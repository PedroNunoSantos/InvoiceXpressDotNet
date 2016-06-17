// This file was automatically generated
// Do not write any custom code here.
// https://invoicexpress.com/api/credit-notes/email
namespace InvoicExpress.Net.I.CreditNotes.EmailDocument
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class message {
	    private messageClient clientField;
	    private string subjectField;
	    private string bodyField;
	    private string ccField;
	    private string bccField;
	    private byte logoField;
	    /// <remarks/>
	    public messageClient client {
	        get {
	            return this.clientField;
	        }
	        set {
	            this.clientField = value;
	        }
	    }
	    /// <remarks/>
	    public string subject {
	        get {
	            return this.subjectField;
	        }
	        set {
	            this.subjectField = value;
	        }
	    }
	    /// <remarks/>
	    public string body {
	        get {
	            return this.bodyField;
	        }
	        set {
	            this.bodyField = value;
	        }
	    }
	    /// <remarks/>
	    public string cc {
	        get {
	            return this.ccField;
	        }
	        set {
	            this.ccField = value;
	        }
	    }
	    /// <remarks/>
	    public string bcc {
	        get {
	            return this.bccField;
	        }
	        set {
	            this.bccField = value;
	        }
	    }
	    /// <remarks/>
	    public byte logo {
	        get {
	            return this.logoField;
	        }
	        set {
	            this.logoField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class messageClient {
	    private string emailField;
	    private byte saveField;
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
	    public byte save {
	        get {
	            return this.saveField;
	        }
	        set {
	            this.saveField = value;
	        }
	    }
	}
}