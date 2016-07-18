using System;
using System.Xml.Serialization;
using System.ComponentModel;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;

namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("roles"), XmlType(AnonymousType=true)]
	public partial class RolesDto : Dto
	{		
		
		[XmlElement("role")]
		public string Role { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<RolesDto>();
        }
		*/
	}
}
