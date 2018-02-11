using Newtonsoft.Json;

namespace ChainSo.NET.Model.Data.Transaction
{
    public class TxConfirmed
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataTxConfirmed Data { get; set; }
    }

    public class DataTxConfirmed
    {
        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("confirmations")]
        public long Confirmations { get; set; }

        [JsonProperty("is_confirmed")]
        public bool IsConfirmed { get; set; }
    }
}
