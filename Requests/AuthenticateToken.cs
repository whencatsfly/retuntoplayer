using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Requests
{
    public class AuthenticateToken
    {
        public IList<string> AuthTokens(Configurations config)
        {
            var results = new List<string>();
            foreach (string key in config.TokenNames)
            {
                var parameter = $"?data=%7B%22password%22%3A%22{Configurations.password}%22%2C%22_platform%22%3A%22mobile%22%2C%22operatorCode%22%3A%221%22%2C%22username%22%3A%22{key}%22%2C%22fromFriendInvite%22%3Afalse%7D%26v%3D1525246821524";
                var tokenRequest = (HttpWebRequest)WebRequest.Create(Configurations.GetTokenEndpoint + parameter);
                JArray array = new JArray();
                using (var twitpicResponse = (HttpWebResponse)tokenRequest.GetResponse())
                {

                    using (var reader = new StreamReader(twitpicResponse.GetResponseStream()))
                    {
                        var objText = reader.ReadToEnd();

                        JObject joResponse = JObject.Parse(objText);

                        var dataStr = joResponse["data"];
                        var data = JObject.Parse(dataStr.ToString());
                        var accessToken = data["accessToken"];


                        results.Add(accessToken.ToString());
     
                        var authenticationParameter = $"?op=&token={accessToken}&ts={config.TimeStamp}";
                        var authRequest = (HttpWebRequest)WebRequest.Create(Configurations.GetAuthenticationEndpoint + authenticationParameter);
                        var authResponse = (HttpWebResponse)authRequest.GetResponse();
                        var readerRequest = new StreamReader(authResponse.GetResponseStream());
                        var objText1 = readerRequest.ReadToEnd();

                        JObject joResponse1 = JObject.Parse(objText1);

                    }

                }
            }
            return results;

        }
    }
}
