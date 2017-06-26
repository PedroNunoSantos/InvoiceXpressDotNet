// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;


namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("invoice_receipt"), XmlType(AnonymousType=true)]
	public partial class InvoiceReceiptChangeStateResponseDto : Dto
	{		
		
		[XmlElement("state")]
		public DocumentState State { get; set; }
		
		[XmlElement("message")]
		public string Message { get; set; }
		
		[XmlElement("id")]
		public int Id { get; set; }
		
		[XmlElement("type")]
		public string Type { get; set; }
		
		[XmlElement("sequence_number")]
		public string SequenceNumber { get; set; }
		
		[XmlElement("inverted_sequence_number")]
		public string InvertedSequenceNumber { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<InvoiceReceiptChangeStateResponseDto>();
        }
		*/
	}
}
