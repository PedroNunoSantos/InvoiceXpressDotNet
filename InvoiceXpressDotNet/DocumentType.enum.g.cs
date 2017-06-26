// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using InvoiceXpressDotNet.Attributes;
using InvoiceXpressDotNet.Extensions;

namespace InvoiceXpressDotNet.Enums
{
	public enum DocumentType
	{
		[XmlEnum("")]
		[UrlFilter("")]
		None = 0,
		[XmlEnum(Name="Invoice")]
		[UrlFilter("Invoice")]
		Invoice,
		[XmlEnum(Name="CashInvoice")]
		[UrlFilter("CashInvoice")]
		CashInvoice,
		[XmlEnum(Name="InvoiceReceipt")]
		[UrlFilter("InvoiceReceipt")]
		InvoiceReceipt,
		[XmlEnum(Name="SimplifiedInvoice")]
		[UrlFilter("SimplifiedInvoice")]
		SimplifiedInvoice,
		[XmlEnum(Name="CreditNote")]
		[UrlFilter("CreditNote")]
		CreditNote,
		[XmlEnum(Name="DebitNote")]
		[UrlFilter("DebitNote")]
		DebitNote,
		[XmlEnum(Name="Receipt")]
		[UrlFilter("Receipt")]
		Receipt,
	}
}
