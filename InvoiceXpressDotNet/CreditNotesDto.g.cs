// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;


namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("credit_notes"), XmlType(AnonymousType=true)]
	public partial class CreditNotesDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";
		
		[XmlElement("credit_note")]
		public List<CreditNoteDto> Items { get; set; } = new List<CreditNoteDto>();
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<CreditNotesDto>();
        }
		*/
	}
}
