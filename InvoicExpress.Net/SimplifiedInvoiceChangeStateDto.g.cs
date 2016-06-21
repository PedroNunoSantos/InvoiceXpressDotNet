using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("simplified_invoice")]
	[XmlType(AnonymousType=true)]
	public partial class SimplifiedInvoiceChangeStateDto
	{		
		[XmlElement("state")]
		public string State { get; set; }
		
		[XmlElement("message")]
		public string Message { get; set; }
	}
}
