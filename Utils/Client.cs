using ConsoleApp1.Requests;
using static ConsoleApp1.Utils.Enums;
using System;
using System.IO;
using System.Net;
using ConsoleApp1.ResultDTO;
using Newtonsoft.Json;
using ConsoleApp1.Interface;

namespace ConsoleApp1.Utils
{
    public class Client : Configurations
    {
        protected ProgressForm form;

        public Client(ProgressForm form)
        {
            this.form = form;
            Method = Verbs.GET;
            ContentType = "application/JSON";
            PostData = "";
        }
        public Client()
        {

            Method = Verbs.GET;
            ContentType = "application/JSON";
            PostData = "";
        }

        public Client(Verbs method, string postData)
        {

            Method = method;
            ContentType = "text/json";
            PostData = postData;
        }

        public T SlotRequest<T>(string endpoint, string parameters)
        {
            var SpinRequest = (HttpWebRequest)WebRequest.Create(endpoint + parameters);
            SpinRequest.Method = Method.ToString();
            SpinRequest.ContentLength = 0;
            SpinRequest.ContentType = ContentType;
            using (var response = (HttpWebResponse)SpinRequest.GetResponse())
            {

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    var message = String.Format("Failed: Received HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }

                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                        using (var reader = new StreamReader(responseStream))
                        {

                            var responseValue = reader.ReadToEnd();
                            var result = JsonConvert.DeserializeObject<ResultWrapper<T>>(responseValue);

                            return result.Value;
                        }
                }
            }
            return default(T);
        }
    }
}
