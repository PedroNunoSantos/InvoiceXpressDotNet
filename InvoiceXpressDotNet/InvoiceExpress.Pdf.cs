using System;
using System.ComponentModel;
using System.Net;
using InvoiceXpressDotNet.Extensions;

namespace InvoiceXpressDotNet
{
    // Get pdf methods requires to check is the document is ready first
    // thus this custom implementation
    public static partial class InvoiceExpress
    {
        static class PdfHelper
        {
            internal static HttpResponseInfo Rest_Pdf(string url)
            {
                HttpResponseInfo result = url.HttpGet();
                if (result.StatusCode.IsAnyOf(HttpStatusCode.OK, HttpStatusCode.Accepted))
                    return result;

                throw new Exception(
                    string.Format("Invalid HttpStatusCode. Expected {0} or {1}", HttpStatusCode.OK,
                        HttpStatusCode.Accepted), new Exception(result.Text));
            }

            internal static PdfOutputDto Pdf(HttpResponseInfo responseInfo)
            {
                PdfOutputDto result = null;
                switch (responseInfo.StatusCode)
                {
                    case HttpStatusCode.OK:
                        result = responseInfo.Text.DeserializeXml<PdfOutputDto>();
                        result.IsPdfReady = true;
                        break;
                    case HttpStatusCode.Accepted:
                        result = new PdfOutputDto();
                        result.IsPdfReady = false;
                        break;
                }
                return result;
            }
        }

        public static partial class Invoices
        {
            /// <summary>
            /// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/documents-pdf">Invoices Pdf</a> Method
            /// </summary>
            [EditorBrowsable(EditorBrowsableState.Never)]
            public static HttpResponseInfo Rest_Pdf(string apiKey, string accountName, int invoiceId)
            {
                string url = string.Format("https://{1}.app.invoicexpress.com/api/pdf/{2}.xml?api_key={0}", apiKey,
                    accountName, invoiceId);
                return PdfHelper.Rest_Pdf(url);
            }

            /// <summary>
            /// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/documents-pdf">Invoices Pdf</a> Method
            /// </summary>
            public static PdfOutputDto Pdf(string apiKey, string accountName, int invoiceId)
            {
                return PdfHelper.Pdf(Rest_Pdf(apiKey, accountName, invoiceId));
            }
        }

        public static partial class CreditNotes
        {
            /// <summary>
            /// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/documents-pdf">CreditNotes Pdf</a> Method
            /// </summary>
            [EditorBrowsable(EditorBrowsableState.Never)]
            public static HttpResponseInfo Rest_Pdf(string apiKey, string accountName, string simplifiedInvoiceId)
            {
                string url = string.Format("https://{1}.app.invoicexpress.com/api/pdf/{creditNoteId}.xml?api_key={0}",
                    apiKey, accountName, simplifiedInvoiceId);
                return PdfHelper.Rest_Pdf(url);
            }

            /// <summary>
            /// InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/documents-pdf">CreditNotes Pdf</a> Method
            /// </summary>
            public static PdfOutputDto Pdf(string apiKey, string accountName, string simplifiedInvoiceId)
            {
                return PdfHelper.Pdf(Rest_Pdf(apiKey, accountName, simplifiedInvoiceId));
            }
        }

        public static partial class InvoiceReceipts
        {
            /// <summary>
            /// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/documents-pdf">InvoiceReceipts Pdf</a> Method
            /// </summary>
            [EditorBrowsable(EditorBrowsableState.Never)]
            public static HttpResponseInfo Rest_Pdf(string apiKey, string accountName, int invoiceReceiptId)
            {
                string url = string.Format("https://{1}.app.invoicexpress.com/api/pdf/{2}.xml?api_key={0}", apiKey,
                    accountName, invoiceReceiptId);
                return PdfHelper.Rest_Pdf(url);
            }

            /// <summary>
            /// InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/documents-pdf">InvoiceReceipts Pdf</a> Method
            /// </summary>
            public static PdfOutputDto Pdf(string apiKey, string accountName, int invoiceReceiptId)
            {
                return PdfHelper.Pdf(Rest_Pdf(apiKey, accountName, invoiceReceiptId));
            }
        }

        public static partial class SimplifiedInvoices
        {
            /// <summary>
            /// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/documents-pdf">SimplifiedInvoices Pdf</a> Method
            /// </summary>
            [EditorBrowsable(EditorBrowsableState.Never)]
            public static HttpResponseInfo Rest_Pdf(string apiKey, string accountName, string simplifiedInvoiceId)
            {
                string url = string.Format("https://{1}.app.invoicexpress.com/api/pdf/{2}.xml?api_key={0}", apiKey,
                    accountName, simplifiedInvoiceId);
                return PdfHelper.Rest_Pdf(url);
            }

            /// <summary>
            /// InvoiceXpress <a href="https://invoicexpress.com/api/invoices/documents-pdf">SimplifiedInvoices Pdf</a> Method
            /// </summary>
            public static PdfOutputDto Pdf(string apiKey, string accountName, string simplifiedInvoiceId)
            {
                return PdfHelper.Pdf(Rest_Pdf(apiKey, accountName, simplifiedInvoiceId));
            }
        }
    }
}