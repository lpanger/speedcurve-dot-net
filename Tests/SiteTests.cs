using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class SiteTests
    {
        private const string ApiKey = "YOUR_API_KEY";

        [Fact]
        public void GetAllSites_ReturnsAllSites_WhenValidInput()
        {
            var client = new SpeedCurve.Client(ApiKey);
            var sites = client.GetAllSites().Result;
        }

        [Fact]
        public void CreateDeployment_Successful_WhenValidInput()
        {
            var client = new SpeedCurve.Client(ApiKey);
            var resp = client.CreateDeployment(5811).Result;
        }
    }
}
