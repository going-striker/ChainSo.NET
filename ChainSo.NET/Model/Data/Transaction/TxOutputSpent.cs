using Newtonsoft.Json;

namespace ChainSo.NET.Model.Data.Transaction
{
    public class TxOutputSpent
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataTxOutputSpent Data { get; set; }
    }

    public class DataTxOutputSpent
    {
        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("output_no")]
        public long OutputNo { get; set; }

        [JsonProperty("is_spent")]
        public bool IsSpent { get; set; }

        [JsonProperty("spent")]
        public SpentTxOutputSpent Spent { get; set; }
    }

    public class SpentTxOutputSpent
    {
        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("input_no")]
        public long InputNo { get; set; }
    }
}
