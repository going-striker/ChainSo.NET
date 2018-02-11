using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChainSo.NET.Model
{
    public class BlockDisplayData
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataBlockDisplayData Data { get; set; }
    }

    public class DataBlockDisplayData
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("block_no")]
        public long BlockNo { get; set; }

        [JsonProperty("confirmations")]
        public long Confirmations { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("sent_value")]
        public string SentValue { get; set; }

        [JsonProperty("fee")]
        public string Fee { get; set; }

        [JsonProperty("mining_difficulty")]
        public string MiningDifficulty { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("blockhash")]
        public string Blockhash { get; set; }

        [JsonProperty("merkleroot")]
        public string Merkleroot { get; set; }

        [JsonProperty("previous_blockhash")]
        public string PreviousBlockhash { get; set; }

        [JsonProperty("next_blockhash")]
        public string NextBlockhash { get; set; }

        [JsonProperty("txs")]
        public List<string> Txs { get; set; }
    }

}
