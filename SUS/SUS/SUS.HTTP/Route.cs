using SUS.HTTP;
using System;
using System.Collections.Generic;
using System.Text;

namespace SUS.HTTP
{
    public class Route
    {
        public Route(string path, Func<HttpRequest, HttpResponse> action)
        {
            this.Path = path;
            this.Action = action;
        }
        public string Path { get; set; }

        public Func<HttpRequest, HttpResponse> Action { get; set; }
    }
}
