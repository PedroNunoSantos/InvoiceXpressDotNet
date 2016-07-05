using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
{
	[XmlRoot("clients"), XmlType(AnonymousType=true)]
	public partial class ClientsDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";
		
		[XmlElement("client")]
		public ClientDto[] Items { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<ClientsDto>();
        }
		*/
	}
}
