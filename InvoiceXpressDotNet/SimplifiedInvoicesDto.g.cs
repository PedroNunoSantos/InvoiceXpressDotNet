using System;
using System.Xml.Serialization;
using System.ComponentModel;
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
		public SimplifiedInvoiceDto[] Items { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<SimplifiedInvoicesDto>();
        }
		*/
	}
}
