namespace BasicWebServer
{
    using System.Threading.Tasks;
    using BasicWebServer.Controllers;
    using BasicWebServer.Http;
    using BasicWebServer.Http.Results;
    using BasicWebServer.Server.Responses;
    using BasicWebServer.Server.Controllers;

    public class Startup
    {
        public static async Task Main()
           => await new HttpServer(routes => routes
               .MapGet<HomeController>("/", c => c.Index())
               .MapGet<HomeController>("/Softuni", c => c.ToSoftUni())
               .MapGet<HomeController>("/ToCats", c => c.ToCats())
               .MapGet<AnimalsController>("/Cats", c => c.Cats())
               .MapGet<AnimalsController>("/Dogs", c => c.Dogs()))
            .Start();
    }
}
