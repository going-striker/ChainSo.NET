using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChainSo.NET.Model
{
    public class Price
    {
        [JsonProperty("price")]
        public string PurplePrice { get; set; }

        [JsonProperty("price_base")]
        public string PriceBase { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public DataPrices Data { get; set; }     
    }
    public class DataPrices
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("prices")]
        public List<Price> Prices { get; set; }
    }
}
