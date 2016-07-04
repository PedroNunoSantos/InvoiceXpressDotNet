using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
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
