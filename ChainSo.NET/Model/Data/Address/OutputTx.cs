using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChainSo.NET.Model
{
    public class OutputTx
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataOutputTx Data { get; set; }
    }

    public class DataOutputTx
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("txs")]
        public List<OutTx> Txs { get; set; }
    }

    public class OutTx
    {
        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("output_no")]
        public long OutputNo { get; set; }

        [JsonProperty("script_asm")]
        public string ScriptAsm { get; set; }

        [JsonProperty("script_hex")]
        public string ScriptHex { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confirmations")]
        public long Confirmations { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }
    }
}
