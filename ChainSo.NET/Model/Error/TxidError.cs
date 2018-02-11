using Newtonsoft.Json;

namespace ChainSo.NET.Model.Error
{
    public class TxidError
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataTxidError Data { get; set; }
    }

    public class TxidInputError
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataTxidInputError Data { get; set; }
    }

    public class TxidOutputError
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataTxidOutputError Data { get; set; }
    }
    public class DataTxidError
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("txid")]
        public string Txid { get; set; }
    }

    public class DataTxidInputError : DataTxidError
    {
        [JsonProperty("input_no")]
        public string InputNo { get; set; }

    }

    public class DataTxidOutputError : DataTxidError
    {
        [JsonProperty("output_no")]
        public string OutputNo { get; set; }
    }
}
