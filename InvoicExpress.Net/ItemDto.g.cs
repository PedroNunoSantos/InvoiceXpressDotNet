using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoicExpress.Net
{
	[XmlRoot("item"), XmlType(AnonymousType=true)]
	public partial class ItemDto
	{
		
		[XmlElement("name")]
		public string Name { get; set; }
		
		[XmlElement("description")]
		public string Description { get; set; }
		
		[XmlIgnore]
		public float? UnitPrice { get; set; }
		
		[XmlElement("unit_price"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _UnitPriceDto
	    {	    
			get { return UnitPrice.ToXml<float?>(); }
            set { UnitPrice = value.FromXml<float?>(); }
	    }
		
		[XmlElement("unit")]
		public string Unit { get; set; }
		
		[XmlIgnore]
		public float? Quantity { get; set; }
		
		[XmlElement("quantity"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _QuantityDto
	    {	    
			get { return Quantity.ToXml<float?>(); }
            set { Quantity = value.FromXml<float?>(); }
	    }
		
		[XmlElement("tax")]
		public TaxDto Tax { get; set; }
		
		[XmlIgnore]
		public float? Discount { get; set; }
		
		[XmlElement("discount"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _DiscountDto
	    {	    
			get { return Discount.ToXml<float?>(); }
            set { Discount = value.FromXml<float?>(); }
	    }
		
		[XmlIgnore]
		public float? Subtotal { get; set; }
		
		[XmlElement("subtotal"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _SubtotalDto
	    {	    
			get { return Subtotal.ToXml<float?>(); }
            set { Subtotal = value.FromXml<float?>(); }
	    }
		
		[XmlIgnore]
		public float? TaxAmount { get; set; }
		
		[XmlElement("tax_amount"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _TaxAmountDto
	    {	    
			get { return TaxAmount.ToXml<float?>(); }
            set { TaxAmount = value.FromXml<float?>(); }
	    }
		
		[XmlIgnore]
		public float? DiscountAmount { get; set; }
		
		[XmlElement("discount_amount"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _DiscountAmountDto
	    {	    
			get { return DiscountAmount.ToXml<float?>(); }
            set { DiscountAmount = value.FromXml<float?>(); }
	    }
		
		[XmlIgnore]
		public float? Total { get; set; }
		
		[XmlElement("total"), EditorBrowsableAttribute(EditorBrowsableState.Never)]
	    public string _TotalDto
	    {	    
			get { return Total.ToXml<float?>(); }
            set { Total = value.FromXml<float?>(); }
	    }
	}
}
