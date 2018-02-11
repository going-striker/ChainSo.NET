using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChainSo.NET.Model.Data.Transaction
{
    public class TxInputs
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataTxInputs Data { get; set; }
    }

    public class DataTxInputs
    {
        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("inputs")]
        public List<InputTxInputs> Inputs { get; set; }
    }

    public class InputTxInputs
    {
        [JsonProperty("from_output")]
        public FromOutput FromOutput { get; set; }

        [JsonProperty("input_no")]
        public long InputNo { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string PurpleType { get; set; }

        [JsonProperty("script")]
        public string Script { get; set; }
    }

    public class FromOutput
    {
        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("output_no")]
        public long OutputNo { get; set; }
    }
}
