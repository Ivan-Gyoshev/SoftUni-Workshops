namespace BasicWebServer.Controllers
{
    using BasicWebServer.Http;
    using BasicWebServer.Http.Results;
    using BasicWebServer.Server;

    public class HomeController : Controller
    {
        public HomeController(HttpRequest request) 
            : base(request)
        {
        }

        public HttpResponse Index() => Text("Hello from Ivan!");

        public HttpResponse ToCats() => Redirect("/Cats");

        public HttpResponse ToSoftUni() => Redirect("https://softuni.bg");
    }
}
