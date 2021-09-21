namespace BasicWebServer.Server.Results
{
    using BasicWebServer.Http;

    public class NotFoundResult : HttpResponse
    {
        public NotFoundResult()
            : base(HttpStatusCode.NotFound)
        {
        }
    }
}
