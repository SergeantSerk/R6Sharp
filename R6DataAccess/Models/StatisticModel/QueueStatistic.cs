using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace R6DataAccess.Models
{
    internal class QueueStatisticFetch
    {
        [JsonPropertyName("results")]
        public Dictionary<string, QueueStatistic> QueueStatistics { get; set; }
    }

    public class QueueStatistic : IQueueStatistic
    {
        [JsonPropertyName("generalpvp_gadgetdestroy:infinite")]
        public int GeneralpvpGadgetdestroyInfinite { get; set; }

        [JsonPropertyName("generalpvp_reinforcementdeploy:infinite")]
        public int GeneralpvpReinforcementdeployInfinite { get; set; }

        [JsonPropertyName("generalpvp_timeplayed:infinite")]
        public int GeneralpvpTimeplayedInfinite { get; set; }

        [JsonPropertyName("generalpve_servershacked:infinite")]
        public int GeneralpveServershackedInfinite { get; set; }

        [JsonPropertyName("generalpvp_serverdefender:infinite")]
        public int GeneralpvpServerdefenderInfinite { get; set; }

        [JsonPropertyName("generalpvp_dbno:infinite")]
        public int GeneralpvpDbnoInfinite { get; set; }

        [JsonPropertyName("generalpvp_matchwon:infinite")]
        public int GeneralpvpMatchwonInfinite { get; set; }

        [JsonPropertyName("generalpvp_bullethit:infinite")]
        public int GeneralpvpBullethitInfinite { get; set; }

        [JsonPropertyName("generalpve_distancetravelled:infinite")]
        public int GeneralpveDistancetravelledInfinite { get; set; }

        [JsonPropertyName("generalpve_gadgetdestroy:infinite")]
        public int GeneralpveGadgetdestroyInfinite { get; set; }

        [JsonPropertyName("generalpve_hostagerescue:infinite")]
        public int GeneralpveHostagerescueInfinite { get; set; }

        [JsonPropertyName("generalpvp_matchplayed:infinite")]
        public int GeneralpvpMatchplayedInfinite { get; set; }

        [JsonPropertyName("generalpvp_dbnoassists:infinite")]
        public int GeneralpvpDbnoassistsInfinite { get; set; }

        [JsonPropertyName("generalpve_penetrationkills:infinite")]
        public int GeneralpvePenetrationkillsInfinite { get; set; }

        [JsonPropertyName("generalpve_timeplayed:infinite")]
        public int GeneralpveTimeplayedInfinite { get; set; }

        [JsonPropertyName("generalpvp_headshot:infinite")]
        public int GeneralpvpHeadshotInfinite { get; set; }

        [JsonPropertyName("generalpve_kills:infinite")]
        public int GeneralpveKillsInfinite { get; set; }

        [JsonPropertyName("generalpvp_matchlost:infinite")]
        public int GeneralpvpMatchlostInfinite { get; set; }

        [JsonPropertyName("generalpve_killassists:infinite")]
        public int GeneralpveKillassistsInfinite { get; set; }

        [JsonPropertyName("generalpve_barricadedeployed:infinite")]
        public int GeneralpveBarricadedeployedInfinite { get; set; }

        [JsonPropertyName("rankedpvp_matchlost:infinite")]
        public int RankedpvpMatchlostInfinite { get; set; }

        [JsonPropertyName("generalpve_matchlost:infinite")]
        public int GeneralpveMatchlostInfinite { get; set; }

        [JsonPropertyName("casualpvp_matchlost:infinite")]
        public int CasualpvpMatchlostInfinite { get; set; }

        [JsonPropertyName("generalpvp_hostagedefense:infinite")]
        public int GeneralpvpHostagedefenseInfinite { get; set; }

        [JsonPropertyName("normalpvp_matchplayed:infinite")]
        public int NormalpvpMatchplayedInfinite { get; set; }

        [JsonPropertyName("normalpvp_matchwon:infinite")]
        public int NormalpvpMatchwonInfinite { get; set; }

        [JsonPropertyName("generalpve_matchplayed:infinite")]
        public int GeneralpveMatchplayedInfinite { get; set; }

        [JsonPropertyName("generalpvp_distancetravelled:infinite")]
        public int GeneralpvpDistancetravelledInfinite { get; set; }

        [JsonPropertyName("generalpvp_kills:infinite")]
        public int GeneralpvpKillsInfinite { get; set; }

        [JsonPropertyName("casualpvp_death:infinite")]
        public int CasualpvpDeathInfinite { get; set; }

        [JsonPropertyName("generalpve_revive:infinite")]
        public int GeneralpveReviveInfinite { get; set; }

        [JsonPropertyName("generalpvp_servershacked:infinite")]
        public int GeneralpvpServershackedInfinite { get; set; }

        [JsonPropertyName("casualpvp_matchwon:infinite")]
        public int CasualpvpMatchwonInfinite { get; set; }

        [JsonPropertyName("generalpvp_barricadedeployed:infinite")]
        public int GeneralpvpBarricadedeployedInfinite { get; set; }

        [JsonPropertyName("generalpve_blindkills:infinite")]
        public int GeneralpveBlindkillsInfinite { get; set; }

        [JsonPropertyName("generalpve_matchwon:infinite")]
        public int GeneralpveMatchwonInfinite { get; set; }

        [JsonPropertyName("generalpvp_penetrationkills:infinite")]
        public int GeneralpvpPenetrationkillsInfinite { get; set; }

        [JsonPropertyName("rankedpvp_death:infinite")]
        public int RankedpvpDeathInfinite { get; set; }

        [JsonPropertyName("generalpvp_serveraggression:infinite")]
        public int GeneralpvpServeraggressionInfinite { get; set; }

        [JsonPropertyName("generalpvp_suicide:infinite")]
        public int GeneralpvpSuicideInfinite { get; set; }

        [JsonPropertyName("generalpvp_meleekills:infinite")]
        public int GeneralpvpMeleekillsInfinite { get; set; }

        [JsonPropertyName("generalpvp_killassists:infinite")]
        public int GeneralpvpKillassistsInfinite { get; set; }

        [JsonPropertyName("generalpve_hostagedefense:infinite")]
        public int GeneralpveHostagedefenseInfinite { get; set; }

        [JsonPropertyName("rankedpvp_kdratio")]
        public double RankedpvpKdratio { get; set; }

        [JsonPropertyName("casualpvp_matchplayed:infinite")]
        public int CasualpvpMatchplayedInfinite { get; set; }

        [JsonPropertyName("generalpve_headshot:infinite")]
        public int GeneralpveHeadshotInfinite { get; set; }

        [JsonPropertyName("casualpvp_kills:infinite")]
        public int CasualpvpKillsInfinite { get; set; }

        [JsonPropertyName("generalpve_bullethit:infinite")]
        public int GeneralpveBullethitInfinite { get; set; }

        [JsonPropertyName("generalpvp_blindkills:infinite")]
        public int GeneralpvpBlindkillsInfinite { get; set; }

        [JsonPropertyName("generalpve_reinforcementdeploy:infinite")]
        public int GeneralpveReinforcementdeployInfinite { get; set; }

        [JsonPropertyName("generalpvp_revive:infinite")]
        public int GeneralpvpReviveInfinite { get; set; }

        [JsonPropertyName("rankedpvp_timeplayed:infinite")]
        public int RankedpvpTimeplayedInfinite { get; set; }

        [JsonPropertyName("generalpve_death:infinite")]
        public int GeneralpveDeathInfinite { get; set; }

        [JsonPropertyName("generalpvp_death:infinite")]
        public int GeneralpvpDeathInfinite { get; set; }

        [JsonPropertyName("generalpve_bulletfired:infinite")]
        public int GeneralpveBulletfiredInfinite { get; set; }

        [JsonPropertyName("rankedpvp_matchplayed:infinite")]
        public int RankedpvpMatchplayedInfinite { get; set; }

        [JsonPropertyName("generalpvp_hostagerescue:infinite")]
        public int GeneralpvpHostagerescueInfinite { get; set; }

        [JsonPropertyName("generalpve_suicide:infinite")]
        public int GeneralpveSuicideInfinite { get; set; }

        [JsonPropertyName("rankedpvp_matchwlratio")]
        public double RankedpvpMatchwlratio { get; set; }

        [JsonPropertyName("rankedpvp_matchwon:infinite")]
        public int RankedpvpMatchwonInfinite { get; set; }

        [JsonPropertyName("generalpve_meleekills:infinite")]
        public int GeneralpveMeleekillsInfinite { get; set; }

        [JsonPropertyName("rankedpvp_kills:infinite")]
        public int RankedpvpKillsInfinite { get; set; }
    }
}
