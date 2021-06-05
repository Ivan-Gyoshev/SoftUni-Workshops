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
               .MapGet("/Cats", request =>
               {
                   const string nameKey = "Name";

                   var query = request.Query;

                   var catName = query.ContainsKey(nameKey)
                   ? query[nameKey]
                   : "the cats";

                   var result = $"<h1>Hello from the {catName}!</h1>";

                   return new HtmlResponse(result);
               })
               .MapGet("/Dogs", new HtmlResponse("<h1>Hello from the dogs!</h1>")))
               .Start();
    }
}
