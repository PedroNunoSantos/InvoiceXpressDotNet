using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
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
