// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
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
