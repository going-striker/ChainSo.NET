using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChainSo.NET.Model
{
    public class Block
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataBlock Data { get; set; }
    }

    public class DataBlock
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("blockhash")]
        public string Blockhash { get; set; }

        [JsonProperty("block_no")]
        public long BlockNo { get; set; }

        [JsonProperty("mining_difficulty")]
        public string MiningDifficulty { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("confirmations")]
        public long Confirmations { get; set; }

        [JsonProperty("is_orphan")]
        public bool IsOrphan { get; set; }

        [JsonProperty("txs")]
        public List<string> Txs { get; set; }

        [JsonProperty("merkleroot")]
        public string Merkleroot { get; set; }

        [JsonProperty("previous_blockhash")]
        public string PreviousBlockhash { get; set; }

        [JsonProperty("next_blockhash")]
        public string NextBlockhash { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }
    }
}
