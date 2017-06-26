// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;
using InvoiceXpressDotNet.Attributes;
using InvoiceXpressDotNet.Enums;
using InvoiceXpressDotNet.Extensions;

namespace InvoiceXpressDotNet.DataTransferObjects
{
	public class InvoiceFilters
	{		
		[UrlFilter("text")]
		public string Text { get; set; }
		[UrlFilter("type[]")]
		public List<DocumentType> DocumentType { get; set; } = new List<DocumentType>();
		[UrlFilter("status[]")]
		public List<DocumentStatus> DocumentStatus { get; set; } = new List<DocumentStatus>();
		[UrlFilter("date[to]")]
		public DateTime? DateTo { get; set; }
		[UrlFilter("date[from]")]
		public DateTime? DateFrom { get; set; }
		[UrlFilter("due_date[to]")]
		public DateTime? DueDateTo { get; set; }
		[UrlFilter("due_date[from]")]
		public DateTime? DueDateFrom { get; set; }
		[UrlFilter("total_before_taxes[to]")]
		public float? TotalBeforeTaxesTo { get; set; }
		[UrlFilter("total_before_taxes[from]")]
		public float? TotalBeforeTaxesFrom { get; set; }
		[UrlFilter("non_archived")]
		public bool? NonArchived { get; set; }
		[UrlFilter("archived")]
		public bool? Archived { get; set; }
	}
}
