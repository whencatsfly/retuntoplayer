using Newtonsoft.Json;

namespace ConsoleApp1.ResultDTO
{
    public class Bonus
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string BonusId { get; set; }
    }

    public class SpinResult
    {
        [JsonProperty(PropertyName = "bet")]
        public string TotalBet { get; set; }
        [JsonProperty(PropertyName = "win")]
        public string TotalWin { get; set; }
        [JsonProperty(PropertyName = "uniqueID")]
        public string TxnId { get; set; }
        [JsonProperty(PropertyName = "hasBonus")]
        public bool hasBonus { get; set; }
        [JsonProperty(PropertyName = "bonus")]
        public Bonus Bonus { get; set; }

    }
}
