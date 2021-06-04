namespace BasicWebServer.Http.Results
{
    using BasicWebServer.Http.Common;
    using BasicWebServer.Server.Responses;
    using System.Text;

    public class TextResponse : ContentResponse
    {

        public TextResponse(string text)
            : base(text, "text/plain; charset=UTF-8")
        {

        }
    }
}
