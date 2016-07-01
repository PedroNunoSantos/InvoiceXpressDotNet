using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoicExpress.Net
{
	[XmlRoot("roles"), XmlType(AnonymousType=true)]
	public partial class RolesDto
	{
		
		[XmlElement("role")]
		public string Role { get; set; }
	}
}
