using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("change_account_to")]
	[XmlType(AnonymousType=true)]
	public partial class ChangeAccountToDto
	{		
		[XmlElement("id")]
		public string Id { get; set; }
	}
}
