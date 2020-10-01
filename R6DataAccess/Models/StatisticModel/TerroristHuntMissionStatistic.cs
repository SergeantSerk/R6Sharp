using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace R6DataAccess.Models
{
    internal class TerroristHuntMissionStatisticFetch
    {
        [JsonPropertyName("results")]
        public Dictionary<string, TerroristHuntMissionStatistic> TerroristHuntMissionStatistics { get; set; }
    }

    public class TerroristHuntMissionStatistic : ITerroristHuntMissionStatistic
    {
        [JsonPropertyName("terrohuntclassicpve_matchlost:infinite")]
        public int TerrohuntclassicpveMatchlostInfinite { get; set; }

        [JsonPropertyName("allterrohuntcoop_hard_bestscore:infinite")]
        public int AllterrohuntcoopHardBestscoreInfinite { get; set; }

        [JsonPropertyName("terrohuntclassicpve_matchwon:infinite")]
        public int TerrohuntclassicpveMatchwonInfinite { get; set; }

        [JsonPropertyName("allterrohuntcoop_normal_bestscore:infinite")]
        public int AllterrohuntcoopNormalBestscoreInfinite { get; set; }

        [JsonPropertyName("terrohuntclassicpve_matchplayed:infinite")]
        public int TerrohuntclassicpveMatchplayedInfinite { get; set; }

        [JsonPropertyName("allterrohuntcoop_realistic_bestscore:infinite")]
        public int AllterrohuntcoopRealisticBestscoreInfinite { get; set; }

        [JsonPropertyName("allterrohuntsolo_hard_bestscore:infinite")]
        public int AllterrohuntsoloHardBestscoreInfinite { get; set; }

        [JsonPropertyName("missionsolo_normal_bestscore:infinite")]
        public int MissionsoloNormalBestscoreInfinite { get; set; }

        [JsonPropertyName("allterrohuntsolo_normal_bestscore:infinite")]
        public int AllterrohuntsoloNormalBestscoreInfinite { get; set; }
    }
}
