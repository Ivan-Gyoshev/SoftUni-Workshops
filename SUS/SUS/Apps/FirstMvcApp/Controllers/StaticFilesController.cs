using SUS.HTTP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FirstMvcApp.Controllers
{
    public class StaticFilesController
    {
        public HttpResponse Favicon(HttpRequest request)
        {
            var fileBytes = File.ReadAllBytes("wwwroot/favicon.ico");
            var response = new HttpResponse("image/vnd.microsoft.icon", fileBytes);
            return response;
        }

    }
}
