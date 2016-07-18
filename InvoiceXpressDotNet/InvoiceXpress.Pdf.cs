using System;
using System.ComponentModel;
using System.Net;
using InvoiceXpressDotNet.DataTransferObjects;
using InvoiceXpressDotNet.Extensions;

namespace InvoiceXpressDotNet
{
    // Get pdf methods requires to check if the the document is ready first
    // thus this custom implementation
    public static partial class InvoiceXpress
    {
        private static class PdfHelper
        {
            public static HttpResponseInfo Rest_Pdf(string apiKey, string accountName, int documentId)
            {
                string url = string.Format("https://{1}.app.invoicexpress.com/api/pdf/{2}.xml?api_key={0}", apiKey,
                    accountName, documentId);
                HttpResponseInfo result = url.HttpGet();
                if (result.StatusCode.IsAnyOf(HttpStatusCode.OK, HttpStatusCode.Accepted))
                    return result;

                throw new Exception(
                    string.Format("Invalid HttpStatusCode. Expected {0} or {1}", HttpStatusCode.OK,
                        HttpStatusCode.Accepted), new Exception(result.Text));
            }

            public static PdfOutputDto Pdf(string apiKey, string accountName, int documentId)
            {
                HttpResponseInfo responseInfo = Rest_Pdf(apiKey, accountName, documentId);
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
            ///     InvoiceXpress <a href="https://invoicexpress.com/api/invoices/documents-pdf">Invoices Pdf</a> Method
            /// </summary>
            [EditorBrowsable(EditorBrowsableState.Never)]
            public static HttpResponseInfo Rest_Pdf(string apiKey, string accountName, int invoiceId)
            {
                return PdfHelper.Rest_Pdf(apiKey, accountName, invoiceId);
            }

            /// <summary>
            ///     InvoiceXpress <a href="https://invoicexpress.com/api/invoices/documents-pdf">Invoices Pdf</a> Method
            /// </summary>
            public static PdfOutputDto Pdf(string apiKey, string accountName, int invoiceId)
            {
                return PdfHelper.Pdf(apiKey, accountName, invoiceId);
            }
        }

        public static partial class CreditNotes
        {
            /// <summary>
            ///     InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/documents-pdf">CreditNotes Pdf</a> Method
            /// </summary>
            [EditorBrowsable(EditorBrowsableState.Never)]
            public static HttpResponseInfo Rest_Pdf(string apiKey, string accountName, int simplifiedInvoiceId)
            {
                return PdfHelper.Rest_Pdf(apiKey, accountName, simplifiedInvoiceId);
            }

            /// <summary>
            ///     InvoiceXpress <a href="https://invoicexpress.com/api/credit-notes/documents-pdf">CreditNotes Pdf</a> Method
            /// </summary>
            public static PdfOutputDto Pdf(string apiKey, string accountName, int simplifiedInvoiceId)
            {
                return PdfHelper.Pdf(apiKey, accountName, simplifiedInvoiceId);
            }
        }

        public static partial class InvoiceReceipts
        {
            /// <summary>
            ///     InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/documents-pdf">InvoiceReceipts Pdf</a> Method
            /// </summary>
            [EditorBrowsable(EditorBrowsableState.Never)]
            public static HttpResponseInfo Rest_Pdf(string apiKey, string accountName, int invoiceReceiptId)
            {
                return PdfHelper.Rest_Pdf(apiKey, accountName, invoiceReceiptId);
            }

            /// <summary>
            ///     InvoiceXpress <a href="https://invoicexpress.com/api/invoice-receipt/documents-pdf">InvoiceReceipts Pdf</a> Method
            /// </summary>
            public static PdfOutputDto Pdf(string apiKey, string accountName, int invoiceReceiptId)
            {
                return PdfHelper.Pdf(apiKey, accountName, invoiceReceiptId);
            }
        }

        public static partial class SimplifiedInvoices
        {
            /// <summary>
            ///     InvoiceXpress <a href="https://invoicexpress.com/api/invoices/documents-pdf">SimplifiedInvoices Pdf</a> Method
            /// </summary>
            [EditorBrowsable(EditorBrowsableState.Never)]
            public static HttpResponseInfo Rest_Pdf(string apiKey, string accountName, int simplifiedInvoiceId)
            {
                return PdfHelper.Rest_Pdf(apiKey, accountName, int.MaxValue);
            }

            /// <summary>
            ///     InvoiceXpress <a href="https://invoicexpress.com/api/invoices/documents-pdf">SimplifiedInvoices Pdf</a> Method
            /// </summary>
            public static PdfOutputDto Pdf(string apiKey, string accountName, int simplifiedInvoiceId)
            {
                return PdfHelper.Pdf(apiKey, accountName, simplifiedInvoiceId);
            }
        
        }

        public static partial class Proformas
        {
            /// <summary>
            ///     InvoiceXpress <a href="https://invoicexpress.com/api/proformas/documents-pdf">Proformas Pdf</a> Method
            /// </summary>
            [EditorBrowsable(EditorBrowsableState.Never)]
            public static HttpResponseInfo Rest_Pdf(string apiKey, string accountName, int proformaId)
            {
                return PdfHelper.Rest_Pdf(apiKey, accountName, proformaId);
            }

            /// <summary>
            ///     InvoiceXpress <a href="https://invoicexpress.com/api/proformas/documents-pdf">Proformas Pdf</a> Method
            /// </summary>
            public static PdfOutputDto Pdf(string apiKey, string accountName, int proformaId)
            {
                return PdfHelper.Pdf(apiKey, accountName, proformaId);
            }
        }

    }
}