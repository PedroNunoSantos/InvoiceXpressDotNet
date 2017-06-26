// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;


namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("items"), XmlType(AnonymousType=true)]
	public partial class ItemsDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";
		
		[XmlElement("item")]
		public List<ItemDto> Items { get; set; } = new List<ItemDto>();
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<ItemsDto>();
        }
		*/
	}
}
