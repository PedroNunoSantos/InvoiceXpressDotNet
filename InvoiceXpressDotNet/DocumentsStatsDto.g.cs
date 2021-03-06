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
	[XmlRoot("documents"), XmlType(AnonymousType=true)]
	public partial class DocumentsStatsDto : Dto
	{		

		[XmlIgnore]
		public int? UsedDocuments { get; set; }
		
		//serialization helper for UsedDocuments
		[XmlElement("used_documents"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _UsedDocumentsDto
	    {	    
			get { return UsedDocuments.ToXml<int?>(); }
            set { UsedDocuments = value.FromXml<int?>(); }
	    }

		[XmlIgnore]
		public int? AvailableDocuments { get; set; }
		
		//serialization helper for AvailableDocuments
		[XmlElement("available_documents"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _AvailableDocumentsDto
	    {	    
			get { return AvailableDocuments.ToXml<int?>(); }
            set { AvailableDocuments = value.FromXml<int?>(); }
	    }

		[XmlIgnore]
		public int? UsedApiDocuments { get; set; }
		
		//serialization helper for UsedApiDocuments
		[XmlElement("used_api_documents"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _UsedApiDocumentsDto
	    {	    
			get { return UsedApiDocuments.ToXml<int?>(); }
            set { UsedApiDocuments = value.FromXml<int?>(); }
	    }

		[XmlIgnore]
		public int? AvailableApiDocuments { get; set; }
		
		//serialization helper for AvailableApiDocuments
		[XmlElement("available_api_documents"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _AvailableApiDocumentsDto
	    {	    
			get { return AvailableApiDocuments.ToXml<int?>(); }
            set { AvailableApiDocuments = value.FromXml<int?>(); }
	    }

		[XmlIgnore]
		public int? UsedWebDocuments { get; set; }
		
		//serialization helper for UsedWebDocuments
		[XmlElement("used_web_documents"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _UsedWebDocumentsDto
	    {	    
			get { return UsedWebDocuments.ToXml<int?>(); }
            set { UsedWebDocuments = value.FromXml<int?>(); }
	    }

		[XmlIgnore]
		public int? AvailableWebDocuments { get; set; }
		
		//serialization helper for AvailableWebDocuments
		[XmlElement("available_web_documents"), EditorBrowsableAttribute(EditorBrowsableState.Never), Browsable(false)]
	    public string _AvailableWebDocumentsDto
	    {	    
			get { return AvailableWebDocuments.ToXml<int?>(); }
            set { AvailableWebDocuments = value.FromXml<int?>(); }
	    }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<DocumentsStatsDto>();
        }
		*/
	}
}
