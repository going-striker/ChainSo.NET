using Newtonsoft.Json;

namespace ChainSo.NET.Model
{
    public class SpentValue
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataSpentValue Data { get; set; }
    }

    public class DataSpentValue
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("confirmed_sent_value")]
        public string ConfirmedSentValue { get; set; }

        [JsonProperty("unconfirmed_sent_value")]
        public string UnconfirmedSentValue { get; set; }
    }
}
