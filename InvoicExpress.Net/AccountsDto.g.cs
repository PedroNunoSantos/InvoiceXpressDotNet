using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoicExpress.Net
{
	[XmlRoot("accounts"), XmlType(AnonymousType=true)]
	public partial class AccountsDto
	{
	    [XmlAttribute]
		public string type = "array";
		
		[XmlElement("account")]
		public AccountDto[] AccountsArray { get; set; }
	}
}
