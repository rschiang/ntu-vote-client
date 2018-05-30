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

        public static void GetErrorMessage(Exception ex)
        {
            if (ex is WebException) {
                WebException webex = (WebException) ex;
                if (webex.Status == WebExceptionStatus.ProtocolError)
                    try {
                        JObject entity = ParseJson(ex.Response);
                        string code = (string) entity["code"];
                        return String.Format("登入失敗。（錯誤代碼：{0}", code);
                    } catch {
                        // If it's not JSON, do nothing
                    }
            }
            // Fallback to default message
            return String.Format("無法連線到身分驗證系統，請檢查網路連線。\n（{0}）", ex.Message);
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
}
