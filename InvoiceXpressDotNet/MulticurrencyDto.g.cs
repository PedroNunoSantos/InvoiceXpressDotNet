using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
{
	[XmlRoot("multicurrency"), XmlType(AnonymousType=true)]
	public partial class MulticurrencyDto
	{
		
		[XmlElement("rate")]
		public string Rate { get; set; }
		
		[XmlElement("currency")]
		public string Currency { get; set; }
	}
}
