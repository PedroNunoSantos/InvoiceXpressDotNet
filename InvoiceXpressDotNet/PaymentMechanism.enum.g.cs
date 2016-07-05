using System;
using System.Xml.Serialization;
namespace InvoiceXpressDotNet
{
	public enum PaymentMechanism
	{
		[XmlEnum("")]
		None = 0,
		[XmlEnum(Name="CC")]
		CC,
		[XmlEnum(Name="CD")]
		CD,
		[XmlEnum(Name="CH")]
		CH,
		[XmlEnum(Name="CO")]
		CO,
		[XmlEnum(Name="CS")]
		CS,
		[XmlEnum(Name="DE")]
		DE,
		[XmlEnum(Name="LC")]
		LC,
		[XmlEnum(Name="MB")]
		MB,
		[XmlEnum(Name="NU")]
		NU,
		[XmlEnum(Name="OU")]
		OU,
		[XmlEnum(Name="PR")]
		PR,
		[XmlEnum(Name="TB")]
		TB,
		[XmlEnum(Name="TR")]
		TR,
	}
}
