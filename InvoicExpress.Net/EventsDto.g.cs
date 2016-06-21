using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("events")]
	[XmlType(AnonymousType=true)]
	public partial class EventsDto
	{		
		[XmlElement("event")]
		public EventDto[] EventsArray { get; set; }
	}
}
