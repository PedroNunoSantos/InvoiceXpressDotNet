using System.Net;

namespace InvoiceXpressDotNet
{
    public class HttpResponseInfo
    {
        public HttpResponseInfo(HttpStatusCode statusCode, string text)
        {
            StatusCode = statusCode;
            Text = text;
        }

        public HttpStatusCode StatusCode { get; set; }
        public string Text { get; set; }

        public static HttpResponseInfo New(HttpStatusCode statusCode, string text)
        {
            return new HttpResponseInfo(statusCode, text);
        }
    }
}