using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("item")]
	[XmlType(AnonymousType=true)]
	public partial class ItemDto
	{		
		[XmlElement("name")]
		public string Name { get; set; }
		
		[XmlElement("description")]
		public string Description { get; set; }
		
		[XmlElement("unit_price")]
		public string UnitPrice { get; set; }
		
		[XmlElement("unit")]
		public string Unit { get; set; }
		
		[XmlElement("tax")]
		public TaxDto Tax { get; set; }
	}
}
