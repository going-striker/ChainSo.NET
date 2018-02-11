using Newtonsoft.Json;

namespace ChainSo.NET.Model.Error
{
    public class BlockError
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataBlockError Data { get; set; }
    }

    public class DataBlockError
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("blockid")]
        public string Blockid { get; set; }
    }
}
