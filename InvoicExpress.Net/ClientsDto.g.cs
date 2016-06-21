using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("clients")]
	[XmlType(AnonymousType=true)]
	public partial class ClientsDto
	{		
		[XmlElement("client")]
		public ClientDto[] ClientsArray { get; set; }
	}
}
