using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoicExpress.Net
{
	[XmlRoot("events"), XmlType(AnonymousType=true)]
	public partial class EventsDto
	{
	    [XmlAttribute]
		public string type = "array";
		
		[XmlElement("event")]
		public EventDto[] EventsArray { get; set; }
	}
}
