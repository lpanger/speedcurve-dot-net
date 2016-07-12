using Newtonsoft.Json;

namespace SpeedCurve
{
    public class Url
    {
        [JsonProperty("url_id")]
        public int UrlId { get; set; }
        [JsonProperty("url")]
        public string FullUrl { get; set; }
    }
}
