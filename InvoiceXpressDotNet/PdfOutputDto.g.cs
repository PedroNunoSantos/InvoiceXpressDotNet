using System;
using System.Xml.Serialization;
using System.ComponentModel;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;

namespace InvoiceXpressDotNet.DataTransferObjects
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
