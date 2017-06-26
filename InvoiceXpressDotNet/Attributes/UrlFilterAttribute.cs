using System;

namespace InvoiceXpressDotNet.Attributes
{
    public class UrlFilterAttribute : Attribute
    {
	    public UrlFilterAttribute(string name)
	    {
		    Name = name;
	    }

	    public string Name { get; set; }
    }
}
