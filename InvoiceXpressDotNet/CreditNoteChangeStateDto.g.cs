using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
{
	[XmlRoot("credit_note"), XmlType(AnonymousType=true)]
	public partial class CreditNoteChangeStateDto : Dto
	{		
		
		[XmlElement("state")]
		public InvoiceState State { get; set; }
		
		[XmlElement("message")]
		public string message { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<CreditNoteChangeStateDto>();
        }
		*/
	}
}
