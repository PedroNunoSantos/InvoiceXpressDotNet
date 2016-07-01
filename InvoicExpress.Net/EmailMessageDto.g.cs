using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoicExpress.Net
{
	[XmlRoot("message"), XmlType(AnonymousType=true)]
	public partial class EmailMessageDto
	{
		
		[XmlElement("client")]
		public EmailClientDto Client { get; set; }
		
		[XmlElement("subject")]
		public string Subject { get; set; }
		
		[XmlElement("body")]
		public string Body { get; set; }
		
		[XmlElement("cc")]
		public string Cc { get; set; }
		
		[XmlElement("bcc")]
		public string Bcc { get; set; }
		
		[XmlElement("logo")]
		public string Logo { get; set; }
	}
}
