using Newtonsoft.Json;

namespace ChainSo.NET.Model.Error
{
    public partial class AddressAfterTxError
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataAddressAfterTxError Data { get; set; }
    }

    public partial class DataAddressAfterTxError
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("after_tx")]
        public string AfterTx { get; set; }
    }
}
