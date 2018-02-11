using Newtonsoft.Json;

namespace ChainSo.NET.Model
{
   public class NetworkInfo
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataNetworkInfo Data { get; set; }
    }

    public class DataNetworkInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("acronym")]
        public string Acronym { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("symbol_htmlcode")]
        public string SymbolHtmlcode { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("mining_difficulty")]
        public string MiningDifficulty { get; set; }

        [JsonProperty("unconfirmed_txs")]
        public long UnconfirmedTxs { get; set; }

        [JsonProperty("blocks")]
        public long Blocks { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("price_base")]
        public string PriceBase { get; set; }

        [JsonProperty("price_update_time")]
        public long PriceUpdateTime { get; set; }

        [JsonProperty("hashrate")]
        public string Hashrate { get; set; }
    }
}
