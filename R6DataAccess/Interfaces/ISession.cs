using System;
using System.Text.Json.Serialization;

namespace R6Sharp.Response
{
    public interface ISession
    {
     
        public string PlatformType { get; set; }

        public string Ticket { get; set; }

    
        public Guid ProfileId { get; set; }

       
        public Guid UserId { get; set; }

    
        public string NameOnPlatform { get; set; }

   
        public string Environment { get; set; }

 
        public DateTime Expiration { get; set; }

   
        public string ClientIp { get; set; }

    
        public string ClientIpCountry { get; set; }

       
        public DateTime ServerTime { get; set; }

      
        public Guid SessionId { get; set; }

        public string SessionKey { get; set; }

#nullable enable

        public string? TwoFactorAuthenticationTicket { get; set; }

     
        public string? RememberMeTicket { get; set; }
    }
}