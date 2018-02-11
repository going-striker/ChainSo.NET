using Newtonsoft.Json;

namespace ChainSo.NET.Model.Error
{
    public class CommonError
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
