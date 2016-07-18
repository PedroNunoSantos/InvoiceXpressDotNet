using System;
using System.Xml.Serialization;
using System.ComponentModel;
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
		public UserAccountDto[] Items { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<UserAccountsDto>();
        }
		*/
	}
}
