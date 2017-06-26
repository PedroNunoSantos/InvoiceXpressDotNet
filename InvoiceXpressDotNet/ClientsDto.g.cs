// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;
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
		public List<ClientDto> Items { get; set; } = new List<ClientDto>();
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<ClientsDto>();
        }
		*/
	}
}
