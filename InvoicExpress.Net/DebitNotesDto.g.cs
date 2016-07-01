using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoicExpress.Net
{
	[XmlRoot("debit_notes"), XmlType(AnonymousType=true)]
	public partial class DebitNotesDto
	{
	    [XmlAttribute]
		public string type = "array";
		
		[XmlElement("debit_note")]
		public DebitNoteDto[] DebitNote { get; set; }
	}
}
