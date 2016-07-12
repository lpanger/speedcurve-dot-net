using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpeedCurve
{
    public class CreateDeploymentRequest
    {
        [JsonProperty("site_id")]
        public int SiteId { get; set; }
        [JsonProperty("note")]
        public string Note { get; set; }
        [JsonProperty("detail")]
        public string Detail { get; set; }
    }
}
