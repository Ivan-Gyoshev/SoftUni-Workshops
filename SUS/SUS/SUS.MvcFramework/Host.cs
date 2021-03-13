using SUS.HTTP;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SUS.MvcFramework
{
    public class Host
    {
        public static async Task RunAsync(List<Route> routeTable, int port = 80)
        {
            IHttpServer server = new HttpServer(routeTable);
            // Start localhost with program
            //Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe","http://localhost/");

            await server.StartAsync(port);
        }
    }
}
