using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
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
