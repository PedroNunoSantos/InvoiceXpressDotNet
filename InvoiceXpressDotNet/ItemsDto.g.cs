using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
{
	[XmlRoot("items"), XmlType(AnonymousType=true)]
	public partial class ItemsDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";
		
		[XmlElement("item")]
		public ItemDto[] Items { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<ItemsDto>();
        }
		*/
	}
}
