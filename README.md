# InvoiceXpressDotNet
**InvoiceXpress** API port to .net.

This implementation is based on the information at [https://invoicexpress.com/api](https://invoicexpress.com/api)
InvoiceXpress API from [http://invoicexpress.com](http://invoicexpress.com)

The source code is almost totally generated with [**T4 Text Templates**](https://msdn.microsoft.com/en-us/library/bb126445.aspx), to facilitate the generation of the data transfer objects.

The xml de/serialization is handled by [XmlSerializer](https://msdn.microsoft.com/en-us/library/system.xml.serialization.xmlserializer(v=vs.110).aspx) with some fiddling to make everything works.

## How to use

First of all, you need a [invoiceXpress account and a api key](https://invoicexpress.com/api/overview). 
From there you can get the following data needed to make tht api calls

```cs
string _accountName = "your account name here";
string _apiKey = "your api key here";
string _accountId = "your accountId key here";
```

To use this api just call the nested static methods inside each module class, like so :

**InvoiceXpress.Invoices**
```cs
InvoiceXpress.Invoices.List(...);
InvoiceXpress.Invoices.Create(...);
InvoiceXpress.Invoices.Update(...);
...
```
**InvoiceXpress.CreditNotes**
```cs
InvoiceXpress.CreditNotes.List(...); 
InvoiceXpress.CreditNotes.Create(...); 
InvoiceXpress.CreditNotes.Update(...);
...
```
## Examples
### [Invoices](https://invoicexpress.com/api/invoices/)
##### Create and finalize a Invoice
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
invoice.Items = new ItemsDto { Items = new[] { item1, item2 } };

// create the invoice
InvoiceDto invoiceReturnData = InvoiceXpress.Invoices.Create(_apiKey, _accountName, invoice);

// consume the returned data
Console.WriteLine(invoiceReturnData);
```

##### List All
```cs
InvoicesDto invoices = InvoiceXpress.Invoices.List(_apiKey, _accountName);
foreach (InvoiceDto invoice in invoices.Items)
    Console.WriteLine(invoice.Id);
```

##### Get the invoice Pdf
```cs
var pdfData = InvoiceXpress.Invoices.Pdf(_apiKey, _accountName, invoiceId);
// check if the pdf id ready to be downloaded, if not you will need to try again later
if (pdfData.IsPdfReady)
{
    string downloadTo = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop), Guid.NewGuid() + ".pdf");
    using (var wc = new WebClient())
        wc.DownloadFile(pdfData.Pdfurl, downloadTo);
		
    //Process.Start(downloadTo);
}
else 
    Console.WriteLine("Document is not ready yet, try again later.");

```

### [Invoice Receipt](https://invoicexpress.com/api/invoice-receipt/create)
##### Create and finalize a Invoice Receipt
*pretty much the same as the Invoices.Create method*

```cs
var invoiceReceipt = new InvoiceReceiptDto();
invoiceReceipt.Date = DateTime.Today;
invoiceReceipt.DueDate = DateTime.Today.AddMonths(1);

// Create/associate the customer
var client = new ClientDto();
client.Name = "Some Customer";
invoiceReceipt.Client = client;
invoiceReceipt.Observations = "Generated with InvoiceXpressDotNet";

// Create some items for the invoice
var produt1 = new ItemDto();
produt1.Name = "Some amazing product";
produt1.UnitPrice = 200;
produt1.Quantity = 1;
produt1.Discount = 5.5F;

var gift = new ItemDto();
gift.Name = "Gift";
gift.UnitPrice = 0;
gift.Quantity = 1;

// add itens to the invoice
invoiceReceipt.Items = new ItemsDto { Items = new[] { produt1, gift } };

// create the invoice
InvoiceReceiptDto createdInvoiceReceipt = InvoiceXpress.InvoiceReceipts.Create(_apiKey, _accountName, invoiceReceipt);
Console.WriteLine(createdInvoiceReceipt);

var stateChange = new InvoiceReceiptChangeStateDto { State = DocumentState.Finalized };
if (createdInvoiceReceipt.Id.HasValue)
{
    InvoiceReceiptChangeStateDto state = InvoiceXpress.InvoiceReceipts.ChangeState(_apiKey, _accountName, createdInvoiceReceipt.Id.Value, stateChange);
    Console.WriteLine(state)
}
```
