namespace BasicWebServer.Server.Responses
{
    using BasicWebServer.Http;

    public class NotFoundResponse : HttpResponse
    {
        public NotFoundResponse()
            : base(HttpStatusCode.NotFound)
        {
        }
    }
}
