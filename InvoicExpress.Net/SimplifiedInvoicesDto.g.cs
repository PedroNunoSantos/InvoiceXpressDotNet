using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoicExpress.Net
{
	[XmlRoot("simplified_invoices"), XmlType(AnonymousType=true)]
	public partial class SimplifiedInvoicesDto
	{
	    [XmlAttribute]
		public string type = "array";
		
		[XmlElement("simplified_invoice")]
		public SimplifiedInvoiceDto[] SimplifiedInvoicesArray { get; set; }
	}
}
