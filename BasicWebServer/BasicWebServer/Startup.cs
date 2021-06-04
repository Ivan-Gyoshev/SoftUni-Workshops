namespace BasicWebServer
{
    using System.Threading.Tasks;
    using BasicWebServer.Http;
    using BasicWebServer.Http.Results;
    using BasicWebServer.Server.Responses;

    public class Startup
    {
        public static async Task Main()
           => await new HttpServer(routes => routes
               .MapGet("/", new TextResponse("Hello from Ivan!"))
               .MapGet("/Cats", new HtmlResponse("<h1>Hello from the cats!</h1>"))
               .MapGet("/Dogs", new HtmlResponse("<h1>Hello from the dogs!</h1>")))
               .Start();
    }
}
