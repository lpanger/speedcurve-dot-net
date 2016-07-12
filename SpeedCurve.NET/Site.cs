using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpeedCurve
{
    public class Site
    {
        [JsonProperty("site_id")]
        public int SiteId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("urls")]
        public Url[] Urls { get; set; }
        [JsonProperty("median")]
        public Median[] Median { get; set; }
    }
}
