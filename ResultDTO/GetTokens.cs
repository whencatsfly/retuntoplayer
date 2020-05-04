using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ResultDTO
{
    public class GetTokens
    {

        [JsonProperty(PropertyName = "accessToken")]
        public string TotalBet { get; set; }
    }

}
