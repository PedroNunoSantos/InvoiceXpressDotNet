using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("client")]
	[XmlType(AnonymousType=true)]
	public partial class ClientDto
	{		
		[XmlElement("id")]
		public string Id { get; set; }
		
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
	}
}
