using System;
using System.Xml.Serialization;
using System.ComponentModel;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;

namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("accounts"), XmlType(AnonymousType=true)]
	public partial class AccountsDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";
		
		[XmlElement("account")]
		public AccountDto[] Items { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<AccountsDto>();
        }
		*/
	}
}
