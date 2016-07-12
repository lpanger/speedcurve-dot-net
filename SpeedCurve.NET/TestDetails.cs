using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpeedCurve
{
    public class TestDetails
    {
        [JsonProperty("test")]
        public string TestId { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }
        [JsonProperty("browser")]
        public string BrowserType { get; set; }
    }
}
