// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using InvoiceXpressDotNet.Attributes;
using InvoiceXpressDotNet.Extensions;

namespace InvoiceXpressDotNet.Enums
{
	public enum DocumentStatus
	{
		[XmlEnum("")]
		[UrlFilter("")]
		None = 0,
		[XmlEnum(Name="draft")]
		[UrlFilter("draft")]
		Draft,
		[XmlEnum(Name="sent")]
		[UrlFilter("sent")]
		Sent,
		[XmlEnum(Name="settled")]
		[UrlFilter("settled")]
		Settled,
		[XmlEnum(Name="canceled")]
		[UrlFilter("canceled")]
		Canceled,
		[XmlEnum(Name="second_copy")]
		[UrlFilter("second_copy")]
		SecondCopy,
	}
}
