using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("event")]
	[XmlType(AnonymousType=true)]
	public partial class EventDto
	{		
		[XmlElement("type")]
		public string Type { get; set; }
		
		[XmlElement("date")]
		public string Date { get; set; }
		
		[XmlElement("time")]
		public string Time { get; set; }
		
		[XmlElement("user")]
		public string User { get; set; }
	}
}
