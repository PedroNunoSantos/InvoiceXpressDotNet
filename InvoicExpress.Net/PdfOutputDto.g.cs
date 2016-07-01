using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoicExpress.Net
{
	[XmlRoot("output"), XmlType(AnonymousType=true)]
	public partial class PdfOutputDto
	{
		
		[XmlElement("pdfUrl")]
		public string Pdfurl { get; set; }
	}
}
