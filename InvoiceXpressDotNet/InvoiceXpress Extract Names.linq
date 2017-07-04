<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\Accessibility.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Configuration.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Deployment.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.Formatters.Soap.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Security.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
  <Namespace>System.Windows.Forms</Namespace>
</Query>

void Main()
{
	var clipboard = Clipboard.GetText();
	if (string.IsNullOrWhiteSpace(clipboard)) return;

	var xmlRoot = XDocument.Parse(clipboard).Root;

	var items = from e in xmlRoot.Elements()
							let IsClass = e.Elements().Count() > 0
							let cSharpName = Pascalize(e.Name.LocalName)
							select new { XmlName = e.Name.LocalName, CSharpName = cSharpName, Type = IsClass ? cSharpName + "Dto" : "string" };

	/*
	 <Type XmlName="account" Name="AccountDto">
				<Property XmlName="first_name" Name="FirstName" Type="string" />
				...
	*/
	new XElement("Type", new XAttribute("XmlName", xmlRoot.Name.LocalName), new XAttribute("Name", xmlRoot.Name.LocalName.Pascalize() + "Dto"),
		items.Select(l => new XElement("Property", new XAttribute("XmlName", l.XmlName), new XAttribute("Name", l.CSharpName), new XAttribute("Type", l.Type)))
		).Dump();
	/*
		var item = new { LocalName = root.Name.LocalName, CSharpName = Pascalize(root.Name.LocalName), Type = "class" };
		lst.Insert(0, item);
		lst.Add(new { LocalName = "", CSharpName = "", Type = "end_class" });
		lst.Dump();
	*/

}

private string Pascalize(string value)
{
	Regex rx = new Regex(@"(?:^|[^a-zA-Z]+)(?<first>[a-zA-Z])(?<reminder>[a-zA-Z0-9]+)");
	return rx.Replace(value , m => m.Groups["first"].ToString().ToUpper() + m.Groups["reminder"].ToString().ToLower());
}