using System.Xml.Serialization;
namespace InvoicExpress.Net
{
	[XmlRoot("documents")]
	[XmlType(AnonymousType=true)]
	public partial class DocumentsStatsDto
	{		
		[XmlElement("used_documents")]
		public string UsedDocuments { get; set; }
		
		[XmlElement("available_documents")]
		public string AvailableDocuments { get; set; }
		
		[XmlElement("used_api_documents")]
		public string UsedApiDocuments { get; set; }
		
		[XmlElement("available_api_documents")]
		public string AvailableApiDocuments { get; set; }
		
		[XmlElement("used_web_documents")]
		public string UsedWebDocuments { get; set; }
		
		[XmlElement("available_web_documents")]
		public string AvailableWebDocuments { get; set; }
	}
}
