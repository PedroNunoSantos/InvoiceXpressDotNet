﻿// Connector API InvoiceXpressDotNet developed by EventKey, Lda http://www.eventkey.pt
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using InvoiceXpressDotNet.Extensions;
using InvoiceXpressDotNet.Enums;

namespace InvoiceXpressDotNet.DataTransferObjects
{
	[XmlRoot("proformas"), XmlType(AnonymousType=true)]
	public partial class ProformasDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";

		[XmlElement("proforma")]
		public List<InvoiceDto> Items { get; set; } = new List<InvoiceDto>();
		
		#region Add Methods elpers
		
		public void Add(InvoiceDto item) => Items.Add(item);

		public void AddRange(IEnumerable<InvoiceDto> items) => Items.AddRange(items);
		
		#endregion

		
		[XmlIgnore]
		public int? CurrentPage { get; set; }
		
		//serialization helper for CurrentPage
		[XmlElement("current_page"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _CurrentPageDto
	    {	    
			get { return CurrentPage.ToXml<int?>(); }
            set { CurrentPage = value.FromXml<int?>(); }
	    }

		[XmlIgnore]
		public int? TotalPages { get; set; }
		
		//serialization helper for TotalPages
		[XmlElement("total_pages"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _TotalPagesDto
	    {	    
			get { return TotalPages.ToXml<int?>(); }
            set { TotalPages = value.FromXml<int?>(); }
	    }

		[XmlIgnore]
		public int? TotalEntries { get; set; }
		
		//serialization helper for TotalEntries
		[XmlElement("total_entries"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _TotalEntriesDto
	    {	    
			get { return TotalEntries.ToXml<int?>(); }
            set { TotalEntries = value.FromXml<int?>(); }
	    }

		[XmlIgnore]
		public int? PerPage { get; set; }
		
		//serialization helper for PerPage
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
			me = xml.DeserializeXml<ProformasDto>();
        }
		*/
	}
}
