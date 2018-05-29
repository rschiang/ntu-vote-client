using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace NTUOSC.Vote
{
    /// <summary>
    /// Builds and sends API requests to vote server.
    /// </summary>
    internal partial class ApiClient : WebClient
    {
        private static string accountToken;
        private static Uri apiPath;

        public static void SetToken(string token)
        {
            accountToken = "Token " + token;
        }

        public ApiClient()
        {
            this.Encoding = Encoding.UTF8;
        }
        
        /// <summary>
        /// Sends an API request.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="values"></param>
        public void SendRequestAsync(string path, NameValueCollection values)
        {
            if (accountToken != null)
                this.Headers[HttpRequestHeader.Authorization] = accountToken;

            Uri uri = new Uri(apiPath, path);
            this.UploadValuesAsync(uri, values);
        }
    }
}
