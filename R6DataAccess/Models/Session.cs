using System;
using System.Text.Json.Serialization;

namespace R6Sharp.Response
{
    public class Session : ISession
    {
        [JsonPropertyName("platformType")]
        public string PlatformType { get ; set; }
        
        [JsonPropertyName("ticket")]
        public string Ticket { get ; set ; }
        [JsonPropertyName("profileId")]
        public Guid ProfileId { get ; set ; }
        [JsonPropertyName("userId")]
        public Guid UserId { get ; set; }
        [JsonPropertyName("nameOnPlatform")]
        public string NameOnPlatform { get ; set ; }
        [JsonPropertyName("environment")]
        public string Environment { get ; set ; }
        [JsonPropertyName("expiration")]
        public DateTime Expiration { get ; set ; }
        [JsonPropertyName("clientIp")]
        public string ClientIp { get ; set ; }
        [JsonPropertyName("clientIpCountry")]
        public string ClientIpCountry { get ; set ; }
        [JsonPropertyName("serverTime")]
        public DateTime ServerTime { get ; set ; }
        [JsonPropertyName("sessionId")]
        public Guid SessionId { get ; set ; }

        [JsonPropertyName("sessionKey")]
        public string SessionKey { get ; set; }
        [JsonPropertyName("twoFactorAuthenticationTicket")]

#nullable enable
        public string? TwoFactorAuthenticationTicket { get ; set ; }
        [JsonPropertyName("rememberMeTicket")]
        public string? RememberMeTicket { get; set ; }
#nullable disable
    }
}
