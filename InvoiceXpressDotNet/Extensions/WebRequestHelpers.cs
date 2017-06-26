using System.IO;
using System.Net;
using System.Text;

namespace InvoiceXpressDotNet.Extensions
{
    public static class WebRequestHelpers
    {
        public static HttpResponseInfo HttpGet(this string destinationUrl, string data = null)
        {
            return HttpRequest(destinationUrl, "GET", data);
        }

        public static HttpResponseInfo HttpPost(this string destinationUrl, string data = null)
        {
            return HttpRequest(destinationUrl, "POST", data);
        }

        public static HttpResponseInfo HttpPut(this string destinationUrl, string data = null)
        {
            return HttpRequest(destinationUrl, "PUT", data);
        }

        public static HttpResponseInfo HttpDelete(this string destinationUrl, string data = null)
        {
            return HttpRequest(destinationUrl, "DELETE", data);
        }

        private static HttpResponseInfo HttpRequest(this string destinationUrl
            , string httpMethod
            , string data = null
            , string contentType = "application/xml; charset=utf-8")
        {
            var request = (HttpWebRequest) WebRequest.Create(destinationUrl);
            request.Method = httpMethod;
	        request.UserAgent = "InvoiceXpressDotNet vs 0.5.0.0";
            if (!string.IsNullOrWhiteSpace(data))
            {
                byte[] dataBytes = Encoding.UTF8.GetBytes(data);
                request.ContentType = contentType;
                request.ContentLength = dataBytes.Length;
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(dataBytes, 0, dataBytes.Length);
                requestStream.Close();
            }

            string responseStr = null;
            HttpStatusCode responseCode;

            try
            {
                using (var response = (HttpWebResponse) request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                {
                    responseCode = response.StatusCode;
                    if (stream != null) responseStr = new StreamReader(stream).ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                using (var exResponse = (HttpWebResponse) ex.Response)
                using (Stream exStream = exResponse.GetResponseStream())
                {
                    responseCode = exResponse.StatusCode;
                    if (exStream != null) responseStr = new StreamReader(exStream).ReadToEnd();
                }
            }

            return HttpResponseInfo.New(responseCode, responseStr);
        }
    }
}