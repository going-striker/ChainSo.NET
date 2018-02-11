using Newtonsoft.Json;

namespace ChainSo.NET.Model
{
    public class AddressValid
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataAddressValid Data { get; set; }
    }

    public class DataAddressValid
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("is_valid")]
        public bool IsValid { get; set; }
    }

}
