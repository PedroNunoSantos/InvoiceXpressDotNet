// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;

namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("simplified_invoices"), XmlType(AnonymousType=true)]
	public partial class SimplifiedInvoicesDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";

		[XmlElement("simplified_invoice")]
		public List<SimplifiedInvoiceDto> Items { get; set; } = new List<SimplifiedInvoiceDto>();
		
		#region Add Methods elpers
		
		public void Add(SimplifiedInvoiceDto item) => Items.Add(item);

		public void AddRange(IEnumerable<SimplifiedInvoiceDto> items) => Items.AddRange(items);
		
		#endregion

				
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<SimplifiedInvoicesDto>();
        }
		*/
	}
}
