namespace BasicWebServer.Http
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class HttpRequest
    {
        public HttpMethod Method { get; private set; }

        public string Path { get; private set; }

        public Dictionary<string, string> Query { get; private set; }

        public HttpHeaderCollection Headers { get; private set; }

        public string Body { get; set; }

        public static HttpRequest Parse(string request)
        {
            var lines = request.Split(HttpConstants.NewLine);

            var startLine = lines.First().Split(" ");
            var method = ParseHttpMethod(startLine[0]);
            var url = startLine[1];

            var (path, query) = ParseUrl(url);

            var headerCollection = ParseHttpHeaderCollection(lines.Skip(1));

            var bodyLines = lines.Skip(headerCollection.Count + 2).ToArray();

            var body = string.Join(HttpConstants.NewLine, bodyLines);

            return new HttpRequest
            {
                Method = method,
                Path = path,
                Query = query,
                Headers = headerCollection,
                Body = body
            };
        }


        private static HttpMethod ParseHttpMethod(string method)
             => method.ToUpper() switch
             {
                 "GET" => HttpMethod.Get,
                 "POST" => HttpMethod.Post,
                 "PUT" => HttpMethod.Put,
                 "DELETE" => HttpMethod.Delete,
                 _ => throw new InvalidOperationException($"Method '{method}' is not supported."),
             };

        private static (string, Dictionary<string, string>) ParseUrl(string url)
        {
            var urlParts = url.Split('?');

            var path = urlParts[0];
            var query = urlParts.Length > 1
                ? ParseQuery(urlParts[1])
                : new Dictionary<string, string>();

            return (path, query);
        }

        private static Dictionary<string, string> ParseQuery(string queryString) => queryString
                  .Split('&')
                  .Select(p => p.Split("="))
                  .Where(p => p.Length == 2)
                  .ToDictionary(p => p[0], p => p[1]);

        private static HttpHeaderCollection ParseHttpHeaderCollection(IEnumerable<string> headerLines)
        {
            var headerCollection = new HttpHeaderCollection();

            foreach (var headerLine in headerLines)
            {
                if (headerLine == string.Empty)
                {
                    break;
                }
                var headerParts = headerLine.Split(":", 2);

                if (headerParts.Length != 2)
                {
                    throw new InvalidOperationException("Request is not valid.");
                }

                var headerName = headerParts[0];
                var headerValue = headerParts[1].Trim();

                headerCollection.Add(headerName, headerValue);
            }

            return headerCollection;
        }
    }
}