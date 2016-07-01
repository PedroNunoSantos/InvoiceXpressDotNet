# InvoiceXpressDotNet
**InvoiceXpress** API port to .net.

This implementation is based on the information at [https://invoicexpress.com/api](https://invoicexpress.com/api)
InvoiceXpress API from [http://invoicexpress.com](http://invoicexpress.com)

The source code is almost totally auto generated with [**T4 Text Templates**](https://msdn.microsoft.com/en-us/library/bb126445.aspx), to facilitate the generation of the data transfer objects.

The xml de/serialization is handled by [XmlSerializer](https://msdn.microsoft.com/en-us/library/system.xml.serialization.xmlserializer(v=vs.110).aspx) with some fiddling to make everything works.

## How to use

First of all, you need a [invoiceXpress account and a api key](https://invoicexpress.com/api/overview).

To use this api just call the nested static methods inside each module class.

**InvoiceXpress.Invoices**
```cs
InvoiceXpress.Invoices.ListTyped();
InvoiceXpress.Invoices.CreateTyped(...);
InvoiceXpress.Invoices.UpdateTyped(...);
...
```
**InvoiceXpress.CreditNotes**
```cs
InvoiceXpress.CreditNotes.ListTyped(); 
InvoiceXpress.CreditNotes.CreateTyped(...); 
InvoiceXpress.CreditNotes.UpdateTyped(...); 
...
```
## Examples
### [Invoices](https://invoicexpress.com/api/invoices/)
##### Create
```cs
var invoice = new InvoiceDto();
invoice.Date = DateTime.Today;
invoice.DueDate = DateTime.Today.AddMonths(1);

// Create/associate the customer
var client = new ClientDto();
client.Name = "Some Customer";
invoice.Client = client;
invoice.Observations = "Generated with InvoiceXpressDotNet";

// Create some items for the invoice
var item1 = new ItemDto();
item1.Name = "Some amazing product";
item1.UnitPrice = 100;
item1.Quantity = 1;
item1.Discount = 5.5F;

var item2 = new ItemDto();
item2.Name = "Some not so amazing product";
item2.UnitPrice = 0;
item2.Quantity = 1;

// add itens to the invoice
invoice.ItemsArray = new ItemsDto { ItemsArray = new[] { item1, item2 } };

InvoiceDto invoiceReturnData = InvoiceExpress.Invoices.CreateTyped(_apiKey, _accountName, invoice);

// consume the returned data
Console.WriteLine(invoiceReturnData);
```
##### List
```cs
InvoicesDto invoices = InvoiceExpress.Invoices.ListTyped(_apiKey, _accountName);
// consume the data
Console.WriteLine(invoices);
```
more examples later..
