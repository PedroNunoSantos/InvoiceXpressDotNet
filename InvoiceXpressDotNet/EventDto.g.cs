using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
{
	[XmlRoot("event"), XmlType(AnonymousType=true)]
	public partial class EventDto
	{
		
		[XmlElement("type")]
		public string Type { get; set; }
		
		[XmlIgnore]
		public DateTime? Date { get; set; }
		
		[XmlElement("date"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _DateDto
	    {	    
			get { return Date.ToXml<DateTime?>(); }
            set { Date = value.FromXml<DateTime?>(); }
	    }
		
		[XmlElement("time")]
		public string Time { get; set; }
		
		[XmlElement("user")]
		public string User { get; set; }
	}
}
