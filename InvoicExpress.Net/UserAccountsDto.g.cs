using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("accounts")]
	[XmlType(AnonymousType=true)]
	public partial class UserAccountsDto
	{		
		[XmlElement("account")]
		public UserAccountDto[] AccountsArray { get; set; }
	}
}
