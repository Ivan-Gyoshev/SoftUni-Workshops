namespace BasicWebServer.Server.Results
{
    using BasicWebServer.Http;
    using BasicWebServer.Http.Common;

    public class ContentResult : HttpResponse
    {
        public ContentResult(string content, string contentType)
            : base(HttpStatusCode.OK)
        {
            this.PrepareContent(content,contentType);
        }
    }
}
