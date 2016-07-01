using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
{
	[XmlRoot("tax"), XmlType(AnonymousType=true)]
	public partial class TaxDto
	{
		
		[XmlIgnore]
		public int? Id { get; set; }
		
		[XmlElement("id"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _IdDto
	    {	    
			get { return Id.ToXml<int?>(); }
            set { Id = value.FromXml<int?>(); }
	    }
		
		[XmlElement("name")]
		public string Name { get; set; }
		
		[XmlElement("value")]
		public string Value { get; set; }
		
		[XmlElement("region")]
		public string Region { get; set; }
		
		[XmlElement("default_tax")]
		public string DefaultTax { get; set; }
	}
}
