using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("users")]
	[XmlType(AnonymousType=true)]
	public partial class UsersStatsDto
	{		
		[XmlElement("used_users")]
		public string UsedUsers { get; set; }
		
		[XmlElement("available_users")]
		public string AvailableUsers { get; set; }
	}
}
