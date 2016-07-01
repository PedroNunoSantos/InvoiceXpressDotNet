using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
{
	[XmlRoot("output"), XmlType(AnonymousType=true)]
	public partial class PdfOutputDto
	{
		
		[XmlElement("pdfUrl")]
		public string Pdfurl { get; set; }
	}
}
