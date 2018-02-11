using Newtonsoft.Json;

namespace ChainSo.NET.Model.Error
{
    public class AddressSentValueError
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataAddressSentValueError Data { get; set; }
    }

    public class DataAddressSentValueError
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
