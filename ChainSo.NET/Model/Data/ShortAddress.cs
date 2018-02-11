using Newtonsoft.Json;

namespace ChainSo.NET.Model
{
    public class ShortAddress
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataShortAddress Data { get; set; }

        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
    public class DataShortAddress
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("short")]
        public string Short { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }
}
