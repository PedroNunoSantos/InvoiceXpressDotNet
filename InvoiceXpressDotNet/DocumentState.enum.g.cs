// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using InvoiceXpressDotNet.Attributes;
using InvoiceXpressDotNet.Extensions;

namespace InvoiceXpressDotNet.Enums
{
	public enum DocumentState
	{
		[XmlEnum("")]
		[UrlFilter("")]
		None = 0,
		[XmlEnum(Name="draft")]
		[UrlFilter("draft")]
		Draft,
		[XmlEnum(Name="settled")]
		[UrlFilter("settled")]
		Settled,
		[XmlEnum(Name="finalized")]
		[UrlFilter("finalized")]
		Finalized,
		[XmlEnum(Name="deleted")]
		[UrlFilter("deleted")]
		Deleted,
		[XmlEnum(Name="accepted")]
		[UrlFilter("accepted")]
		Accepted,
		[XmlEnum(Name="refused")]
		[UrlFilter("refused")]
		Refused,
		[XmlEnum(Name="canceled")]
		[UrlFilter("canceled")]
		Canceled,
		[XmlEnum(Name="final")]
		[UrlFilter("final")]
		Final,
	}
}
