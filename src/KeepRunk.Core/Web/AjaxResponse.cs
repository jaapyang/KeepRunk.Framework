using Newtonsoft.Json;

namespace KeepRunk.Core.Web
{
    public class AjaxResponse
    {
        [JsonProperty("C")]
        public int C { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("d")]
        public object Data { get; set; }
    }
}