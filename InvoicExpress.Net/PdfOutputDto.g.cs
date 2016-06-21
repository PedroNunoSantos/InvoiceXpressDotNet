using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("output")]
	[XmlType(AnonymousType=true)]
	public partial class PdfOutputDto
	{		
		[XmlElement("pdfUrl")]
		public string Pdfurl { get; set; }
	}
}
