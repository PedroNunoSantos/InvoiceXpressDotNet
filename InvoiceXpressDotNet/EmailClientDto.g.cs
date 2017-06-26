// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;


namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("client"), XmlType(AnonymousType=true)]
	public partial class EmailClientDto : Dto
	{		
		
		[XmlElement("email")]
		public string Email { get; set; }
		
		[XmlElement("save")]
		public string Save { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<EmailClientDto>();
        }
		*/
	}
}
