using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("credit_note")]
	[XmlType(AnonymousType=true)]
	public partial class CreditNoteChangeStateDto
	{		
		[XmlElement("state")]
		public string State { get; set; }
		
		[XmlElement("message")]
		public string message { get; set; }
	}
}
