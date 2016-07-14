using System;
using System.Xml.Serialization;
using System.ComponentModel;
using InvoiceXpressDotNet.Extensions;

namespace InvoiceXpressDotNet
{
	[XmlRoot("event"), XmlType(AnonymousType=true)]
	public partial class EventDto : Dto
	{		
		
		[XmlElement("type")]
		public string Type { get; set; }
		
		[XmlIgnore]
		public DateTime? Date { get; set; }
		
		[XmlElement("date"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _DateDto
	    {	    
			get { return Date.ToXml<DateTime?>(); }
            set { Date = value.FromXml<DateTime?>(); }
	    }
		
		[XmlElement("time")]
		public string Time { get; set; }
		
		[XmlElement("user")]
		public string User { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<EventDto>();
        }
		*/
	}
}
