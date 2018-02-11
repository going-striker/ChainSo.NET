using Newtonsoft.Json;

namespace ChainSo.NET.Model.Error
{
    public class BlockHashError
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataBlockHashError Data { get; set; }
    }

    public class DataBlockHashError
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("block_no")]
        public string BlockNo { get; set; }
    }
}
