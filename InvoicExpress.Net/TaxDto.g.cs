using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("tax")]
	[XmlType(AnonymousType=true)]
	public partial class TaxDto
	{		
		[XmlElement("id")]
		public string Id { get; set; }
		
		[XmlElement("name")]
		public string Name { get; set; }
		
		[XmlElement("value")]
		public string Value { get; set; }
		
		[XmlElement("region")]
		public string Region { get; set; }
		
		[XmlElement("default_tax")]
		public string DefaultTax { get; set; }
	}
}
