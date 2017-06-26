// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections.Generic;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;


namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("invoices"), XmlType(AnonymousType=true)]
	public partial class InvoicesDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";
		
		[XmlElement("invoice")]
		public List<InvoiceDto> Items { get; set; } = new List<InvoiceDto>();
		
		[XmlIgnore]
		public int? CurrentPage { get; set; }
		
		[XmlElement("current_page"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _CurrentPageDto
	    {	    
			get { return CurrentPage.ToXml<int?>(); }
            set { CurrentPage = value.FromXml<int?>(); }
	    }
		
		[XmlIgnore]
		public int? TotalPages { get; set; }
		
		[XmlElement("total_pages"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _TotalPagesDto
	    {	    
			get { return TotalPages.ToXml<int?>(); }
            set { TotalPages = value.FromXml<int?>(); }
	    }
		
		[XmlIgnore]
		public int? TotalEntries { get; set; }
		
		[XmlElement("total_entries"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _TotalEntriesDto
	    {	    
			get { return TotalEntries.ToXml<int?>(); }
            set { TotalEntries = value.FromXml<int?>(); }
	    }
		
		[XmlIgnore]
		public int? PerPage { get; set; }
		
		[XmlElement("per_page"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _PerPageDto
	    {	    
			get { return PerPage.ToXml<int?>(); }
            set { PerPage = value.FromXml<int?>(); }
	    }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<InvoicesDto>();
        }
		*/
	}
}
