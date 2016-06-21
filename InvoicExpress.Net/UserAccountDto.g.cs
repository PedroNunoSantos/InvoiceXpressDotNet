using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("account")]
	[XmlType(AnonymousType=true)]
	public partial class UserAccountDto
	{		
		[XmlElement("id")]
		public string Id { get; set; }
		
		[XmlElement("name")]
		public string Name { get; set; }
		
		[XmlElement("url")]
		public string Url { get; set; }
		
		[XmlElement("api_key")]
		public string ApiKey { get; set; }
		
		[XmlElement("state")]
		public string State { get; set; }
		
		[XmlElement("blocked")]
		public string Blocked { get; set; }
		
		[XmlElement("roles")]
		public RolesDto RolesArray { get; set; }
	}
}
