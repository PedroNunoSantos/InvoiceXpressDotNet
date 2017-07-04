// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;

namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("message"), XmlType(AnonymousType=true)]
	public partial class EmailMessageDto : Dto
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

		[XmlIgnore]
		public int? Logo { get; set; }
		
		//serialization helper for Logo
		[XmlElement("logo"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _LogoDto
	    {	    
			get { return Logo.ToXml<int?>(); }
            set { Logo = value.FromXml<int?>(); }
	    }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<EmailMessageDto>();
        }
		*/
	}
}
