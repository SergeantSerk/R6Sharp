using R6DataAccess.Interfaces;
using R6DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace R6Sharp.Models
{
    public class Query : IQuery
    {

        [JsonPropertyName("nameOnPlatform")]
        public string NameOnPlatform { get; set; }

        [JsonPropertyName("platformType")]
        public IPlatform PlatformType { get; set; }

        [JsonPropertyName("idOnPlatform")]
        public string IdOnPlatform { get ; set ; }

        [JsonPropertyName("profile_ids")]
        public string ProfileId { get ; set ; }

        [JsonPropertyName("board_id")]
        public string BoardId { get ; set ; }

        [JsonPropertyName("region_id")]
        public IRegion Region { get ; set ; }

        [JsonPropertyName("season_id")]
        public string SeasonId { get ; set ; }

        [JsonPropertyName("populations")]
        public string Population { get ; set  ; }

        [JsonPropertyName("statistics")]
        public string Statistics { get  ; set  ; }

       
    }
}
