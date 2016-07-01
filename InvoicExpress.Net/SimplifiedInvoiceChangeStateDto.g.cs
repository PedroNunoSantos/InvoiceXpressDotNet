using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoicExpress.Net
{
	[XmlRoot("simplified_invoice"), XmlType(AnonymousType=true)]
	public partial class SimplifiedInvoiceChangeStateDto
	{
		
		[XmlElement("state")]
		public string State { get; set; }
		
		[XmlElement("message")]
		public string Message { get; set; }
	}
}
