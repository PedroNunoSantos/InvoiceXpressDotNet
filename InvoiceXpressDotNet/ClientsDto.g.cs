using System;
using System.Xml.Serialization;
using System.ComponentModel;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;

namespace InvoiceXpressDotNet.DataTransferObjects
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
