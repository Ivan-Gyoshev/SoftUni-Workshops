namespace BasicWebServer.Server.Results
{
    using BasicWebServer.Http;
    public class BadRequestResult : HttpResponse
    {
        public class BadRequestResult : HttpResponse
        {
            public BadRequestResult()
                : base(HttpStatusCode.BadRequest)
            {
            }
        }
    }
}
