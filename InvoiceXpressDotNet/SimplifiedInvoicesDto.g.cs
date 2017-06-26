// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;


namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("simplified_invoices"), XmlType(AnonymousType=true)]
	public partial class SimplifiedInvoicesDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";
		
		[XmlElement("simplified_invoice")]
		public List<SimplifiedInvoiceDto> Items { get; set; } = new List<SimplifiedInvoiceDto>();
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<SimplifiedInvoicesDto>();
        }
		*/
	}
}
