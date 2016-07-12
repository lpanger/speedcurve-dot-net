using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpeedCurve
{
    public class GetDeploymentResponse
    {
        [JsonProperty("deploy_id")]
        public int DeployId { get; set; }
        [JsonProperty("site_id")]
        public int SiteId { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("tests-completed")]
        public TestDetails[] TestsCompleted { get; set; }
        [JsonProperty("tests-remaining")]
        public TestDetails[] TestsRemaining { get; set; }
        [JsonProperty("note")]
        public string Note { get; set; }
        [JsonProperty("detail")]
        public string Detail { get; set; }
    }
}
