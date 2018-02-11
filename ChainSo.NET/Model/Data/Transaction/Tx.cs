using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChainSo.NET.Model.Data.Transaction
{
    public class Tx
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataTx Data { get; set; }
    }

    public class DataTx
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("blockhash")]
        public string Blockhash { get; set; }

        [JsonProperty("confirmations")]
        public long Confirmations { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("inputs")]
        public List<InputTx> Inputs { get; set; }

        [JsonProperty("outputs")]
        public List<OutputTx> Outputs { get; set; }

        [JsonProperty("tx_hex")]
        public string TxHex { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("version")]
        public long Version { get; set; }

        [JsonProperty("locktime")]
        public long Locktime { get; set; }
    }

    public class InputTx
    {
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

        [JsonProperty("from_output")]
        public FromOutputTx FromOutput { get; set; }
    }

    public class FromOutputTx
    {
        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("output_no")]
        public long OutputNo { get; set; }
    }

    public class OutputTx
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
