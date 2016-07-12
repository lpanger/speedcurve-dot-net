using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpeedCurve
{
    public class AllSitesResponse
    {
        [JsonProperty("sites")]
        public Site[] Sites { get; set; }
    }
}
