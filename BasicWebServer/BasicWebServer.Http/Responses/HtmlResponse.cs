using BasicWebServer.Http.Results;

namespace BasicWebServer.Server.Responses
{
    public class HtmlResponse : ContentResponse
    {
        public HtmlResponse(string text) 
            : base(text, "text/html; charset=UTF-8")
        {
        }
    }
}
