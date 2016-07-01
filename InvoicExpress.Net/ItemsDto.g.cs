using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoicExpress.Net
{
	[XmlRoot("items"), XmlType(AnonymousType=true)]
	public partial class ItemsDto
	{
	    [XmlAttribute]
		public string type = "array";
		
		[XmlElement("item")]
		public ItemDto[] ItemsArray { get; set; }
	}
}
