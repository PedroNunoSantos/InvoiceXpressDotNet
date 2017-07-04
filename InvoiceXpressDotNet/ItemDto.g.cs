// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;

namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("item"), XmlType(AnonymousType=true)]
	public partial class ItemDto : Dto
	{		

		[XmlElement("name")]
		public string Name { get; set; }

		[XmlElement("description")]
		public string Description { get; set; }

		[XmlIgnore]
		public float? UnitPrice { get; set; }
		
		//serialization helper for UnitPrice
		[XmlElement("unit_price"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _UnitPriceDto
	    {	    
			get { return UnitPrice.ToXml<float?>(); }
            set { UnitPrice = value.FromXml<float?>(); }
	    }

		[XmlElement("unit")]
		public string Unit { get; set; }

		[XmlIgnore]
		public float? Quantity { get; set; }
		
		//serialization helper for Quantity
		[XmlElement("quantity"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _QuantityDto
	    {	    
			get { return Quantity.ToXml<float?>(); }
            set { Quantity = value.FromXml<float?>(); }
	    }

		[XmlElement("tax")]
		public TaxDto Tax { get; set; }

		[XmlIgnore]
		public float? Discount { get; set; }
		
		//serialization helper for Discount
		[XmlElement("discount"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _DiscountDto
	    {	    
			get { return Discount.ToXml<float?>(); }
            set { Discount = value.FromXml<float?>(); }
	    }

		[XmlIgnore]
		public float? Subtotal { get; set; }
		
		//serialization helper for Subtotal
		[XmlElement("subtotal"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _SubtotalDto
	    {	    
			get { return Subtotal.ToXml<float?>(); }
            set { Subtotal = value.FromXml<float?>(); }
	    }

		[XmlIgnore]
		public float? TaxAmount { get; set; }
		
		//serialization helper for TaxAmount
		[XmlElement("tax_amount"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _TaxAmountDto
	    {	    
			get { return TaxAmount.ToXml<float?>(); }
            set { TaxAmount = value.FromXml<float?>(); }
	    }

		[XmlIgnore]
		public float? DiscountAmount { get; set; }
		
		//serialization helper for DiscountAmount
		[XmlElement("discount_amount"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _DiscountAmountDto
	    {	    
			get { return DiscountAmount.ToXml<float?>(); }
            set { DiscountAmount = value.FromXml<float?>(); }
	    }

		[XmlIgnore]
		public float? Total { get; set; }
		
		//serialization helper for Total
		[XmlElement("total"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _TotalDto
	    {	    
			get { return Total.ToXml<float?>(); }
            set { Total = value.FromXml<float?>(); }
	    }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<ItemDto>();
        }
		*/
	}
}
