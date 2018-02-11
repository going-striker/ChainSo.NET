using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChainSo.NET.Model.Data.Transaction
{
    public class TransactionDisplayData
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataTransactionDisplayData Data { get; set; }

        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class DataTransactionDisplayData
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("blockhash")]
        public string Blockhash { get; set; }

        [JsonProperty("block_no")]
        public long BlockNo { get; set; }

        [JsonProperty("confirmations")]
        public long Confirmations { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("version")]
        public long Version { get; set; }

        [JsonProperty("locktime")]
        public long Locktime { get; set; }

        [JsonProperty("sent_value")]
        public string SentValue { get; set; }

        [JsonProperty("fee")]
        public string Fee { get; set; }

        [JsonProperty("inputs")]
        public List<InputTransactionDisplayData> Inputs { get; set; }

        [JsonProperty("outputs")]
        public List<OutputTransactionDisplayData> Outputs { get; set; }

        [JsonProperty("tx_hex")]
        public string TxHex { get; set; }
    }

    public class InputTransactionDisplayData
    {
        [JsonProperty("input_no")]
        public long InputNo { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("received_from")]
        public ReceivedFrom ReceivedFrom { get; set; }

        [JsonProperty("script_asm")]
        public string ScriptAsm { get; set; }

        [JsonProperty("script_hex")]
        public string ScriptHex { get; set; }
    }

    public class ReceivedFrom
    {
        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("output_no")]
        public long OutputNo { get; set; }
    }

    public class OutputTransactionDisplayData
    {
        [JsonProperty("output_no")]
        public long OutputNo { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public string PurpleType { get; set; }

        [JsonProperty("req_sigs")]
        public long ReqSigs { get; set; }

        [JsonProperty("spent")]
        public SpentTransactionDisplayData Spent { get; set; }

        [JsonProperty("script_asm")]
        public string ScriptAsm { get; set; }

        [JsonProperty("script_hex")]
        public string ScriptHex { get; set; }
    }

    public class SpentTransactionDisplayData
    {
        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("input_no")]
        public long InputNo { get; set; }
    }
}
