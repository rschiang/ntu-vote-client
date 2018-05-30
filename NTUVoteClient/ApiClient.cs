using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;

namespace NTUOSC.Vote
{
    /// <summary>
    /// Builds and sends API requests to vote server.
    /// </summary>
    internal partial class ApiClient : WebClient
    {
        private static string accountToken;
        private static string apiPath;
        private static string apiFormat;

        public static void SetToken(string token)
        {
            accountToken = "Token " + token;
        }

        public static string FormatApiPath(string method)
        {
            return String.Format(apiFormat, method);
        }

        public static JObject ParseJson(byte[] buffer)
        {
            return JObject.Parse(Encoding.UTF8.GetString(buffer));
        }

        public static ApiError ParseError(Exception ex)
        {
            if (ex is WebException) {
                WebException webex = (WebException) ex;
                if (webex.Status == WebExceptionStatus.ProtocolError)
                    try {
                        JObject entity = ParseJson(ex.Response);

                        ApiError error = new ApiError();
                        error.Code = (string) entity["code"];
                        error.Message = (string) entity["detail"];

                        Program.Log(String.Format("API error {0}\n{1}", error.Code, entity))
                        return error;
                    } catch {
                        // If it's not JSON, do nothing
                    }
            }

            return null;
        }

        public ApiClient() : base()
        {
            this.Encoding = Encoding.UTF8;
            this.BaseAddress = apiPath;
        }

        /// <summary>
        /// Sends an API request.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="values"></param>
        public void SendRequestAsync(string path, NameValueCollection values)
        {
            SendRequestAsync(path, values, null);
        }

        public void SendRequestAsync(string path, NameValueCollection values, object userState)
        {
            if (accountToken != null)
                this.Headers[HttpRequestHeader.Authorization] = accountToken;

            UploadValuesAsync(uri, null, values, userState);
        }

        protected override WebRequest GetWebRequest(Uri uri)
        {
            WebRequest request = base.GetWebRequest(uri);
            request.Timeout = 20 * 1000;    // 20 seconds
            return request;
        }
    }

    internal class ApiError
    {
        public string Code { get; set; }
        public string Message { get; set; }
    }
}
