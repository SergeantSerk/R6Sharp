using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace R6DataAccess.Models
{
    internal class GamemodeStatisticFetch
    {
        [JsonPropertyName("results")]
        public Dictionary<string, GamemodeStatistic> GamemodeStatistics { get; set; }
    }

    public class GamemodeStatistic : IGamemodeStatistic
    {
        [JsonPropertyName("plantbombpvp_timeplayed:infinite")]
        public int PlantbombpvpTimeplayedInfinite { get; set; }

        [JsonPropertyName("plantbombpvp_matchplayed:infinite")]
        public int PlantbombpvpMatchplayedInfinite { get; set; }

        [JsonPropertyName("rescuehostagepve_hostagerescue:infinite")]
        public int RescuehostagepveHostagerescueInfinite { get; set; }

        [JsonPropertyName("plantbombpve_matchlost:infinite")]
        public int PlantbombpveMatchlostInfinite { get; set; }

        [JsonPropertyName("plantbombpvp_matchlost:infinite")]
        public int PlantbombpvpMatchlostInfinite { get; set; }

        [JsonPropertyName("rescuehostagepve_matchlost:infinite")]
        public int RescuehostagepveMatchlostInfinite { get; set; }

        [JsonPropertyName("plantbombpve_matchplayed:infinite")]
        public int PlantbombpveMatchplayedInfinite { get; set; }

        [JsonPropertyName("protecthostagepve_hostagedefense:infinite")]
        public int ProtecthostagepveHostagedefenseInfinite { get; set; }

        [JsonPropertyName("secureareapvp_matchlost:infinite")]
        public int SecureareapvpMatchlostInfinite { get; set; }

        [JsonPropertyName("rescuehostagepve_matchplayed:infinite")]
        public int RescuehostagepveMatchplayedInfinite { get; set; }

        [JsonPropertyName("protecthostagepve_matchlost:infinite")]
        public int ProtecthostagepveMatchlostInfinite { get; set; }

        [JsonPropertyName("plantbombpvp_matchwon:infinite")]
        public int PlantbombpvpMatchwonInfinite { get; set; }

        [JsonPropertyName("secureareapvp_matchplayed:infinite")]
        public int SecureareapvpMatchplayedInfinite { get; set; }

        [JsonPropertyName("secureareapvp_matchwon:infinite")]
        public int SecureareapvpMatchwonInfinite { get; set; }

        [JsonPropertyName("rescuehostagepvp_matchlost:infinite")]
        public int RescuehostagepvpMatchlostInfinite { get; set; }

        [JsonPropertyName("protecthostagepve_bestscore:infinite")]
        public int ProtecthostagepveBestscoreInfinite { get; set; }

        [JsonPropertyName("plantbombpve_matchwon:infinite")]
        public int PlantbombpveMatchwonInfinite { get; set; }

        [JsonPropertyName("rescuehostagepve_matchwon:infinite")]
        public int RescuehostagepveMatchwonInfinite { get; set; }

        [JsonPropertyName("protecthostagepve_matchwon:infinite")]
        public int ProtecthostagepveMatchwonInfinite { get; set; }

        [JsonPropertyName("protecthostagepve_matchplayed:infinite")]
        public int ProtecthostagepveMatchplayedInfinite { get; set; }

        [JsonPropertyName("rescuehostagepvp_matchwon:infinite")]
        public int RescuehostagepvpMatchwonInfinite { get; set; }

        [JsonPropertyName("rescuehostagepvp_matchplayed:infinite")]
        public int RescuehostagepvpMatchplayedInfinite { get; set; }
    }
}
