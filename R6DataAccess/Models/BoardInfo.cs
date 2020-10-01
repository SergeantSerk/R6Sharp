using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace R6DataAccess.Models
{
    public class BoardInfoFetch
    {
       
        
        [JsonPropertyName("players")]
        public Dictionary<string, BoardInfo> Players { get; set; }
    }



    public class BoardInfo : IBoardInfo
    {
        [JsonPropertyName("kills")]
        public int Kills { get; set; }

        [JsonPropertyName("deaths")]
        public int Deaths { get; set; }

        [JsonPropertyName("wins")]
        public int Wins { get; set; }

        [JsonPropertyName("losses")]
        public int Losses { get; set; }

        [JsonPropertyName("abandons")]
        public int Abandons { get; set; }

        [JsonPropertyName("skill_stdev")]
        public double SkillStdev { get; set; }

        [JsonPropertyName("skill_mean")]
        public double SkillMean { get; set; }

        [JsonPropertyName("last_match_result")]
        public int LastMatchResult { get; set; }

        [JsonPropertyName("last_match_mmr_change")]
        public double LastMatchMMRChange { get; set; }

        [JsonPropertyName("last_match_skill_stdev_change")]
        public double LastMatchSkillStdevChange { get; set; }

        [JsonPropertyName("last_match_skill_mean_change")]
        public double LastMatchSkillMeanChange { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("max_rank")]
        public int MaxRank { get; set; }

        [JsonPropertyName("mmr")]
        public double MMR { get; set; }

        [JsonPropertyName("max_mmr")]
        public double MaxMMR { get; set; }

        [JsonPropertyName("next_rank_mmr")]
        public double NextRankMMR { get; set; }

        [JsonPropertyName("previous_rank_mmr")]
        public double PreviousRankMMR { get; set; }

        [JsonPropertyName("top_rank_position")]
        public int TopRankPosition { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("season")]
        public int Season { get; set; }

        [JsonPropertyName("update_time")]
        public DateTime UpdateTime { get; set; }

        [JsonPropertyName("board_id")]
        public string BoardId { get; set; }

        [JsonPropertyName("profile_id")]
        public Guid ProfileId { get; set; }
    }
}
