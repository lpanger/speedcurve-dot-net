using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpeedCurve
{
    public class DeploymentInfo
    {
        [JsonProperty("tests-requested")]
        public int TestsRequested { get; set; }
        [JsonProperty("tests-added")]
        public TestInfo[] TestsAdded { get; set; }
    }
}
