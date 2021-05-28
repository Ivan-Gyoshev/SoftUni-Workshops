namespace BasicWebServer.Http
{
    public class HttpRequest
    {
        public HttpMethod Method { get; private set; }

        public string Url { get; private set; }

        public HttpHeaderCollection Headers { get; private set; }

        public string Body { get; set; }

        public static HttpRequest Parse(string request)
        {

        }
    }
}