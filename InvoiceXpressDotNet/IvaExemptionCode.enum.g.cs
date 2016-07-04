using System;
using System.Xml.Serialization;
namespace InvoiceXpressDotNet
{
	public enum IvaExemptionCode
	{
		[XmlEnum("")]
		None = 0,
		[XmlEnum(Name="M01")]
		M01,
		[XmlEnum(Name="M02")]
		M02,
		[XmlEnum(Name="M03")]
		M03,
		[XmlEnum(Name="M04")]
		M04,
		[XmlEnum(Name="M05")]
		M05,
		[XmlEnum(Name="M06")]
		M06,
		[XmlEnum(Name="M07")]
		M07,
		[XmlEnum(Name="M08")]
		M08,
		[XmlEnum(Name="M09")]
		M09,
		[XmlEnum(Name="M10")]
		M10,
		[XmlEnum(Name="M11")]
		M11,
		[XmlEnum(Name="M12")]
		M12,
		[XmlEnum(Name="M13")]
		M13,
		[XmlEnum(Name="M14")]
		M14,
		[XmlEnum(Name="M15")]
		M15,
		[XmlEnum(Name="M16")]
		M16,
		[XmlEnum(Name="M99")]
		M99,
	}
}
