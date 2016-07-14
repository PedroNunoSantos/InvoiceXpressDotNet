using System;
using System.Xml.Serialization;
using System.ComponentModel;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;

namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("invoice_receipts"), XmlType(AnonymousType=true)]
	public partial class InvoiceReceiptsDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";
		
		[XmlElement("invoice_receipt")]
		public InvoiceReceiptDto[] InvoiceReceipt { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<InvoiceReceiptsDto>();
        }
		*/
	}
}
