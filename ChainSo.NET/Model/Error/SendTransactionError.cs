using Newtonsoft.Json;

namespace ChainSo.NET.Model.Error
{
    public class SendTransactionError
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataSendTransactionError Data { get; set; }
    }

    public class DataSendTransactionError
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("tx_hex")]
        public string TxHex { get; set; }
    }

}
