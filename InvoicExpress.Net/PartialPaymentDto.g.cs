using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("partial_payment")]
	[XmlType(AnonymousType=true)]
	public partial class PartialPaymentDto
	{		
		[XmlElement("payment_mechanism")]
		public string PaymentMechanism { get; set; }
		
		[XmlElement("note")]
		public string Note { get; set; }
		
		[XmlElement("serie")]
		public string Serie { get; set; }
		
		[XmlElement("amount")]
		public string Amount { get; set; }
		
		[XmlElement("payment_date")]
		public string PaymentDate { get; set; }
	}
}
