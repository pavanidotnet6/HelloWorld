using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }


        public static string HelloWorldFunction(string inputext)
        {

            string baseURL = "http://localhost:51858/";
            inputext = "Hello world!";

            string URL = string.Format("{0}/api/HelloWorld/HelloWorld?ci=", baseURL);
            var resonse = Post(URL, inputext);

            //Console.Write(response);
            //Console.Read();

            return resonse;

        }

        /// <summary>
        /// This function is used to call Web API
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="json"></param>
        /// <returns></returns>
        private static string Post(string endpoint, string json)
        {
            // Create string to hold JSON response
            string response = string.Empty;

            using (var client = new System.Net.WebClient())
            {
                try
                {
                    client.UseDefaultCredentials = true;
                    client.Headers.Add("Content-Type:application/json");
                    client.Headers.Add("Accept:application/json");
                    var uri = new Uri(endpoint);
                    response = client.UploadString(uri, "POST", json);
                }
                catch (WebException ex)
                {
                    if (ex.Status == WebExceptionStatus.Timeout)
                    {
                        throw new Exception(string.Format("TimeOut : Error calling {0} endpoint. Message {1}", endpoint, ex.Message), ex);
                    }
                    // Http Error
                    if (ex.Status == WebExceptionStatus.ProtocolError)
                    {
                        HttpWebResponse wrsp = (HttpWebResponse)ex.Response;
                        var msg = wrsp.StatusDescription;
                        throw new Exception(string.Format("EndPoint {0}. Message {1}", endpoint, msg), ex);
                    }
                    else
                    {
                        throw new Exception(string.Format("Error calling {0} endpoint.", endpoint), ex);
                    }
                }
            }

            return response;
        }
        /// <summary>
        /// CallRestMethod
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            webrequest.Headers.Add("Username", "xyz");
            webrequest.Headers.Add("Password", "abc");
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }

    }
}
