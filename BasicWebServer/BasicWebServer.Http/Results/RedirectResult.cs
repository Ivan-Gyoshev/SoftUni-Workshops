namespace BasicWebServer.Server.Results
{
    using BasicWebServer.Http;

    public class RedirectResult : HttpResponse
    {
        public RedirectResult(string location)
            : base(HttpStatusCode.Found) => this.Headers.Add("Location", location);
    }
}
