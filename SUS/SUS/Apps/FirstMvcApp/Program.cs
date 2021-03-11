using System;
using SUS.HTTP;
using System.Threading.Tasks;
using FirstMvcApp.Controllers;

namespace FirstMvcApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IHttpServer server = new HttpServer();

            server.AddRoute("/", new HomeController().Index);
            server.AddRoute("/favicon.ico", new StaticFilesController().Favicon);
            server.AddRoute("/about", new HomeController().About);
            server.AddRoute("/users/login", new UsersController().Login);
            server.AddRoute("/users/register", new UsersController().Register);
            // Start localhost with program
            //Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe","http://localhost/");
            await server.StartAsync(80);
        }  
    }
}
