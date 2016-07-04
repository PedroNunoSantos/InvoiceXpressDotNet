using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
{
	[XmlRoot("events"), XmlType(AnonymousType=true)]
	public partial class EventsDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";
		
		[XmlElement("event")]
		public EventDto[] EventsArray { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<EventsDto>();
        }
		*/
	}
}
