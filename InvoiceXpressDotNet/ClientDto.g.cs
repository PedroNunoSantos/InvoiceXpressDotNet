using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
{
	[XmlRoot("client"), XmlType(AnonymousType=true)]
	public partial class ClientDto : Dto
	{		
		
		[XmlIgnore]
		public int? Id { get; set; }
		
		[XmlElement("id"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _IdDto
	    {	    
			get { return Id.ToXml<int?>(); }
            set { Id = value.FromXml<int?>(); }
	    }
		
		[XmlElement("code")]
		public string Code { get; set; }
		
		[XmlElement("language")]
		public string Language { get; set; }
		
		[XmlElement("name")]
		public string Name { get; set; }
		
		[XmlElement("email")]
		public string Email { get; set; }
		
		[XmlElement("address")]
		public string Address { get; set; }
		
		[XmlElement("city")]
		public string City { get; set; }
		
		[XmlElement("postal_code")]
		public string PostalCode { get; set; }
		
		[XmlElement("fiscal_id")]
		public string FiscalId { get; set; }
		
		[XmlElement("website")]
		public string Website { get; set; }
		
		[XmlElement("country")]
		public string Country { get; set; }
		
		[XmlElement("phone")]
		public string Phone { get; set; }
		
		[XmlElement("fax")]
		public string Fax { get; set; }
		
		[XmlElement("preferred_contact")]
		public PreferredContactDto PreferredContact { get; set; }
		
		[XmlElement("observations")]
		public string Observations { get; set; }
		
		[XmlElement("open_account_link")]
		public string OpenAccountLink { get; set; }
		
		[XmlElement("send_options")]
		public string SendOptions { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<ClientDto>();
        }
		*/
	}
}
