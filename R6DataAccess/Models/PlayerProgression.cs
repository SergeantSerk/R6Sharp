using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace R6DataAccess.Models
{
    public class PlayerProgression : IPlayerProgression
    {

        public class PlayerProgressionFetch
        {
            [JsonPropertyName("player_profiles")]
            public List<PlayerProgression> PlayerProgressions { get; set; }
        }


        [JsonPropertyName("xp")]
        public int XP { get; set; }

        [JsonPropertyName("profile_id")]
        public Guid ProfileId { get; set; }

        [JsonPropertyName("lootbox_probability")]
        public int LootboxProbability { get; set; }

        [JsonPropertyName("level")]
        public int Level { get; set; }

      

    }
}
