using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("preferred_contact")]
	[XmlType(AnonymousType=true)]
	public partial class PreferredContactDto
	{		
		[XmlElement("name")]
		public string Name { get; set; }
		
		[XmlElement("email")]
		public string Email { get; set; }
		
		[XmlElement("phone")]
		public string Phone { get; set; }
		
		[XmlElement("mobile")]
		public string Mobile { get; set; }
	}
}
