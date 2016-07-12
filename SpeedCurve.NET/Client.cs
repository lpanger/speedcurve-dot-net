using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpeedCurve
{
    public class Client
    {
        private const string BaseUrl = "https://api.speedcurve.com";
        private const string ApiVersion = "/v1";

        private const string SitesEndpoint = "/sites";
        private const string DeployEndpoint = "/deploy";
        private const string TestsEndpoint = "/tests";

        private string _apiKey;
        private string _authHeader;

        public Client(string apiKey)
        {
            _apiKey = apiKey;
            _authHeader = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{_apiKey}:x"));
        }

        public async Task<AllSitesResponse> GetAllSitesAsync(int days = 14) // 14 is speedcurve set default
        {
            var parameters = $"{ApiVersion}{SitesEndpoint}?days={days}";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _authHeader);

                var result = await client.GetAsync(parameters);

                return JsonConvert.DeserializeObject<AllSitesResponse>(await result.Content.ReadAsStringAsync());
            }
        }

        public async Task<CreateDeploymentResponse> CreateDeploymentAsync(int siteId, string note = null, string detail = null)
        {
            var parameters = $"{ApiVersion}{DeployEndpoint}";

            var request = new CreateDeploymentRequest
            {
                SiteId = siteId
            };

            if (!string.IsNullOrEmpty(note))
            {
                request.Note = note;
            }

            if (!string.IsNullOrEmpty(detail))
            {
                request.Detail = detail;
            }

            var body = JsonConvert.SerializeObject(request, Formatting.None,
                new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore});

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _authHeader);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                var reqMsg = new HttpRequestMessage(HttpMethod.Post, parameters);
                reqMsg.Content = new StringContent(body, Encoding.UTF8, "application/json");

                var result = await client.SendAsync(reqMsg);

                return JsonConvert.DeserializeObject<CreateDeploymentResponse>(await result.Content.ReadAsStringAsync());
            }
        }

        public async Task<GetDeploymentResponse> GetDeploymentAsync(int deploymentId)
        {
            var parameters = $"{ApiVersion}{DeployEndpoint}/{deploymentId}";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _authHeader);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await client.GetAsync(parameters);

                return JsonConvert.DeserializeObject<GetDeploymentResponse>(await result.Content.ReadAsStringAsync());
            }
        }

        public async Task<TestResult> GetTestResultsAsync(string testId)
        {
            var parameters = $"{ApiVersion}{TestsEndpoint}/{testId}";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _authHeader);

                var result = await client.GetAsync(parameters);

                return JsonConvert.DeserializeObject<TestResult>(await result.Content.ReadAsStringAsync());
            }
        }
    }
}
