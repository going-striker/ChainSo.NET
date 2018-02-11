using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChainSo.NET.Model
{
    public class AddressDisplayData
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataAddressDisplayData Data { get; set; }

        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class DataAddressDisplayData
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("balance")]
        public string Balance { get; set; }

        [JsonProperty("received_value")]
        public string ReceivedValue { get; set; }

        [JsonProperty("pending_value")]
        public string PendingValue { get; set; }

        [JsonProperty("total_txs")]
        public long TotalTxs { get; set; }

        [JsonProperty("txs")]
        public List<TxAddressDisplayData> Txs { get; set; }
    }

    public class TxAddressDisplayData
    {
        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("block_no")]
        public long BlockNo { get; set; }

        [JsonProperty("confirmations")]
        public long Confirmations { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("incoming")]
        public Incoming Incoming { get; set; }

        [JsonProperty("outgoing")]
        public Outgoing Outgoing { get; set; }
    }

    public class Incoming
    {
        [JsonProperty("output_no")]
        public long OutputNo { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("spent")]
        public SpentAddressDisplayData Spent { get; set; }

        [JsonProperty("inputs")]
        public List<InputAddressDisplayData> Inputs { get; set; }

        [JsonProperty("req_sigs")]
        public long ReqSigs { get; set; }

        [JsonProperty("script_asm")]
        public string ScriptAsm { get; set; }

        [JsonProperty("script_hex")]
        public string ScriptHex { get; set; }
    }

    public class InputAddressDisplayData
    {
        [JsonProperty("input_no")]
        public long InputNo { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("received_from")]
        public ReceivedFrom ReceivedFrom { get; set; }
    }

    public class ReceivedFrom
    {
        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("output_no")]
        public long OutputNo { get; set; }
    }

    public class SpentAddressDisplayData
    {
        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("input_no")]
        public long InputNo { get; set; }
    }

    public class Outgoing
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("outputs")]
        public List<OutputAddressDisplayData> Outputs { get; set; }
    }

    public class OutputAddressDisplayData
    {
        [JsonProperty("output_no")]
        public long OutputNo { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("spent")]
        public SpentAddressDisplayData Spent { get; set; }
    }
}
