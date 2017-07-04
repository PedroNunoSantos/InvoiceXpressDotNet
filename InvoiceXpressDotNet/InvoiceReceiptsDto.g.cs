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
	[XmlRoot("invoice_receipts"), XmlType(AnonymousType=true)]
	public partial class InvoiceReceiptsDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";

		[XmlElement("invoice_receipt")]
		public List<InvoiceReceiptDto> InvoiceReceipt { get; set; } = new List<InvoiceReceiptDto>();
		
		#region Add Methods elpers
		
		public void Add(InvoiceReceiptDto item) => InvoiceReceipt.Add(item);

		public void AddRange(IEnumerable<InvoiceReceiptDto> items) => InvoiceReceipt.AddRange(items);
		
		#endregion

		
		[XmlElement("current_page")]
		public int? CurrentPage { get; set; }

		[XmlElement("total_pages")]
		public int? TotalPages { get; set; }

		[XmlElement("total_entries")]
		public int? TotalEntries { get; set; }

		[XmlElement("per_page")]
		public int? PerPage { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<InvoiceReceiptsDto>();
        }
		*/
	}
}
