using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoicExpress.Net
{
	[XmlRoot("credentials"), XmlType(AnonymousType=true)]
	public partial class CredentialsDto
	{
		
		[XmlElement("login")]
		public string Login { get; set; }
		
		[XmlElement("password")]
		public string Password { get; set; }
	}
}
