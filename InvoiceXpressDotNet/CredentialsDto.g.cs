using System;
using System.Xml.Serialization;
using System.ComponentModel;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;

namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("credentials"), XmlType(AnonymousType=true)]
	public partial class CredentialsDto : Dto
	{		
		
		[XmlElement("login")]
		public string Login { get; set; }
		
		[XmlElement("password")]
		public string Password { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<CredentialsDto>();
        }
		*/
	}
}
