using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoicExpress.Net
{
	[XmlRoot("credit_notes"), XmlType(AnonymousType=true)]
	public partial class CreditNotesDto
	{
	    [XmlAttribute]
		public string type = "array";
		
		[XmlElement("credit_note")]
		public CreditNoteDto[] CreditNote { get; set; }
	}
}
