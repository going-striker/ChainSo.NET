using Newtonsoft.Json;

namespace ChainSo.NET.Model.Data
{
    public class SendTransaction
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("txid")]
        public string Txid { get; set; }
    }
}
