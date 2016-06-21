using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("invoices")]
	[XmlType(AnonymousType=true)]
	public partial class InvoicesDto
	{		
		[XmlElement("invoice")]
		public InvoiceDto[] InvoicesArray { get; set; }
	}
}
