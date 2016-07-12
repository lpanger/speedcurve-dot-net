using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpeedCurve
{
    public class CreateDeploymentResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("info")]
        public DeploymentInfo Info { get; set; }
    }
}
