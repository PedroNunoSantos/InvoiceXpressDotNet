using System;
using System.Xml.Serialization;
using System.ComponentModel;
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
		public DebitNoteDto[] Items { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<DebitNotesDto>();
        }
		*/
	}
}
