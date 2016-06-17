// This file was automatically generated
// Do not write any custom code here.
// https://invoicexpress.com/api/accounts/stats
namespace InvoicExpress.Net.R.Accounts.Stats
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class account_stats {
	    private string planField;
	    private account_statsExpires_at expires_atField;
	    private account_statsDocuments documentsField;
	    private account_statsUsers usersField;
	    /// <remarks/>
	    public string plan {
	        get {
	            return this.planField;
	        }
	        set {
	            this.planField = value;
	        }
	    }
	    /// <remarks/>
	    public account_statsExpires_at expires_at {
	        get {
	            return this.expires_atField;
	        }
	        set {
	            this.expires_atField = value;
	        }
	    }
	    /// <remarks/>
	    public account_statsDocuments documents {
	        get {
	            return this.documentsField;
	        }
	        set {
	            this.documentsField = value;
	        }
	    }
	    /// <remarks/>
	    public account_statsUsers users {
	        get {
	            return this.usersField;
	        }
	        set {
	            this.usersField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class account_statsExpires_at {
	    private string typeField;
	    private System.DateTime valueField;
	    /// <remarks/>
	    [System.Xml.Serialization.XmlAttributeAttribute()]
	    public string Type {
	        get {
	            return this.typeField;
	        }
	        set {
	            this.typeField = value;
	        }
	    }
	    /// <remarks/>
	    [System.Xml.Serialization.XmlTextAttribute(DataType="date")]
	    public System.DateTime Value {
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
	public partial class account_statsDocuments {
	    private account_statsDocumentsUsed_documents used_documentsField;
	    private account_statsDocumentsAvailable_documents available_documentsField;
	    private account_statsDocumentsUsed_api_documents used_api_documentsField;
	    private account_statsDocumentsAvailable_api_documents available_api_documentsField;
	    private account_statsDocumentsUsed_web_documents used_web_documentsField;
	    private account_statsDocumentsAvailable_web_documents available_web_documentsField;
	    /// <remarks/>
	    public account_statsDocumentsUsed_documents used_documents {
	        get {
	            return this.used_documentsField;
	        }
	        set {
	            this.used_documentsField = value;
	        }
	    }
	    /// <remarks/>
	    public account_statsDocumentsAvailable_documents available_documents {
	        get {
	            return this.available_documentsField;
	        }
	        set {
	            this.available_documentsField = value;
	        }
	    }
	    /// <remarks/>
	    public account_statsDocumentsUsed_api_documents used_api_documents {
	        get {
	            return this.used_api_documentsField;
	        }
	        set {
	            this.used_api_documentsField = value;
	        }
	    }
	    /// <remarks/>
	    public account_statsDocumentsAvailable_api_documents available_api_documents {
	        get {
	            return this.available_api_documentsField;
	        }
	        set {
	            this.available_api_documentsField = value;
	        }
	    }
	    /// <remarks/>
	    public account_statsDocumentsUsed_web_documents used_web_documents {
	        get {
	            return this.used_web_documentsField;
	        }
	        set {
	            this.used_web_documentsField = value;
	        }
	    }
	    /// <remarks/>
	    public account_statsDocumentsAvailable_web_documents available_web_documents {
	        get {
	            return this.available_web_documentsField;
	        }
	        set {
	            this.available_web_documentsField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class account_statsDocumentsUsed_documents {
	    private string typeField;
	    private byte valueField;
	    /// <remarks/>
	    [System.Xml.Serialization.XmlAttributeAttribute()]
	    public string Type {
	        get {
	            return this.typeField;
	        }
	        set {
	            this.typeField = value;
	        }
	    }
	    /// <remarks/>
	    [System.Xml.Serialization.XmlTextAttribute()]
	    public byte Value {
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
	public partial class account_statsDocumentsAvailable_documents {
	    private string typeField;
	    private ushort valueField;
	    /// <remarks/>
	    [System.Xml.Serialization.XmlAttributeAttribute()]
	    public string Type {
	        get {
	            return this.typeField;
	        }
	        set {
	            this.typeField = value;
	        }
	    }
	    /// <remarks/>
	    [System.Xml.Serialization.XmlTextAttribute()]
	    public ushort Value {
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
	public partial class account_statsDocumentsUsed_api_documents {
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
	public partial class account_statsDocumentsAvailable_api_documents {
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
	public partial class account_statsDocumentsUsed_web_documents {
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
	public partial class account_statsDocumentsAvailable_web_documents {
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
	public partial class account_statsUsers {
	    private account_statsUsersUsed_users used_usersField;
	    private account_statsUsersAvailable_users available_usersField;
	    /// <remarks/>
	    public account_statsUsersUsed_users used_users {
	        get {
	            return this.used_usersField;
	        }
	        set {
	            this.used_usersField = value;
	        }
	    }
	    /// <remarks/>
	    public account_statsUsersAvailable_users available_users {
	        get {
	            return this.available_usersField;
	        }
	        set {
	            this.available_usersField = value;
	        }
	    }
	}
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class account_statsUsersUsed_users {
	    private string typeField;
	    private byte valueField;
	    /// <remarks/>
	    [System.Xml.Serialization.XmlAttributeAttribute()]
	    public string Type {
	        get {
	            return this.typeField;
	        }
	        set {
	            this.typeField = value;
	        }
	    }
	    /// <remarks/>
	    [System.Xml.Serialization.XmlTextAttribute()]
	    public byte Value {
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
	public partial class account_statsUsersAvailable_users {
	    private string typeField;
	    private byte valueField;
	    /// <remarks/>
	    [System.Xml.Serialization.XmlAttributeAttribute()]
	    public string Type {
	        get {
	            return this.typeField;
	        }
	        set {
	            this.typeField = value;
	        }
	    }
	    /// <remarks/>
	    [System.Xml.Serialization.XmlTextAttribute()]
	    public byte Value {
	        get {
	            return this.valueField;
	        }
	        set {
	            this.valueField = value;
	        }
	    }
	}
}