using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpeedCurve
{
    public class TestInfo
    {
        [JsonProperty("test")]
        public string Test { get; set; }
        [JsonProperty("browser")]
        public string Browser { get; set; }
        [JsonProperty("region")]
        public RegionValue Region { get; set; }
    }

    public class RegionValue
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
