using Newtonsoft.Json;

namespace ChainSo.NET.Model
{
    public class ReceivedValue
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataReceivedValue Data { get; set; }
    }

    public class DataReceivedValue
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("confirmed_received_value")]
        public string ConfirmedReceivedValue { get; set; }

        [JsonProperty("unconfirmed_received_value")]
        public string UnconfirmedReceivedValue { get; set; }
    }
}
