using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("receipt")]
	[XmlType(AnonymousType=true)]
	public partial class PartialPaymentReceiptDto
	{		
		[XmlElement("id")]
		public string Id { get; set; }
		
		[XmlElement("status")]
		public string Status { get; set; }
		
		[XmlElement("archived")]
		public string Archived { get; set; }
		
		[XmlElement("type")]
		public string Type { get; set; }
		
		[XmlElement("sequence_number")]
		public string SequenceNumber { get; set; }
		
		[XmlElement("date")]
		public string Date { get; set; }
		
		[XmlElement("due_date")]
		public string DueDate { get; set; }
		
		[XmlElement("observations")]
		public string Observations { get; set; }
		
		[XmlElement("retention")]
		public string Retention { get; set; }
		
		[XmlElement("permalink")]
		public string Permalink { get; set; }
		
		[XmlElement("sum")]
		public string Sum { get; set; }
		
		[XmlElement("discount")]
		public string Discount { get; set; }
		
		[XmlElement("before_taxes")]
		public string BeforeTaxes { get; set; }
		
		[XmlElement("taxes")]
		public string Taxes { get; set; }
		
		[XmlElement("total")]
		public string Total { get; set; }
		
		[XmlElement("currency")]
		public string Currency { get; set; }
		
		[XmlElement("client")]
		public ClientDto Client { get; set; }
		
		[XmlElement("multicurrency")]
		public MulticurrencyDto Multicurrency { get; set; }
		
		[XmlElement("events")]
		public EventsDto EventsArray { get; set; }
	}
}
