using Newtonsoft.Json;

namespace ChainSo.NET.Model
{
    public class Balance
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataBalance Data { get; set; }
    }

    public class DataBalance
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("confirmed_balance")]
        public string ConfirmedBalance { get; set; }

        [JsonProperty("unconfirmed_balance")]
        public string UnconfirmedBalance { get; set; }
    }
}
