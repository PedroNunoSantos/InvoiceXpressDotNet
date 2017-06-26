// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;


namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("invoice_receipt"), XmlType(AnonymousType=true)]
	public partial class InvoiceReceiptChangeStateDto : Dto
	{		
		
		[XmlElement("state")]
		public DocumentState State { get; set; }
		
		[XmlElement("message")]
		public string Message { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<InvoiceReceiptChangeStateDto>();
        }
		*/
	}
}
