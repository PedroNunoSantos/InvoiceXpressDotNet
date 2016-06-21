using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("accounts")]
	[XmlType(AnonymousType=true)]
	public partial class AccountsDto
	{		
		[XmlElement("account")]
		public AccountDto[] AccountsArray { get; set; }
	}
}
