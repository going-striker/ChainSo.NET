using Newtonsoft.Json;

namespace ChainSo.NET.Model.Data
{
    public class Confidence
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataConfidence Data { get; set; }
    }

    public class DataConfidence
    {
        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("confidence")]
        public long Confidence { get; set; }

        [JsonProperty("confirmations")]
        public long Confirmations { get; set; }

        [JsonProperty("nodes")]
        public long Nodes { get; set; }

        [JsonProperty("is_double_spend")]
        public bool IsDoubleSpend { get; set; }
    }
}
