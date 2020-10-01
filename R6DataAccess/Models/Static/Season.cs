using R6DataAccess.Converter;
using R6DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace R6Sharp.Response.Static
{
    public class SeasonsInfo
    {
        [JsonPropertyName("seasons")]
        public Dictionary<string, Season> Seasons { get; set; }

  
     

        [JsonPropertyName("latestSeason")]
        [JsonConverter(typeof(ParseStringToInt))]
        public int LatestSeason { get; set; }
    }

    public class Season
    {
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }


        private string _background; 

        [JsonPropertyName("background")]
        public string Background { get { return _background; } set { _background = $"{EndPoints.Base.Url}/{value}"; } }
    }
}
