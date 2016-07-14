using System;
using System.Xml.Serialization;
using System.ComponentModel;
using InvoiceXpressDotNet.Extensions;

namespace InvoiceXpressDotNet.Enums
{
	public enum DocumentState
	{
		[XmlEnum("")]
		None = 0,
		[XmlEnum(Name="draft")]
		Draft,
		[XmlEnum(Name="settled")]
		Settled,
		[XmlEnum(Name="finalized")]
		Finalized,
		[XmlEnum(Name="deleted")]
		Deleted,
		[XmlEnum(Name="canceled")]
		Canceled,
		[XmlEnum(Name="final")]
		Final,
	}
}
