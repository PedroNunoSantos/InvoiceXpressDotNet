using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("debit_note")]
	[XmlType(AnonymousType=true)]
	public partial class DebitNoteDto
	{		
		[XmlElement("date")]
		public string Date { get; set; }
		
		[XmlElement("due_date")]
		public string DueDate { get; set; }
		
		[XmlElement("client")]
		public ClientDto Client { get; set; }
		
		[XmlElement("items")]
		public ItemsDto Items { get; set; }
		
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
		
		[XmlElement("reference")]
		public string Reference { get; set; }
		
		[XmlElement("observations")]
		public string Observations { get; set; }
		
		[XmlElement("retention")]
		public string Retention { get; set; }
		
		[XmlElement("tax_exemption")]
		public string TaxExemption { get; set; }
		
		[XmlElement("sequence_id")]
		public string SequenceId { get; set; }
		
		[XmlElement("manual_sequence_number")]
		public string ManualSequenceNumber { get; set; }
		
		[XmlElement("permalink")]
		public string Permalink { get; set; }
		
		[XmlElement("currency")]
		public string Currency { get; set; }
		
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
	}
}
