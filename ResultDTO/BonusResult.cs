using Newtonsoft.Json;

namespace ConsoleApp1.ResultDTO
{
    public class BonusDetails
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string BonusId { get; set; }


    }


    public class BonusResult
    {
        [JsonProperty(PropertyName = "isCompleted")]
        public bool BonusCompleted { get; set; }
        [JsonProperty(PropertyName = "win")]
        public string TotalWin { get; set; }
        [JsonProperty(PropertyName = "bet")]
        public string TotalBet { get; set; }
        [JsonProperty(PropertyName = "uniqueID")]
        public string TxnId { get; set; }
        [JsonProperty(PropertyName = "spinResult")]
        public BonusDetails BonusNum { get; set; }
    }
}
