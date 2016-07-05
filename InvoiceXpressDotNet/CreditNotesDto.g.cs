using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
{
	[XmlRoot("credit_notes"), XmlType(AnonymousType=true)]
	public partial class CreditNotesDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";
		
		[XmlElement("credit_note")]
		public CreditNoteDto[] Items { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<CreditNotesDto>();
        }
		*/
	}
}
