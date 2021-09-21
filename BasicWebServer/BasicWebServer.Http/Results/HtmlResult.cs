using BasicWebServer.Server.Http;

namespace BasicWebServer.Server.Results
{
    public class HtmlResult : ContentResult
    {
        public HtmlResult(string text) 
            : base(text, HttpContentType.Html)
        {
        }
    }
}
