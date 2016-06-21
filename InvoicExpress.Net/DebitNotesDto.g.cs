using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("debit_notes")]
	[XmlType(AnonymousType=true)]
	public partial class DebitNotesDto
	{		
		[XmlElement("debit_note")]
		public DebitNoteDto[] DebitNote { get; set; }
	}
}
