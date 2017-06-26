// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;


namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("taxes"), XmlType(AnonymousType=true)]
	public partial class TaxesDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";
		
		[XmlElement("tax")]
		public List<TaxDto> Items { get; set; } = new List<TaxDto>();
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<TaxesDto>();
        }
		*/
	}
}
