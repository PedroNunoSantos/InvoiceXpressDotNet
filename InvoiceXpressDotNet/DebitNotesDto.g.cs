// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;


namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("debit_notes"), XmlType(AnonymousType=true)]
	public partial class DebitNotesDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";
		
		[XmlElement("debit_note")]
		public List<DebitNoteDto> Items { get; set; } = new List<DebitNoteDto>();
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<DebitNotesDto>();
        }
		*/
	}
}
