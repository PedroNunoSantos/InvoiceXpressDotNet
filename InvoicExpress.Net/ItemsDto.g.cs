using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("items")]
	[XmlType(AnonymousType=true)]
	public partial class ItemsDto
	{		
		[XmlElement("item")]
		public ItemDto[] ItemsArray { get; set; }
	}
}
