using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChainSo.NET.Model.Data.Transaction
{
    public class TxOutputs
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataTxOutputs Data { get; set; }
    }

    public class DataTxOutputs
    {
        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("outputs")]
        public List<OutputTxOutputs> Outputs { get; set; }
    }

    public class OutputTxOutputs
    {
        [JsonProperty("output_no")]
        public long OutputNo { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string PurpleType { get; set; }

        [JsonProperty("script")]
        public string Script { get; set; }
    }
}
