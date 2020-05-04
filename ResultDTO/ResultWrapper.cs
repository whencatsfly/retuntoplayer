using Newtonsoft.Json;

namespace ConsoleApp1.ResultDTO
{
    public class ResultWrapper<T>
    {
        [JsonProperty(PropertyName = "value")]
        public T Value { get; set; }


    }

}
