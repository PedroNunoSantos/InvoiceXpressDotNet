using System;
using System.Xml.Serialization;
using System.ComponentModel;
using InvoiceXpressDotNet.Extensions;

namespace InvoiceXpressDotNet
{
	[XmlRoot("output"), XmlType(AnonymousType=true)]
	public partial class PdfOutputDto : Dto
	{		
		
		[XmlElement("pdfUrl")]
		public string Pdfurl { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<PdfOutputDto>();
        }
		*/
	}
}
