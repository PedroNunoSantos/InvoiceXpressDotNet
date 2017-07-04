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
	[XmlRoot("accounts"), XmlType(AnonymousType=true)]
	public partial class UserAccountsDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";

		[XmlElement("account")]
		public List<UserAccountDto> Items { get; set; } = new List<UserAccountDto>();
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<UserAccountsDto>();
        }
		*/
	}
}
