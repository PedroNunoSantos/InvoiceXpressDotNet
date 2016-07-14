using System;
using System.Xml.Serialization;
using System.ComponentModel;
using InvoiceXpressDotNet.Extensions;

namespace InvoiceXpressDotNet
{
	public enum IvaExemptionCode
	{
		[XmlEnum("")]
		None = 0,
		/// <summary>
		/// Artigo 16.º n.º 6 alínea c) do CIVA
		/// </summary>		
		[XmlEnum(Name="M01")]
		M01,
		/// <summary>
		/// Artigo 6.º do Decreto‐Lei n.º 198/90, de 19 de Junho
		/// </summary>		
		[XmlEnum(Name="M02")]
		M02,
		/// <summary>
		/// Exigibilidade de caixa
		/// </summary>		
		[XmlEnum(Name="M03")]
		M03,
		/// <summary>
		/// Isento Artigo 13.º do CIVA
		/// </summary>		
		[XmlEnum(Name="M04")]
		M04,
		/// <summary>
		/// Isento Artigo 14.º do CIVA
		/// </summary>		
		[XmlEnum(Name="M05")]
		M05,
		/// <summary>
		/// Isento Artigo 15.º do CIVA
		/// </summary>		
		[XmlEnum(Name="M06")]
		M06,
		/// <summary>
		/// Isento Artigo 9.º do CIVA
		/// </summary>		
		[XmlEnum(Name="M07")]
		M07,
		/// <summary>
		/// IVA – Autoliquidação
		/// </summary>		
		[XmlEnum(Name="M08")]
		M08,
		/// <summary>
		/// IVA ‐ não confere direito a dedução
		/// </summary>		
		[XmlEnum(Name="M09")]
		M09,
		/// <summary>
		/// IVA – Regime de isenção
		/// </summary>		
		[XmlEnum(Name="M10")]
		M10,
		/// <summary>
		/// Regime particular do tabaco
		/// </summary>		
		[XmlEnum(Name="M11")]
		M11,
		/// <summary>
		/// Regime da margem de lucro – Agências de Viagens
		/// </summary>		
		[XmlEnum(Name="M12")]
		M12,
		/// <summary>
		/// Regime da margem de lucro – Bens em segunda mão
		/// </summary>		
		[XmlEnum(Name="M13")]
		M13,
		/// <summary>
		/// Regime da margem de lucro – Objetos de arte
		/// </summary>		
		[XmlEnum(Name="M14")]
		M14,
		/// <summary>
		/// Regime da margem de lucro – Objetos de coleção e antiguidades
		/// </summary>		
		[XmlEnum(Name="M15")]
		M15,
		/// <summary>
		/// Isento Artigo 14.º do RITI
		/// </summary>		
		[XmlEnum(Name="M16")]
		M16,
		/// <summary>
		/// Não sujeito; não tributado (ou similar)
		/// </summary>		
		[XmlEnum(Name="M99")]
		M99,
	}
}
