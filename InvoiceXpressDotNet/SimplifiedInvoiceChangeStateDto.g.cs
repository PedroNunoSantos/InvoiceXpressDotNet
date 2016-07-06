using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
{
	[XmlRoot("simplified_invoice"), XmlType(AnonymousType=true)]
	public partial class SimplifiedInvoiceChangeStateDto : Dto
	{		
		
		[XmlElement("state")]
		public DocumentState State { get; set; }
		
		[XmlElement("message")]
		public string Message { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<SimplifiedInvoiceChangeStateDto>();
        }
		*/
	}
}
