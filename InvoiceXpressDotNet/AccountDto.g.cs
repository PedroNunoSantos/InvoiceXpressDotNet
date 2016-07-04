using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
{
	[XmlRoot("account"), XmlType(AnonymousType=true)]
	public partial class AccountDto : Dto
	{		
		
		[XmlElement("first_name")]
		public string FirstName { get; set; }
		
		[XmlElement("last_name")]
		public string LastName { get; set; }
		
		[XmlElement("organization_name")]
		public string OrganizationName { get; set; }
		
		[XmlElement("phone")]
		public string Phone { get; set; }
		
		[XmlElement("email")]
		public string Email { get; set; }
		
		[XmlElement("password")]
		public string Password { get; set; }
		
		[XmlElement("fiscal_id")]
		public string FiscalId { get; set; }
		
		[XmlElement("tax_country")]
		public string TaxCountry { get; set; }
		
		[XmlElement("language")]
		public string Language { get; set; }
		
		[XmlElement("terms")]
		public string Terms { get; set; }
		
		[XmlIgnore]
		public int? Id { get; set; }
		
		[XmlElement("id"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _IdDto
	    {	    
			get { return Id.ToXml<int?>(); }
            set { Id = value.FromXml<int?>(); }
	    }
		
		[XmlElement("name")]
		public string Name { get; set; }
		
		[XmlElement("url")]
		public string Url { get; set; }
		
		[XmlElement("api_key")]
		public string ApiKey { get; set; }
		
		[XmlElement("state")]
		public string State { get; set; }
		
		[XmlElement("at_configured ")]
		public string AtConfigured { get; set; }
		
		[XmlElement("address")]
		public string Address { get; set; }
		
		[XmlElement("postal_code")]
		public string PostalCode { get; set; }
		
		[XmlElement("city")]
		public string City { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<AccountDto>();
        }
		*/
	}
}
