namespace BasicWebServer.Http.Results
{
    using BasicWebServer.Http.Common;
    using BasicWebServer.Server.Http;
    using BasicWebServer.Server.Results;
    using System.Text;

    public class TextResult : ContentResult
    {

        public TextResult(string text)
            : base(text, HttpContentType.PlainText)
        {
        }
    }
}
