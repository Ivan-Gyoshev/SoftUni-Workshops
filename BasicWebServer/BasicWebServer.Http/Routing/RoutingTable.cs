using System.Collections.Generic;

namespace BasicWebServer.Http
{
    public class RoutingTable : IRoutingTable
    {
        private readonly Dictionary<HttpMethod, Dictionary<string, HttpResponse>> routes;

        public RoutingTable()
        {

        }
        public IRoutingTable Map(string url, HttpMethod method, HttpResponse response)
        {
            throw new System.NotImplementedException();
        }

        public IRoutingTable MapGet(string url, HttpResponse response)
        {
            throw new System.NotImplementedException();
        }
    }
}
