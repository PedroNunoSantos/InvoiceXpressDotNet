using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
{
	[XmlRoot("clients"), XmlType(AnonymousType=true)]
	public partial class ClientsDto
	{
		[XmlAttribute]
		public string type = "array";
		
		[XmlElement("client")]
		public ClientDto[] ClientsArray { get; set; }
	}
}
