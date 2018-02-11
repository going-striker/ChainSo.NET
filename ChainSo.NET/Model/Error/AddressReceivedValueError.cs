using Newtonsoft.Json;

namespace ChainSo.NET.Model.Error
{
    public class AddressReceivedValueError
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataAddressReceivedValueError Data { get; set; }
    }

    public class DataAddressReceivedValueError
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
