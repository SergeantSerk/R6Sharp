using R6DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace R6Sharp.Response
{

    public class Profile : IProfile
    {
        [JsonPropertyName("profileId")]
        public Guid ProfileId { get; set; }

        [JsonPropertyName("userId")]
        public Guid UserId { get; set; }

        [JsonPropertyName("platformType")]
        public string PlatformType { get; set; }

        [JsonPropertyName("idOnPlatform")]
        public Guid IdOnPlatform { get; set; }

        [JsonPropertyName("nameOnPlatform")]
        public string NameOnPlatform { get; set; }


        private Guid Rainbow6S = Guid.Parse("39baebad-39e5-4552-8c25-2c9b919064e2");

        // need to double check where else rainbow6s is being used
        public Uri ProfileIcon { 
            get { 
            return new Uri(string.Format(EndPoints.Avatar.Url, ProfileId, Rainbow6S)); 
              }
        }     
    }

    public class ProfileSearch
    {
        [JsonPropertyName("profiles")]
        public List<Profile> Profiles { get; set; } 

    }

}
