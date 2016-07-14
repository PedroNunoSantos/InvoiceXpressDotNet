using System;
using System.Xml.Serialization;
using System.ComponentModel;
using InvoiceXpressDotNet.Extensions;

namespace InvoiceXpressDotNet.Enums
{
	public enum PaymentMechanism
	{
		[XmlEnum("")]
		None = 0,
		/// <summary>
		/// Credit card
		/// </summary>		
		[XmlEnum(Name="CC")]
		CC,
		/// <summary>
		/// Debit card
		/// </summary>		
		[XmlEnum(Name="CD")]
		CD,
		/// <summary>
		/// Bank check
		/// </summary>		
		[XmlEnum(Name="CH")]
		CH,
		/// <summary>
		/// Check or voucher
		/// </summary>		
		[XmlEnum(Name="CO")]
		CO,
		/// <summary>
		/// Current account balance compensation
		/// </summary>		
		[XmlEnum(Name="CS")]
		CS,
		/// <summary>
		/// e-Cash
		/// </summary>		
		[XmlEnum(Name="DE")]
		DE,
		/// <summary>
		/// Commercial paper
		/// </summary>		
		[XmlEnum(Name="LC")]
		LC,
		/// <summary>
		/// Multibanco payment references
		/// </summary>		
		[XmlEnum(Name="MB")]
		MB,
		/// <summary>
		/// Cash
		/// </summary>		
		[XmlEnum(Name="NU")]
		NU,
		/// <summary>
		/// Other methods not mentioned here
		/// </summary>		
		[XmlEnum(Name="OU")]
		OU,
		/// <summary>
		/// Exchange of properties
		/// </summary>		
		[XmlEnum(Name="PR")]
		PR,
		/// <summary>
		/// Bank transfer or authorized direct debit
		/// </summary>		
		[XmlEnum(Name="TB")]
		TB,
		/// <summary>
		/// Restaurant ticket
		/// </summary>		
		[XmlEnum(Name="TR")]
		TR,
	}
}
