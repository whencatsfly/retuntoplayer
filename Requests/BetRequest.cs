using ConsoleApp1.Utils;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;

namespace ConsoleApp1.Requests
{
    public class BetRequest : Client
    {
        public string[] GetBetsRequest(Configurations config)
        {
            var betsValuesResponse = String.Empty;
            var betParams = $"game={config.gameName}&key={config.TokenKey}&ts={config.TimeStamp}";
            var GetBetsRequest = (HttpWebRequest)WebRequest.Create(Configurations.GetBetsEndpoint + betParams);
            GetBetsRequest.Method = Method.ToString();
            GetBetsRequest.ContentLength = 0;
            GetBetsRequest.ContentType = ContentType;


            using (var betResponse = (HttpWebResponse)GetBetsRequest.GetResponse())
            {
                if (betResponse.StatusCode != HttpStatusCode.OK)
                {
                    var bMessage = String.Format("Failed: received HTTP{0}", betResponse.StatusCode);
                    throw new ApplicationException(bMessage);
                }

                using (var responseStream = betResponse.GetResponseStream())
                {
                    if (responseStream != null)
                        using (var reader = new StreamReader(responseStream))
                        {

                            
                            betsValuesResponse = reader.ReadToEnd();
                            JObject o = JObject.Parse(betsValuesResponse);

                            var bets = (JArray)o["value"]["coins"];
                            return bets.ToObject<String[]>();

                            // foreach (var bet in Configurations.BetList)
                            // {
                            //    Configurations.Bet = (string)bet;
                            //Console.WriteLine(Configurations.Bet);
                            //   }


                        }
                    {

                    }
                }
            }
            return null;
        }
    }
}
