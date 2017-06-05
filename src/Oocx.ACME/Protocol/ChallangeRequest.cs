using Newtonsoft.Json;

namespace Oocx.ACME.Protocol
{
    public class ChallangeRequest
    {
        [JsonProperty("resource")]
        public string Resource => "challenge";

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("tls")]
        public bool Tls { get; set; } = true;

        [JsonProperty("token")]
        public string Token { get; set; }
    }

    public class KeyAuthorizationRequest
    {
        [JsonProperty("resource")]
        public string Resource => "challenge";

        [JsonProperty("keyAuthorization")]
        public string KeyAuthorization { get; set; }        
    }
}