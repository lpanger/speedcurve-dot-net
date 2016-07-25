using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpeedCurve
{
    public class TestResult
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
        [JsonProperty("day")]
        public string Day { get; set; }
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }
        [JsonProperty("test")]
        public string Test { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }
        [JsonProperty("run")]
        public int Run { get; set; }
        [JsonProperty("browser")]
        public string Browser { get; set; }
        [JsonProperty("browser_version")]
        public string BrowserVersion { get; set; }
        [JsonProperty("byte")]
        public int Byte { get; set; }
        [JsonProperty("render")]
        public int Render { get; set; }
        [JsonProperty("dom")]
        public int Dom { get; set; }
        [JsonProperty("loaded")]
        public int Loaded { get; set; }
        [JsonProperty("size")]
        public int Size { get; set; }
        [JsonProperty("image_saving")]
        public int ImageSaving { get; set; }
        [JsonProperty("requests")]
        public int Requests { get; set; }
        [JsonProperty("pagespeed")]
        public int PageSpeed { get; set; }
        [JsonProperty("speedindex")]
        public int SpeedIndex { get; set; }
        [JsonProperty("html_requests")]
        public int HtmlRequests { get; set; }
        [JsonProperty("html_size")]
        public int HtmlSize { get; set; }
        [JsonProperty("css_requests")]
        public int CssRequests { get; set; }
        [JsonProperty("css_size")]
        public int CssSize { get; set; }
        [JsonProperty("js_requests")]
        public int JsRequests { get; set; }
        [JsonProperty("js_size")]
        public int JsSize { get; set; }
        [JsonProperty("image_requests")]
        public int ImageRequests { get; set; }
        [JsonProperty("image_size")]
        public int ImageSize { get; set; }
        [JsonProperty("font_requests")]
        public int FontRequests { get; set; }
        [JsonProperty("font_size")]
        public int FontSize { get; set; }
        [JsonProperty("text_requests")]
        public int TextRequests { get; set; }
        [JsonProperty("text_size")]
        public int TextSize { get; set; }
        [JsonProperty("flash_requests")]
        public int FlashRequests { get; set; }
        [JsonProperty("flash_size")]
        public int FlashSize { get; set; }
        [JsonProperty("other_requests")]
        public int OtherRequests { get; set; }
        [JsonProperty("other_size")]
        public int OtherSize { get; set; }
        [JsonProperty("har")]
        public string Har { get; set; }
        [JsonProperty("screen")]
        public string Screen { get; set; }
    }
}
