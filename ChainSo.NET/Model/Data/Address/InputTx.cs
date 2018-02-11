using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChainSo.NET.Model
{
    public class InputTx
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataInputTx Data { get; set; }
    }

    public class DataInputTx
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("txs")]
        public List<InTx> Txs { get; set; }
    }

    public class InTx
    {
        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("input_no")]
        public long InputNo { get; set; }

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
