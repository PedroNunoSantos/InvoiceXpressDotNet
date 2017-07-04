// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;

namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("events"), XmlType(AnonymousType=true)]
	public partial class EventsDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";

		[XmlElement("event")]
		public List<EventDto> Items { get; set; } = new List<EventDto>();
		
		#region Add Methods elpers
		
		public void Add(EventDto item) => Items.Add(item);

		public void AddRange(IEnumerable<EventDto> items) => Items.AddRange(items);
		
		#endregion

				
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<EventsDto>();
        }
		*/
	}
}
