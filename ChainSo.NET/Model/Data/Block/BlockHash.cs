using Newtonsoft.Json;

namespace ChainSo.NET.Model
{
    public class BlockHash
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataBlockHash Data { get; set; }
    }

    public class DataBlockHash
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("blockhash")]
        public string Blockhash { get; set; }

        [JsonProperty("block_no")]
        public long BlockNo { get; set; }
    }
}
