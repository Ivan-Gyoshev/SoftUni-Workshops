using SUS.HTTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstMvcApp.Controllers
{
    public class HomeController
    {
        HttpResponse Index(HttpRequest request)
        {
            var responseHtml = "<h1>Welcome!</h1>" + request.Headers.FirstOrDefault(x => x.Name == "User-Agent")?.Value;
            var responseBodyBytes = Encoding.UTF8.GetBytes(responseHtml);
            var response = new HttpResponse("text/html", responseBodyBytes);
            return response;
        }
        HttpResponse About(HttpRequest request)
        {
            var responseHtml = "<h1>About..!</h1>";
            var responseBodyBytes = Encoding.UTF8.GetBytes(responseHtml);
            var response = new HttpResponse("text/html", responseBodyBytes);
            return response;
        }
    }
}
