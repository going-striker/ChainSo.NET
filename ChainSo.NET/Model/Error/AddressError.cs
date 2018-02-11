using Newtonsoft.Json;

namespace ChainSo.NET.Model.Error
{
    public class AddressError
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataAddressError Data { get; set; }
    }

    public class DataAddressError
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("confirmations")]
        public string Confirmations { get; set; }
    }
}
