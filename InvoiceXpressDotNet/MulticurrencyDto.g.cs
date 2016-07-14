using System;
using System.Xml.Serialization;
using System.ComponentModel;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;

namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("multicurrency"), XmlType(AnonymousType=true)]
	public partial class MulticurrencyDto : Dto
	{		
		
		[XmlElement("rate")]
		public string Rate { get; set; }
		
		[XmlElement("currency")]
		public string Currency { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<MulticurrencyDto>();
        }
		*/
	}
}
