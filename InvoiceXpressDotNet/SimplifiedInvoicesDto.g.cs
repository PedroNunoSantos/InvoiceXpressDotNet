using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
{
	[XmlRoot("simplified_invoices"), XmlType(AnonymousType=true)]
	public partial class SimplifiedInvoicesDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";
		
		[XmlElement("simplified_invoice")]
		public SimplifiedInvoiceDto[] SimplifiedInvoicesArray { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<SimplifiedInvoicesDto>();
        }
		*/
	}
}
