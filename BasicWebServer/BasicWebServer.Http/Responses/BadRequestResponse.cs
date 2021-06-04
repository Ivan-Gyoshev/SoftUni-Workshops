namespace BasicWebServer.Server.Responses
{
    using BasicWebServer.Http;
    public class BadRequestResponse : HttpResponse
    {
        public BadRequestResponse()
            : base(HttpStatusCode.BadRequest)
        {
        }
    }
}
