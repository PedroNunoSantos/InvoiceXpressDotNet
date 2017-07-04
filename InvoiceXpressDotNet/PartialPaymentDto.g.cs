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
	[XmlRoot("partial_payment"), XmlType(AnonymousType=true)]
	public partial class PartialPaymentDto : Dto
	{		

		[XmlElement("payment_mechanism")]
		public PaymentMechanism PaymentMechanism { get; set; }

		[XmlElement("note")]
		public string Note { get; set; }

		[XmlElement("serie")]
		public string Serie { get; set; }

		[XmlIgnore]
		public float? Amount { get; set; }
		
		//serialization helper for Amount
		[XmlElement("amount"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _AmountDto
	    {	    
			get { return Amount.ToXml<float?>(); }
            set { Amount = value.FromXml<float?>(); }
	    }

		[XmlIgnore]
		public DateTime? PaymentDate { get; set; }
		
		//serialization helper for PaymentDate
		[XmlElement("payment_date"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _PaymentDateDto
	    {	    
			get { return PaymentDate.ToXml<DateTime?>(); }
            set { PaymentDate = value.FromXml<DateTime?>(); }
	    }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<PartialPaymentDto>();
        }
		*/
	}
}
