using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("simplified_invoices")]
	[XmlType(AnonymousType=true)]
	public partial class SimplifiedInvoicesDto
	{		
		[XmlElement("simplified_invoice")]
		public SimplifiedInvoiceDto[] SimplifiedInvoicesArray { get; set; }
	}
}
