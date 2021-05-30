using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebServer.Http
{
    public class HttpResponse
    {
        public HttpStatusCode StatusCode { get; init; }

        public HttpHeaderCollection Headers { get; set; }

        public string Content { get; init; }
    }
}
