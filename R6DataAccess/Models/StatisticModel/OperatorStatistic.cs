using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace R6DataAccess.Models
{
    internal class OperatorStatisticFetch
    {
        [JsonPropertyName("results")]
        public Dictionary<string, OperatorStatistic> OperatorStatistics { get; set; }
    }

    public class OperatorStatistic : IOperatorStatistic
    {
        [JsonPropertyName("operatorpvp_headshot:3:8:infinite")]
        public int OperatorpvpHeadshot38Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:A:infinite")]
        public int OperatorpvpDeath3AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_death:4:1:infinite")]
        public int OperatorpvpDeath41Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:1:1B:infinite")]
        public int OperatorpvpDeath11BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:1:4:infinite")]
        public int OperatorpvpRoundwon14Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:C:infinite")]
        public int OperatorpvpRoundplayed2CInfinite { get; set; }

        [JsonPropertyName("operatorpve_kills:2:19:infinite")]
        public int OperatorpveKills219Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:2:13:infinite")]
        public int OperatorpveRoundlost213Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:4:1:infinite")]
        public int OperatorpvpRoundlost41Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:5:2:infinite")]
        public int OperatorpvpKills52Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:13:infinite")]
        public int OperatorpvpRoundlost213Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:2:9:infinite")]
        public int OperatorpveRoundplayed29Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:1:16:infinite")]
        public int OperatorpvpTotalxp116Infinite { get; set; }

        [JsonPropertyName("operatorpvp_nokk_observationtooldeceived:2:13:infinite")]
        public int OperatorpvpNokkObservationtooldeceived213Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:8:16:infinite")]
        public int OperatorpvpRoundplayed816Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:1:3:infinite")]
        public int OperatorpvpRoundwon13Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:5:2:infinite")]
        public int OperatorpvpRoundlost52Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:3:12:infinite")]
        public int OperatorpvpHeadshot312Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:B:infinite")]
        public int OperatorpvpDeath2BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:10:infinite")]
        public int OperatorpvpRoundplayed210Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:3:D:infinite")]
        public int OperatorpveTotalxp3DInfinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:4:E:infinite")]
        public int OperatorpveHeadshot4EInfinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:D:infinite")]
        public int OperatorpvpTotalxp3DInfinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:17:infinite")]
        public int OperatorpvpTotalxp317Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:2:infinite")]
        public int OperatorpvpKills32Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:4:16:infinite")]
        public int OperatorpvpRoundwon416Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:3:2:infinite")]
        public int OperatorpvpHeadshot32Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:1:4:infinite")]
        public int OperatorpvpRoundlost14Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:4:2:infinite")]
        public int OperatorpveKills42Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:1:5:infinite")]
        public int OperatorpvpMeleekills15Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:C:infinite")]
        public int OperatorpvpDeath3CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:F:infinite")]
        public int OperatorpvpRoundplayed2FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:1A:infinite")]
        public int OperatorpvpRoundplayed21AInfinite { get; set; }

        [JsonPropertyName("operatorpve_kills:3:4:infinite")]
        public int OperatorpveKills34Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:2:4:infinite")]
        public int OperatorpveRoundwon24Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:2:8:infinite")]
        public int OperatorpveTotalxp28Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:1:1:infinite")]
        public int OperatorpveDeath11Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:1:2:infinite")]
        public int OperatorpvpHeadshot12Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:1:2:infinite")]
        public int OperatorpvpRoundlost12Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:3:3:infinite")]
        public int OperatorpveTotalxp33Infinite { get; set; }

        [JsonPropertyName("operatorpve_thermite_chargedeployed:5:2:infinite")]
        public int OperatorpveThermiteChargedeployed52Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:2:18:infinite")]
        public int OperatorpveKills218Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:2:8:infinite")]
        public int OperatorpveMeleekills28Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:4:1A:infinite")]
        public int OperatorpvpTimeplayed41AInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:3:9:infinite")]
        public int OperatorpveRoundplayed39Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:9:infinite")]
        public int OperatorpvpRoundwon29Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:3:2:infinite")]
        public int OperatorpveRoundplayed32Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:2:6:infinite")]
        public int OperatorpveKills26Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:1:infinite")]
        public int OperatorpvpRoundlost21Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:3:3:infinite")]
        public int OperatorpveRoundlost33Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:3:5:infinite")]
        public int OperatorpveDeath35Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:5:5:infinite")]
        public int OperatorpvpTotalxp55Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:4:16:infinite")]
        public int OperatorpvpTotalxp416Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:2:12:infinite")]
        public int OperatorpveRoundwon212Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:1:1B:infinite")]
        public int OperatorpvpKills11BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:4:E:infinite")]
        public int OperatorpvpRoundlost4EInfinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:5:infinite")]
        public int OperatorpvpKills25Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:10:infinite")]
        public int OperatorpvpTotalxp310Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:C:infinite")]
        public int OperatorpvpTotalxp3CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:4:5:infinite")]
        public int OperatorpvpTimeplayed45Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:5:2:infinite")]
        public int OperatorpvpDbno52Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:1:5:infinite")]
        public int OperatorpvpTotalxp15Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:1:2:infinite")]
        public int OperatorpveTotalxp12Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:4:16:infinite")]
        public int OperatorpvpRoundlost416Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:8:infinite")]
        public int OperatorpvpHeadshot28Infinite { get; set; }

        [JsonPropertyName("operatorpvp_concussiongrenade_detonate:3:C:infinite")]
        public int OperatorpvpConcussiongrenadeDetonate3CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_death:1:5:infinite")]
        public int OperatorpvpDeath15Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:3:6:infinite")]
        public int OperatorpveKills36Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:5:2:infinite")]
        public int OperatorpveTimeplayed52Infinite { get; set; }

        [JsonPropertyName("operatorpvp_amaru_distancereeled:2:16:infinite")]
        public int OperatorpvpAmaruDistancereeled216Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:A:infinite")]
        public int OperatorpvpTimeplayed2AInfinite { get; set; }

        [JsonPropertyName("operatorpve_castle_kevlarbarricadedeployed:2:2:infinite")]
        public int OperatorpveCastleKevlarbarricadedeployed22Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:1:4:infinite")]
        public int OperatorpvpRoundplayed14Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:4:2:infinite")]
        public int OperatorpvpHeadshot42Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:3:F:infinite")]
        public int OperatorpveRoundwon3FInfinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:3:11:infinite")]
        public int OperatorpveTimeplayed311Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:3:11:infinite")]
        public int OperatorpvpRoundlost311Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:3:9:infinite")]
        public int OperatorpveTimeplayed39Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:3:7:infinite")]
        public int OperatorpveHeadshot37Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:4:1:infinite")]
        public int OperatorpvpHeadshot41Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:4:E:infinite")]
        public int OperatorpveTotalxp4EInfinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:4:1:infinite")]
        public int OperatorpveHeadshot41Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:2:11:infinite")]
        public int OperatorpveTotalxp211Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:16:infinite")]
        public int OperatorpvpRoundplayed316Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:7:infinite")]
        public int OperatorpvpTimeplayed37Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:5:16:infinite")]
        public int OperatorpvpRoundlost516Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:2:4:infinite")]
        public int OperatorpveKills24Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:9:infinite")]
        public int OperatorpvpKills29Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:10:infinite")]
        public int OperatorpvpTotalxp210Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:5:3:infinite")]
        public int OperatorpvpKills53Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:2:13:infinite")]
        public int OperatorpveMeleekills213Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:4:infinite")]
        public int OperatorpvpTotalxp34Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:2:B:infinite")]
        public int OperatorpveMeleekills2BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:3:infinite")]
        public int OperatorpvpRoundplayed23Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:2:6:infinite")]
        public int OperatorpveDeath26Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:3:C:infinite")]
        public int OperatorpveHeadshot3CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:4:4:infinite")]
        public int OperatorpvpTotalxp44Infinite { get; set; }

        [JsonPropertyName("operatorpvp_caltrop_enemy_affected:3:B:infinite")]
        public int OperatorpvpCaltropEnemyAffected3BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:1:5:infinite")]
        public int OperatorpvpTimeplayed15Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:4:4:infinite")]
        public int OperatorpveRoundwon44Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:2:12:infinite")]
        public int OperatorpveTotalxp212Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:7:infinite")]
        public int OperatorpvpTotalxp37Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:5:4:infinite")]
        public int OperatorpvpTimeplayed54Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:4:3:infinite")]
        public int OperatorpveHeadshot43Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:4:3:infinite")]
        public int OperatorpvpDeath43Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:4:E:infinite")]
        public int OperatorpvpTotalxp4EInfinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:5:5:infinite")]
        public int OperatorpveHeadshot55Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:1:infinite")]
        public int OperatorpvpRoundplayed31Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:5:4:infinite")]
        public int OperatorpvpRoundplayed54Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:17:infinite")]
        public int OperatorpvpKills317Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:6:infinite")]
        public int OperatorpvpTotalxp26Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:19:infinite")]
        public int OperatorpvpKills219Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:1:1B:infinite")]
        public int OperatorpvpTotalxp11BInfinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:4:4:infinite")]
        public int OperatorpveTimeplayed44Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:19:infinite")]
        public int OperatorpvpDeath219Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:7:16:infinite")]
        public int OperatorpvpTimeplayed716Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:7:16:infinite")]
        public int OperatorpvpTotalxp716Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:8:infinite")]
        public int OperatorpvpDeath28Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:4:3:infinite")]
        public int OperatorpveTimeplayed43Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:3:17:infinite")]
        public int OperatorpvpHeadshot317Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:2:4:infinite")]
        public int OperatorpveRoundplayed24Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:4:E:infinite")]
        public int OperatorpveRoundlost4EInfinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:2:infinite")]
        public int OperatorpvpTimeplayed32Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:4:1:infinite")]
        public int OperatorpvpTotalxp41Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:A:infinite")]
        public int OperatorpvpDbno2AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:B:infinite")]
        public int OperatorpvpTotalxp2BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:C:infinite")]
        public int OperatorpvpDbno2CInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:3:4:infinite")]
        public int OperatorpveRoundwon34Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:1:1:infinite")]
        public int OperatorpvpRoundplayed11Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:5:5:infinite")]
        public int OperatorpvpRoundlost55Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:3:B:infinite")]
        public int OperatorpveHeadshot3BInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:2:1:infinite")]
        public int OperatorpveRoundplayed21Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:1:1:infinite")]
        public int OperatorpveHeadshot11Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:F:infinite")]
        public int OperatorpvpTimeplayed2FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:18:infinite")]
        public int OperatorpvpKills218Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:12:infinite")]
        public int OperatorpvpRoundplayed212Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:3:F:infinite")]
        public int OperatorpvpHeadshot3FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:8:infinite")]
        public int OperatorpvpKills38Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:1:1:infinite")]
        public int OperatorpveRoundlost11Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:2:8:infinite")]
        public int OperatorpveRoundwon28Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:3:9:infinite")]
        public int OperatorpveKills39Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:1:3:infinite")]
        public int OperatorpvpRoundplayed13Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:3:11:infinite")]
        public int OperatorpvpDbno311Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:1:2:infinite")]
        public int OperatorpveHeadshot12Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:10:infinite")]
        public int OperatorpvpTimeplayed310Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:2:infinite")]
        public int OperatorpvpDeath32Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:3:B:infinite")]
        public int OperatorpveKills3BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_iq_gadgetspotbyef:3:5:infinite")]
        public int OperatorpvpIqGadgetspotbyef35Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:5:1:infinite")]
        public int OperatorpveKills51Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:4:5:infinite")]
        public int OperatorpvpHeadshot45Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:5:16:infinite")]
        public int OperatorpvpRoundplayed516Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:4:E:infinite")]
        public int OperatorpvpMeleekills4EInfinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:3:B:infinite")]
        public int OperatorpveTotalxp3BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:10:infinite")]
        public int OperatorpvpKills210Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:2:9:infinite")]
        public int OperatorpvpMeleekills29Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:F:infinite")]
        public int OperatorpvpDeath3FInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:4:2:infinite")]
        public int OperatorpveRoundlost42Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:4:E:infinite")]
        public int OperatorpveDeath4EInfinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:C:infinite")]
        public int OperatorpvpTimeplayed2CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:3:C:infinite")]
        public int OperatorpvpDbno3CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:5:3:infinite")]
        public int OperatorpvpTotalxp53Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:7:16:infinite")]
        public int OperatorpvpDeath716Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:4:1:infinite")]
        public int OperatorpveRoundlost41Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:4:3:infinite")]
        public int OperatorpvpDbno43Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:3:infinite")]
        public int OperatorpvpDbno23Infinite { get; set; }

        [JsonPropertyName("operatorpvp_glaz_sniperpenetrationkill:2:4:infinite")]
        public int OperatorpvpGlazSniperpenetrationkill24Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:3:4:infinite")]
        public int OperatorpveTimeplayed34Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:2:C:infinite")]
        public int OperatorpveHeadshot2CInfinite { get; set; }

        [JsonPropertyName("operatorpve_kills:3:12:infinite")]
        public int OperatorpveKills312Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:5:2:infinite")]
        public int OperatorpveKills52Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:2:infinite")]
        public int OperatorpvpRoundwon22Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:15:infinite")]
        public int OperatorpvpHeadshot215Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:5:5:infinite")]
        public int OperatorpvpRoundplayed55Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:3:5:infinite")]
        public int OperatorpveMeleekills35Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:2:13:infinite")]
        public int OperatorpvpMeleekills213Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:1:3:infinite")]
        public int OperatorpveHeadshot13Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:4:2:infinite")]
        public int OperatorpvpRoundplayed42Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:3:11:infinite")]
        public int OperatorpvpHeadshot311Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:11:infinite")]
        public int OperatorpvpDeath211Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:4:5:infinite")]
        public int OperatorpvpRoundplayed45Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:5:4:infinite")]
        public int OperatorpvpTotalxp54Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:12:infinite")]
        public int OperatorpvpTotalxp212Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:11:infinite")]
        public int OperatorpvpTotalxp211Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:3:5:infinite")]
        public int OperatorpveTotalxp35Infinite { get; set; }

        [JsonPropertyName("operatorpvp_smoke_poisongaskill:2:1:infinite")]
        public int OperatorpvpSmokePoisongaskill21Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:3:A:infinite")]
        public int OperatorpvpDbno3AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:1A:infinite")]
        public int OperatorpvpHeadshot21AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:12:infinite")]
        public int OperatorpvpRoundlost212Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:7:infinite")]
        public int OperatorpvpKills27Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:1:1:infinite")]
        public int OperatorpvpTotalxp11Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:3:B:infinite")]
        public int OperatorpvpRoundlost3BInfinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:3:6:infinite")]
        public int OperatorpveTotalxp36Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:16:infinite")]
        public int OperatorpvpRoundplayed216Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:2:19:infinite")]
        public int OperatorpveTotalxp219Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:3:6:infinite")]
        public int OperatorpveHeadshot36Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:2:3:infinite")]
        public int OperatorpveMeleekills23Infinite { get; set; }

        [JsonPropertyName("operatorpvp_attackerdrone_diminishedrealitymode:3:D:infinite")]
        public int OperatorpvpAttackerdroneDiminishedrealitymode3DInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:4:3:infinite")]
        public int OperatorpvpRoundplayed43Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:3:3:infinite")]
        public int OperatorpvpDbno33Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:3:1A:infinite")]
        public int OperatorpvpDbno31AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_death:5:5:infinite")]
        public int OperatorpvpDeath55Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:3:3:infinite")]
        public int OperatorpveKills33Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:2:6:infinite")]
        public int OperatorpveRoundlost26Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:5:1:infinite")]
        public int OperatorpvpKills51Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:3:infinite")]
        public int OperatorpvpTimeplayed23Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:2:18:infinite")]
        public int OperatorpveHeadshot218Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:2:infinite")]
        public int OperatorpvpKills22Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:4:16:infinite")]
        public int OperatorpvpRoundplayed416Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:4:2:infinite")]
        public int OperatorpvpMeleekills42Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:3:B:infinite")]
        public int OperatorpveMeleekills3BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:15:infinite")]
        public int OperatorpvpKills215Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:4:infinite")]
        public int OperatorpvpRoundwon24Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:6:infinite")]
        public int OperatorpvpTimeplayed26Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:5:2:infinite")]
        public int OperatorpveTotalxp52Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:13:infinite")]
        public int OperatorpvpRoundwon213Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:8:infinite")]
        public int OperatorpvpDbno28Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:11:infinite")]
        public int OperatorpvpTimeplayed311Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:4:17:infinite")]
        public int OperatorpveRoundplayed417Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:11:infinite")]
        public int OperatorpvpRoundwon211Infinite { get; set; }

        [JsonPropertyName("operatorpvp_pulse_heartbeatassist:4:2:infinite")]
        public int OperatorpvpPulseHeartbeatassist42Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:8:16:infinite")]
        public int OperatorpvpTimeplayed816Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:1:infinite")]
        public int OperatorpvpDeath21Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:A:infinite")]
        public int OperatorpvpRoundplayed2AInfinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:3:12:infinite")]
        public int OperatorpveHeadshot312Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:1:2:infinite")]
        public int OperatorpvpTimeplayed12Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:12:infinite")]
        public int OperatorpvpKills312Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:6:infinite")]
        public int OperatorpvpHeadshot26Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:1:3:infinite")]
        public int OperatorpveDeath13Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:4:E:infinite")]
        public int OperatorpvpDeath4EInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:5:infinite")]
        public int OperatorpvpRoundlost25Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:14:infinite")]
        public int OperatorpvpRoundwon214Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:2:3:infinite")]
        public int OperatorpveHeadshot23Infinite { get; set; }

        [JsonPropertyName("operatorpvp_goyo_volcandetonate:2:15:infinite")]
        public int OperatorpvpGoyoVolcandetonate215Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:3:16:infinite")]
        public int OperatorpvpRoundwon316Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:B:infinite")]
        public int OperatorpvpHeadshot2BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_death:8:16:infinite")]
        public int OperatorpvpDeath816Infinite { get; set; }

        [JsonPropertyName("operatorpve_rook_armortakenteammate:3:3:infinite")]
        public int OperatorpveRookArmortakenteammate33Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:2:10:infinite")]
        public int OperatorpveTimeplayed210Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:2:13:infinite")]
        public int OperatorpveRoundplayed213Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:2:C:infinite")]
        public int OperatorpvpMeleekills2CInfinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:2:12:infinite")]
        public int OperatorpveTimeplayed212Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:5:5:infinite")]
        public int OperatorpveTimeplayed55Infinite { get; set; }

        [JsonPropertyName("operatorpvp_doc_hostagerevive:2:3:infinite")]
        public int OperatorpvpDocHostagerevive23Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:2:3:infinite")]
        public int OperatorpveRoundplayed23Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:2:19:infinite")]
        public int OperatorpveMeleekills219Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:2:5:infinite")]
        public int OperatorpveRoundwon25Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:2:19:infinite")]
        public int OperatorpveRoundwon219Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:3:A:infinite")]
        public int OperatorpvpHeadshot3AInfinite { get; set; }

        [JsonPropertyName("operatorpve_kills:3:D:infinite")]
        public int OperatorpveKills3DInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:4:1:infinite")]
        public int OperatorpveRoundplayed41Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:2:A:infinite")]
        public int OperatorpvpMeleekills2AInfinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:4:4:infinite")]
        public int OperatorpveMeleekills44Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:2:2:infinite")]
        public int OperatorpvpMeleekills22Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:4:E:infinite")]
        public int OperatorpveRoundplayed4EInfinite { get; set; }

        [JsonPropertyName("operatorpvp_death:5:3:infinite")]
        public int OperatorpvpDeath53Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:7:16:infinite")]
        public int OperatorpvpRoundplayed716Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:3:infinite")]
        public int OperatorpvpRoundlost23Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:3:F:infinite")]
        public int OperatorpvpRoundlost3FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:9:infinite")]
        public int OperatorpvpRoundplayed29Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:2:4:infinite")]
        public int OperatorpveDeath24Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:14:infinite")]
        public int OperatorpvpRoundlost214Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:2:11:infinite")]
        public int OperatorpveDeath211Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:2:1A:infinite")]
        public int OperatorpvpMeleekills21AInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:5:3:infinite")]
        public int OperatorpveRoundplayed53Infinite { get; set; }

        [JsonPropertyName("operatorpvp_wamai_gadgetdestroybymagnet:3:17:infinite")]
        public int OperatorpvpWamaiGadgetdestroybymagnet317Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:4:1:infinite")]
        public int OperatorpvpRoundplayed41Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:D:infinite")]
        public int OperatorpvpDeath2DInfinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:3:infinite")]
        public int OperatorpvpTotalxp33Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:2:F:infinite")]
        public int OperatorpveRoundplayed2FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:3:E:infinite")]
        public int OperatorpvpRoundlost3EInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:F:infinite")]
        public int OperatorpvpRoundwon2FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_death:4:17:infinite")]
        public int OperatorpvpDeath417Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:4:2:infinite")]
        public int OperatorpveDeath42Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:3:infinite")]
        public int OperatorpvpDeath33Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:1A:infinite")]
        public int OperatorpvpKills31AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:6:16:infinite")]
        public int OperatorpvpRoundlost616Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:3:5:infinite")]
        public int OperatorpvpDbno35Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:4:16:infinite")]
        public int OperatorpvpDbno416Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:16:infinite")]
        public int OperatorpvpDbno216Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:12:infinite")]
        public int OperatorpvpDeath312Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:D:infinite")]
        public int OperatorpvpRoundwon2DInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:6:infinite")]
        public int OperatorpvpRoundwon26Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:5:infinite")]
        public int OperatorpvpDeath35Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:5:1:infinite")]
        public int OperatorpvpDbno51Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:3:C:infinite")]
        public int OperatorpvpHeadshot3CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:7:infinite")]
        public int OperatorpvpDbno27Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:16:infinite")]
        public int OperatorpvpRoundlost216Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:7:16:infinite")]
        public int OperatorpvpRoundwon716Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:4:5:infinite")]
        public int OperatorpvpTotalxp45Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:4:3:infinite")]
        public int OperatorpveRoundplayed43Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:4:2:infinite")]
        public int OperatorpvpRoundlost42Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:4:infinite")]
        public int OperatorpvpDbno24Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:10:infinite")]
        public int OperatorpvpRoundlost210Infinite { get; set; }

        [JsonPropertyName("operatorpvp_echo_enemy_sonicburst_affected:3:9:infinite")]
        public int OperatorpvpEchoEnemySonicburstAffected39Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:3:7:infinite")]
        public int OperatorpvpMeleekills37Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:3:2:infinite")]
        public int OperatorpveKills32Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:3:2:infinite")]
        public int OperatorpvpRoundlost32Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:3:7:infinite")]
        public int OperatorpvpHeadshot37Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:1:2:infinite")]
        public int OperatorpvpMeleekills12Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:1:1B:infinite")]
        public int OperatorpvpRoundwon11BInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:2:11:infinite")]
        public int OperatorpveRoundwon211Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:3:D:infinite")]
        public int OperatorpvpHeadshot3DInfinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:15:infinite")]
        public int OperatorpvpDbno215Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:4:2:infinite")]
        public int OperatorpvpTimeplayed42Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:5:1:infinite")]
        public int OperatorpvpRoundlost51Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:3:2:infinite")]
        public int OperatorpveRoundlost32Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:3:D:infinite")]
        public int OperatorpvpRoundlost3DInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:5:4:infinite")]
        public int OperatorpvpRoundwon54Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:12:infinite")]
        public int OperatorpvpKills212Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:2:infinite")]
        public int OperatorpvpHeadshot22Infinite { get; set; }

        [JsonPropertyName("operatorpvp_tachanka_turretdeployed:5:4:infinite")]
        public int OperatorpvpTachankaTurretdeployed54Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:2:B:infinite")]
        public int OperatorpveTotalxp2BInfinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:3:9:infinite")]
        public int OperatorpveHeadshot39Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:5:5:infinite")]
        public int OperatorpveRoundplayed55Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:13:infinite")]
        public int OperatorpvpRoundplayed213Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:B:infinite")]
        public int OperatorpvpDeath3BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_mozzie_droneshacked:2:12:infinite")]
        public int OperatorpvpMozzieDroneshacked212Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:1:2:infinite")]
        public int OperatorpveRoundwon12Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:1:16:infinite")]
        public int OperatorpvpKills116Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:C:infinite")]
        public int OperatorpvpHeadshot2CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:3:17:infinite")]
        public int OperatorpvpRoundwon317Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:4:1:infinite")]
        public int OperatorpveMeleekills41Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:18:infinite")]
        public int OperatorpvpRoundwon218Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:5:2:infinite")]
        public int OperatorpveRoundlost52Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:5:1:infinite")]
        public int OperatorpvpDeath51Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:3:infinite")]
        public int OperatorpvpRoundplayed33Infinite { get; set; }

        [JsonPropertyName("operatorpvp_sledge_hammerhole:4:1:infinite")]
        public int OperatorpvpSledgeHammerhole41Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:2:1:infinite")]
        public int OperatorpveTimeplayed21Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:3:5:infinite")]
        public int OperatorpveKills35Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:4:1:infinite")]
        public int OperatorpveDeath41Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:2:13:infinite")]
        public int OperatorpveKills213Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:4:5:infinite")]
        public int OperatorpvpMeleekills45Infinite { get; set; }

        [JsonPropertyName("operatorpvp_barrage_killswithturret:2:F:infinite")]
        public int OperatorpvpBarrageKillswithturret2FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:3:7:infinite")]
        public int OperatorpvpRoundwon37Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:3:9:infinite")]
        public int OperatorpvpHeadshot39Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:3:D:infinite")]
        public int OperatorpvpDbno3DInfinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:3:1:infinite")]
        public int OperatorpvpHeadshot31Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:2:B:infinite")]
        public int OperatorpveDeath2BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:4:17:infinite")]
        public int OperatorpvpRoundwon417Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:3:12:infinite")]
        public int OperatorpveRoundwon312Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:6:1A:infinite")]
        public int OperatorpvpRoundlost61AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:9:infinite")]
        public int OperatorpvpTimeplayed39Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:5:3:infinite")]
        public int OperatorpvpHeadshot53Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:8:infinite")]
        public int OperatorpvpTotalxp28Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:4:4:infinite")]
        public int OperatorpvpTimeplayed44Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:4:5:infinite")]
        public int OperatorpvpDbno45Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:9:infinite")]
        public int OperatorpvpTotalxp39Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:4:2:infinite")]
        public int OperatorpveTotalxp42Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:2:infinite")]
        public int OperatorpvpRoundlost22Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:11:infinite")]
        public int OperatorpvpKills311Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:19:infinite")]
        public int OperatorpvpRoundlost219Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:B:infinite")]
        public int OperatorpvpTotalxp3BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:11:infinite")]
        public int OperatorpvpTotalxp311Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:2:12:infinite")]
        public int OperatorpveKills212Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:2:B:infinite")]
        public int OperatorpveHeadshot2BInfinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:2:4:infinite")]
        public int OperatorpveMeleekills24Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:2:infinite")]
        public int OperatorpvpDbno22Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:4:17:infinite")]
        public int OperatorpvpKills417Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:5:5:infinite")]
        public int OperatorpveKills55Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:3:C:infinite")]
        public int OperatorpveTimeplayed3CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:19:infinite")]
        public int OperatorpvpRoundwon219Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:4:E:infinite")]
        public int OperatorpvpRoundplayed4EInfinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:3:2:infinite")]
        public int OperatorpveTotalxp32Infinite { get; set; }

        [JsonPropertyName("operatorpvp_fuze_clusterchargekill:3:4:infinite")]
        public int OperatorpvpFuzeClusterchargekill34Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:2:19:infinite")]
        public int OperatorpveRoundlost219Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:2:infinite")]
        public int OperatorpvpDeath22Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:5:2:infinite")]
        public int OperatorpvpTotalxp52Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:3:8:infinite")]
        public int OperatorpvpRoundwon38Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:3:F:infinite")]
        public int OperatorpvpDbno3FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:1:1B:infinite")]
        public int OperatorpvpMeleekills11BInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:2:2:infinite")]
        public int OperatorpveRoundwon22Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:2:4:infinite")]
        public int OperatorpveTotalxp24Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:1:3:infinite")]
        public int OperatorpvpDeath13Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:3:1:infinite")]
        public int OperatorpvpRoundwon31Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:C:infinite")]
        public int OperatorpvpRoundwon2CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:3:7:infinite")]
        public int OperatorpvpRoundlost37Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:3:D:infinite")]
        public int OperatorpvpMeleekills3DInfinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:2:11:infinite")]
        public int OperatorpveTimeplayed211Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:3:infinite")]
        public int OperatorpvpDeath23Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:3:12:infinite")]
        public int OperatorpvpRoundlost312Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:3:7:infinite")]
        public int OperatorpveTimeplayed37Infinite { get; set; }

        [JsonPropertyName("operatorpvp_warden_killswithglasses:2:14:infinite")]
        public int OperatorpvpWardenKillswithglasses214Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:4:4:infinite")]
        public int OperatorpveKills44Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:3:F:infinite")]
        public int OperatorpveTotalxp3FInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:2:11:infinite")]
        public int OperatorpveRoundplayed211Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:2:12:infinite")]
        public int OperatorpveMeleekills212Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:6:1A:infinite")]
        public int OperatorpvpTimeplayed61AInfinite { get; set; }

        [JsonPropertyName("operatorpve_kills:4:17:infinite")]
        public int OperatorpveKills417Infinite { get; set; }

        [JsonPropertyName("operatorpvp_twitch_gadgetdestroybyshockdrone:4:3:infinite")]
        public int OperatorpvpTwitchGadgetdestroybyshockdrone43Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:7:infinite")]
        public int OperatorpvpDeath27Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:2:9:infinite")]
        public int OperatorpveDeath29Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:2:4:infinite")]
        public int OperatorpveRoundlost24Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:4:3:infinite")]
        public int OperatorpvpTotalxp43Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:4:17:infinite")]
        public int OperatorpvpTotalxp417Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:7:infinite")]
        public int OperatorpvpRoundlost27Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:4:infinite")]
        public int OperatorpvpKills34Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:3:8:infinite")]
        public int OperatorpvpRoundlost38Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:2:6:infinite")]
        public int OperatorpveTotalxp26Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:6:1A:infinite")]
        public int OperatorpvpDeath61AInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:5:5:infinite")]
        public int OperatorpveRoundlost55Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:2:5:infinite")]
        public int OperatorpveTimeplayed25Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:1:5:infinite")]
        public int OperatorpvpRoundlost15Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:16:infinite")]
        public int OperatorpvpRoundwon216Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:2:13:infinite")]
        public int OperatorpveTimeplayed213Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:3:11:infinite")]
        public int OperatorpveTotalxp311Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:5:2:infinite")]
        public int OperatorpvpRoundwon52Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:2:13:infinite")]
        public int OperatorpveHeadshot213Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:16:infinite")]
        public int OperatorpvpTimeplayed216Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:3:3:infinite")]
        public int OperatorpvpMeleekills33Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:3:3:infinite")]
        public int OperatorpvpHeadshot33Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:2:F:infinite")]
        public int OperatorpveKills2FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:13:infinite")]
        public int OperatorpvpHeadshot213Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:B:infinite")]
        public int OperatorpvpTimeplayed2BInfinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:4:3:infinite")]
        public int OperatorpveMeleekills43Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:1:1B:infinite")]
        public int OperatorpvpDbno11BInfinite { get; set; }

        [JsonPropertyName("operatorpve_kills:2:11:infinite")]
        public int OperatorpveKills211Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:5:16:infinite")]
        public int OperatorpvpRoundwon516Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:1:5:infinite")]
        public int OperatorpvpRoundplayed15Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:3:C:infinite")]
        public int OperatorpvpRoundlost3CInfinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:3:C:infinite")]
        public int OperatorpveMeleekills3CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:3:E:infinite")]
        public int OperatorpvpDbno3EInfinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:16:infinite")]
        public int OperatorpvpTotalxp316Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:E:infinite")]
        public int OperatorpvpTotalxp3EInfinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:A:infinite")]
        public int OperatorpvpHeadshot2AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:F:infinite")]
        public int OperatorpvpTotalxp3FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:18:infinite")]
        public int OperatorpvpRoundplayed218Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:1:2:infinite")]
        public int OperatorpvpDbno12Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:B:infinite")]
        public int OperatorpvpRoundlost2BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:D:infinite")]
        public int OperatorpvpDeath3DInfinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:4:3:infinite")]
        public int OperatorpvpTimeplayed43Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:3:C:infinite")]
        public int OperatorpvpRoundwon3CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:4:17:infinite")]
        public int OperatorpvpHeadshot417Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:18:infinite")]
        public int OperatorpvpTimeplayed218Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:4:17:infinite")]
        public int OperatorpvpTimeplayed417Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:3:A:infinite")]
        public int OperatorpvpRoundwon3AInfinite { get; set; }

        [JsonPropertyName("operatorpve_kills:2:8:infinite")]
        public int OperatorpveKills28Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:13:infinite")]
        public int OperatorpvpTotalxp213Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:8:infinite")]
        public int OperatorpvpKills28Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:C:infinite")]
        public int OperatorpvpRoundlost2CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:5:5:infinite")]
        public int OperatorpvpRoundwon55Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:14:infinite")]
        public int OperatorpvpTimeplayed214Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:2:5:infinite")]
        public int OperatorpveKills25Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:2:4:infinite")]
        public int OperatorpveHeadshot24Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:2:F:infinite")]
        public int OperatorpveHeadshot2FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:3:1A:infinite")]
        public int OperatorpvpRoundwon31AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:8:infinite")]
        public int OperatorpvpRoundplayed28Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:5:infinite")]
        public int OperatorpvpHeadshot25Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:2:2:infinite")]
        public int OperatorpveRoundplayed22Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:4:4:infinite")]
        public int OperatorpvpKills44Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:5:1:infinite")]
        public int OperatorpveDeath51Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kapkan_boobytrapdeployed:4:4:infinite")]
        public int OperatorpvpKapkanBoobytrapdeployed44Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:10:infinite")]
        public int OperatorpvpRoundwon210Infinite { get; set; }

        [JsonPropertyName("operatorpvp_iana_killsafterreplicator:2:19:infinite")]
        public int OperatorpvpIanaKillsafterreplicator219Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:3:C:infinite")]
        public int OperatorpveRoundwon3CInfinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:2:13:infinite")]
        public int OperatorpveTotalxp213Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:D:infinite")]
        public int OperatorpvpTimeplayed3DInfinite { get; set; }

        [JsonPropertyName("operatorpve_sledge_hammerkill:4:1:infinite")]
        public int OperatorpveSledgeHammerkill41Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:D:infinite")]
        public int OperatorpvpKills3DInfinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:12:infinite")]
        public int OperatorpvpTimeplayed312Infinite { get; set; }

        [JsonPropertyName("operatorpvp_nomad_airjabdetonate:2:11:infinite")]
        public int OperatorpvpNomadAirjabdetonate211Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:3:6:infinite")]
        public int OperatorpveTimeplayed36Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:2:10:infinite")]
        public int OperatorpveDeath210Infinite { get; set; }

        [JsonPropertyName("operatorpvp_thermite_chargekill:5:2:infinite")]
        public int OperatorpvpThermiteChargekill52Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:2:13:infinite")]
        public int OperatorpveRoundwon213Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:19:infinite")]
        public int OperatorpvpTimeplayed219Infinite { get; set; }

        [JsonPropertyName("operatorpve_kapkan_boobytrapkill:4:4:infinite")]
        public int OperatorpveKapkanBoobytrapkill44Infinite { get; set; }

        [JsonPropertyName("operatorpvp_pulse_heartbeatspot:4:2:infinite")]
        public int OperatorpvpPulseHeartbeatspot42Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:3:infinite")]
        public int OperatorpvpRoundwon23Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:4:3:infinite")]
        public int OperatorpvpRoundwon43Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:6:1A:infinite")]
        public int OperatorpvpTotalxp61AInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:1:2:infinite")]
        public int OperatorpveRoundplayed12Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:4:2:infinite")]
        public int OperatorpvpDeath42Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:1:1:infinite")]
        public int OperatorpveKills11Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:4:4:infinite")]
        public int OperatorpvpRoundplayed44Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:3:2:infinite")]
        public int OperatorpveTimeplayed32Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:4:3:infinite")]
        public int OperatorpveRoundwon43Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:2:F:infinite")]
        public int OperatorpveRoundlost2FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:5:2:infinite")]
        public int OperatorpvpMeleekills52Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:3:7:infinite")]
        public int OperatorpveKills37Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:3:4:infinite")]
        public int OperatorpvpRoundlost34Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:5:2:infinite")]
        public int OperatorpveDeath52Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:5:infinite")]
        public int OperatorpvpKills35Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:3:9:infinite")]
        public int OperatorpveRoundlost39Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:18:infinite")]
        public int OperatorpvpTotalxp218Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:1:1B:infinite")]
        public int OperatorpvpTimeplayed11BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_kapkan_boobytrapkill:4:4:infinite")]
        public int OperatorpvpKapkanBoobytrapkill44Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:2:10:infinite")]
        public int OperatorpveMeleekills210Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:4:2:infinite")]
        public int OperatorpveHeadshot42Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:2:6:infinite")]
        public int OperatorpveHeadshot26Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:4:3:infinite")]
        public int OperatorpveTotalxp43Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:15:infinite")]
        public int OperatorpvpRoundplayed215Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:4:infinite")]
        public int OperatorpvpHeadshot24Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:5:infinite")]
        public int OperatorpvpDeath25Infinite { get; set; }

        [JsonPropertyName("operatorpvp_thermite_reinforcementbreached:5:2:infinite")]
        public int OperatorpvpThermiteReinforcementbreached52Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:3:B:infinite")]
        public int OperatorpveTimeplayed3BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:6:infinite")]
        public int OperatorpvpDbno26Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:3:3:infinite")]
        public int OperatorpveHeadshot33Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:5:16:infinite")]
        public int OperatorpvpDbno516Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:3:B:infinite")]
        public int OperatorpveRoundwon3BInfinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:2:8:infinite")]
        public int OperatorpveTimeplayed28Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:5:4:infinite")]
        public int OperatorpvpDeath54Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:4:1:infinite")]
        public int OperatorpveRoundwon41Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:F:infinite")]
        public int OperatorpvpTimeplayed3FInfinite { get; set; }

        [JsonPropertyName("operatorpve_rook_armortakenourself:3:3:infinite")]
        public int OperatorpveRookArmortakenourself33Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:1:5:infinite")]
        public int OperatorpvpRoundwon15Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:3:9:infinite")]
        public int OperatorpveDeath39Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:5:1:infinite")]
        public int OperatorpveTimeplayed51Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:1:2:infinite")]
        public int OperatorpvpTotalxp12Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:5:1:infinite")]
        public int OperatorpvpTimeplayed51Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:4:2:infinite")]
        public int OperatorpveRoundplayed42Infinite { get; set; }

        [JsonPropertyName("operatorpvp_blitz_flashshieldassist:2:5:infinite")]
        public int OperatorpvpBlitzFlashshieldassist25Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:5:5:infinite")]
        public int OperatorpvpTimeplayed55Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:5:infinite")]
        public int OperatorpvpTotalxp35Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:1:infinite")]
        public int OperatorpvpKills21Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:5:16:infinite")]
        public int OperatorpvpTotalxp516Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:2:19:infinite")]
        public int OperatorpveDeath219Infinite { get; set; }

        [JsonPropertyName("operatorpvp_gridlock_traxdeployed:3:12:infinite")]
        public int OperatorpvpGridlockTraxdeployed312Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:4:E:infinite")]
        public int OperatorpvpRoundwon4EInfinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:3:D:infinite")]
        public int OperatorpveTimeplayed3DInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:1:3:infinite")]
        public int OperatorpveRoundlost13Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:1A:infinite")]
        public int OperatorpvpTotalxp21AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:4:2:infinite")]
        public int OperatorpvpDbno42Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:3:12:infinite")]
        public int OperatorpveTimeplayed312Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:13:infinite")]
        public int OperatorpvpDeath213Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:B:infinite")]
        public int OperatorpvpRoundplayed3BInfinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:2:F:infinite")]
        public int OperatorpveTimeplayed2FInfinite { get; set; }

        [JsonPropertyName("operatorpve_kills:1:3:infinite")]
        public int OperatorpveKills13Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:5:2:infinite")]
        public int OperatorpveHeadshot52Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:2:18:infinite")]
        public int OperatorpveRoundplayed218Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:6:infinite")]
        public int OperatorpvpRoundplayed36Infinite { get; set; }

        [JsonPropertyName("operatorpve_smoke_poisongaskill:2:1:infinite")]
        public int OperatorpveSmokePoisongaskill21Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:5:3:infinite")]
        public int OperatorpveMeleekills53Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:1:infinite")]
        public int OperatorpvpHeadshot21Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:4:4:infinite")]
        public int OperatorpvpDeath44Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:3:F:infinite")]
        public int OperatorpvpRoundwon3FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_valkyrie_camdeployed:3:7:infinite")]
        public int OperatorpvpValkyrieCamdeployed37Infinite { get; set; }

        [JsonPropertyName("operatorpvp_ash_bonfirekill:3:2:infinite")]
        public int OperatorpvpAshBonfirekill32Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:2:B:infinite")]
        public int OperatorpveRoundplayed2BInfinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:3:3:infinite")]
        public int OperatorpveTimeplayed33Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:5:1:infinite")]
        public int OperatorpveMeleekills51Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:D:infinite")]
        public int OperatorpvpTotalxp2DInfinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:1:1:infinite")]
        public int OperatorpvpTimeplayed11Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:2:2:infinite")]
        public int OperatorpveTimeplayed22Infinite { get; set; }

        [JsonPropertyName("operatorpve_thatcher_gadgetdestroywithemp:5:1:infinite")]
        public int OperatorpveThatcherGadgetdestroywithemp51Infinite { get; set; }

        [JsonPropertyName("operatorpvp_deceiver_revealedattackers:3:F:infinite")]
        public int OperatorpvpDeceiverRevealedattackers3FInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:3:C:infinite")]
        public int OperatorpveRoundplayed3CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_black_mirror_gadget_deployed:3:A:infinite")]
        public int OperatorpvpBlackMirrorGadgetDeployed3AInfinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:3:2:infinite")]
        public int OperatorpveHeadshot32Infinite { get; set; }

        [JsonPropertyName("operatorpve_iq_gadgetspotbyef:3:5:infinite")]
        public int OperatorpveIqGadgetspotbyef35Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:4:3:infinite")]
        public int OperatorpveDeath43Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:4:1A:infinite")]
        public int OperatorpvpRoundlost41AInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:1:1:infinite")]
        public int OperatorpveRoundwon11Infinite { get; set; }

        [JsonPropertyName("operatorpvp_blitz_flashedenemy:2:5:infinite")]
        public int OperatorpvpBlitzFlashedenemy25Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:4:E:infinite")]
        public int OperatorpvpKills4EInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:3:3:infinite")]
        public int OperatorpvpRoundwon33Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:4:1:infinite")]
        public int OperatorpvpRoundwon41Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:4:infinite")]
        public int OperatorpvpRoundplayed24Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:5:3:infinite")]
        public int OperatorpveHeadshot53Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:18:infinite")]
        public int OperatorpvpDbno218Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:3:F:infinite")]
        public int OperatorpveRoundplayed3FInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:5:2:infinite")]
        public int OperatorpveRoundplayed52Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:7:infinite")]
        public int OperatorpvpRoundwon27Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:9:infinite")]
        public int OperatorpvpTotalxp29Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:7:infinite")]
        public int OperatorpvpRoundplayed27Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:6:infinite")]
        public int OperatorpvpDeath36Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:4:2:infinite")]
        public int OperatorpvpRoundwon42Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:18:infinite")]
        public int OperatorpvpRoundlost218Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:2:2:infinite")]
        public int OperatorpveTotalxp22Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:3:2:infinite")]
        public int OperatorpvpDbno32Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:1:5:infinite")]
        public int OperatorpvpKills15Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:5:3:infinite")]
        public int OperatorpvpTimeplayed53Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:4:E:infinite")]
        public int OperatorpvpTimeplayed4EInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:3:9:infinite")]
        public int OperatorpvpRoundwon39Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:4:4:infinite")]
        public int OperatorpvpDbno44Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:5:infinite")]
        public int OperatorpvpTimeplayed35Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:3:B:infinite")]
        public int OperatorpvpRoundwon3BInfinite { get; set; }

        [JsonPropertyName("operatorpve_kills:3:C:infinite")]
        public int OperatorpveKills3CInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:4:3:infinite")]
        public int OperatorpveRoundlost43Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:1A:infinite")]
        public int OperatorpvpRoundplayed31AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_sledge_hammerkill:4:1:infinite")]
        public int OperatorpvpSledgeHammerkill41Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:16:infinite")]
        public int OperatorpvpKills216Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:2:3:infinite")]
        public int OperatorpveRoundwon23Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:5:infinite")]
        public int OperatorpvpRoundwon25Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:14:infinite")]
        public int OperatorpvpDbno214Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:5:1:infinite")]
        public int OperatorpvpHeadshot51Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:5:1:infinite")]
        public int OperatorpveTotalxp51Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:2:5:infinite")]
        public int OperatorpveHeadshot25Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:3:12:infinite")]
        public int OperatorpvpRoundwon312Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:F:infinite")]
        public int OperatorpvpHeadshot2FInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:5:1:infinite")]
        public int OperatorpveRoundplayed51Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:2:3:infinite")]
        public int OperatorpveTimeplayed23Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:9:infinite")]
        public int OperatorpvpDbno29Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:19:infinite")]
        public int OperatorpvpHeadshot219Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:4:1A:infinite")]
        public int OperatorpvpTotalxp41AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:19:infinite")]
        public int OperatorpvpDbno219Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:5:1:infinite")]
        public int OperatorpveRoundlost51Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:14:infinite")]
        public int OperatorpvpDeath214Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:11:infinite")]
        public int OperatorpvpTimeplayed211Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:1:2:infinite")]
        public int OperatorpveKills12Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:4:1:infinite")]
        public int OperatorpvpKills41Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:1:infinite")]
        public int OperatorpvpTotalxp21Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:5:3:infinite")]
        public int OperatorpvpRoundplayed53Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:A:infinite")]
        public int OperatorpvpRoundwon2AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:7:infinite")]
        public int OperatorpvpKills37Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:3:4:infinite")]
        public int OperatorpveDeath34Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:6:infinite")]
        public int OperatorpvpRoundplayed26Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:1:1B:infinite")]
        public int OperatorpvpHeadshot11BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:F:infinite")]
        public int OperatorpvpRoundplayed3FInfinite { get; set; }

        [JsonPropertyName("operatorpve_frost_beartrap_kill:3:6:infinite")]
        public int OperatorpveFrostBeartrapKill36Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:9:infinite")]
        public int OperatorpvpHeadshot29Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:4:1:infinite")]
        public int OperatorpveTotalxp41Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:1:3:infinite")]
        public int OperatorpvpDbno13Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:7:infinite")]
        public int OperatorpvpDeath37Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:2:19:infinite")]
        public int OperatorpvpMeleekills219Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:6:infinite")]
        public int OperatorpvpTimeplayed36Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:D:infinite")]
        public int OperatorpvpRoundplayed3DInfinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:1A:infinite")]
        public int OperatorpvpDeath21AInfinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:3:4:infinite")]
        public int OperatorpveTotalxp34Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:C:infinite")]
        public int OperatorpvpKills3CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:A:infinite")]
        public int OperatorpvpRoundlost2AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:B:infinite")]
        public int OperatorpvpTimeplayed3BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:9:infinite")]
        public int OperatorpvpRoundlost29Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:2:5:infinite")]
        public int OperatorpveTotalxp25Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:7:infinite")]
        public int OperatorpvpRoundplayed37Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:A:infinite")]
        public int OperatorpvpKills2AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:3:3:infinite")]
        public int OperatorpvpRoundlost33Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:4:infinite")]
        public int OperatorpvpDeath34Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:19:infinite")]
        public int OperatorpvpTotalxp219Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:2:19:infinite")]
        public int OperatorpveHeadshot219Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:2:9:infinite")]
        public int OperatorpveHeadshot29Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:5:infinite")]
        public int OperatorpvpTimeplayed25Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:A:infinite")]
        public int OperatorpvpTimeplayed3AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:13:infinite")]
        public int OperatorpvpTimeplayed213Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:4:4:infinite")]
        public int OperatorpveTotalxp44Infinite { get; set; }

        [JsonPropertyName("operatorpvp_rook_armortakenteammate:3:3:infinite")]
        public int OperatorpvpRookArmortakenteammate33Infinite { get; set; }

        [JsonPropertyName("operatorpvp_hibana_detonate_projectile:2:9:infinite")]
        public int OperatorpvpHibanaDetonateProjectile29Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dazzler_gadget_detonate:2:B:infinite")]
        public int OperatorpvpDazzlerGadgetDetonate2BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:C:infinite")]
        public int OperatorpvpDeath2CInfinite { get; set; }

        [JsonPropertyName("operatorpve_rook_armorboxdeployed:3:3:infinite")]
        public int OperatorpveRookArmorboxdeployed33Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:2:C:infinite")]
        public int OperatorpveKills2CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:11:infinite")]
        public int OperatorpvpDeath311Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:3:11:infinite")]
        public int OperatorpveRoundplayed311Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:16:infinite")]
        public int OperatorpvpTotalxp216Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:3:11:infinite")]
        public int OperatorpveRoundwon311Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:5:5:infinite")]
        public int OperatorpvpHeadshot55Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:5:5:infinite")]
        public int OperatorpvpKills55Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:3:C:infinite")]
        public int OperatorpveTotalxp3CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:5:16:infinite")]
        public int OperatorpvpTimeplayed516Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:8:infinite")]
        public int OperatorpvpTotalxp38Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:4:3:infinite")]
        public int OperatorpvpKills43Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:3:6:infinite")]
        public int OperatorpvpRoundwon36Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:9:infinite")]
        public int OperatorpvpDeath29Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:17:infinite")]
        public int OperatorpvpDeath317Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:B:infinite")]
        public int OperatorpvpRoundplayed2BInfinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:1:1:infinite")]
        public int OperatorpveTimeplayed11Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:2:10:infinite")]
        public int OperatorpvpMeleekills210Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:4:17:infinite")]
        public int OperatorpvpDbno417Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:F:infinite")]
        public int OperatorpvpDeath2FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:5:16:infinite")]
        public int OperatorpvpKills516Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:1:2:infinite")]
        public int OperatorpveTimeplayed12Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:6:16:infinite")]
        public int OperatorpvpDeath616Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:2:8:infinite")]
        public int OperatorpveHeadshot28Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:15:infinite")]
        public int OperatorpvpTotalxp215Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:8:infinite")]
        public int OperatorpvpRoundplayed38Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:2:13:infinite")]
        public int OperatorpveDeath213Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:3:8:infinite")]
        public int OperatorpvpDbno38Infinite { get; set; }

        [JsonPropertyName("operatorpvp_doc_teammaterevive:2:3:infinite")]
        public int OperatorpvpDocTeammaterevive23Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:3:6:infinite")]
        public int OperatorpveRoundplayed36Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:2:18:infinite")]
        public int OperatorpveRoundwon218Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:8:infinite")]
        public int OperatorpvpDeath38Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:1:2:infinite")]
        public int OperatorpvpKills12Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:2:F:infinite")]
        public int OperatorpvpMeleekills2FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:3:4:infinite")]
        public int OperatorpvpMeleekills34Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:5:1:infinite")]
        public int OperatorpvpMeleekills51Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:3:5:infinite")]
        public int OperatorpveRoundlost35Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:11:infinite")]
        public int OperatorpvpRoundplayed311Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:2:9:infinite")]
        public int OperatorpveKills29Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:2:19:infinite")]
        public int OperatorpveTimeplayed219Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:5:3:infinite")]
        public int OperatorpvpDbno53Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:2:18:infinite")]
        public int OperatorpveTimeplayed218Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:B:infinite")]
        public int OperatorpvpKills3BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:12:infinite")]
        public int OperatorpvpRoundwon212Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:10:infinite")]
        public int OperatorpvpRoundplayed310Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:2:C:infinite")]
        public int OperatorpveRoundwon2CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_mute_gadgetjammed:3:1:infinite")]
        public int OperatorpvpMuteGadgetjammed31Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:3:B:infinite")]
        public int OperatorpvpDbno3BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:1:1B:infinite")]
        public int OperatorpvpRoundlost11BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:1:16:infinite")]
        public int OperatorpvpRoundplayed116Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:1:16:infinite")]
        public int OperatorpvpTimeplayed116Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:3:11:infinite")]
        public int OperatorpveKills311Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:4:E:infinite")]
        public int OperatorpveRoundwon4EInfinite { get; set; }

        [JsonPropertyName("operatorpve_death:3:2:infinite")]
        public int OperatorpveDeath32Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:5:1:infinite")]
        public int OperatorpvpRoundwon51Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:2:10:infinite")]
        public int OperatorpveHeadshot210Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:3:6:infinite")]
        public int OperatorpvpRoundlost36Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:4:infinite")]
        public int OperatorpvpRoundlost24Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:2:6:infinite")]
        public int OperatorpveMeleekills26Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:6:1A:infinite")]
        public int OperatorpvpRoundplayed61AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:1:infinite")]
        public int OperatorpvpTimeplayed21Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:5:5:infinite")]
        public int OperatorpveTotalxp55Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:2:10:infinite")]
        public int OperatorpveKills210Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:3:12:infinite")]
        public int OperatorpveRoundplayed312Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:1:3:infinite")]
        public int OperatorpvpKills13Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:2:3:infinite")]
        public int OperatorpveRoundlost23Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:5:2:infinite")]
        public int OperatorpveRoundwon52Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:1:3:infinite")]
        public int OperatorpveRoundplayed13Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:15:infinite")]
        public int OperatorpvpRoundlost215Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:16:infinite")]
        public int OperatorpvpDeath316Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:C:infinite")]
        public int OperatorpvpKills2CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:2:infinite")]
        public int OperatorpvpTimeplayed22Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:5:3:infinite")]
        public int OperatorpveTimeplayed53Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:1:5:infinite")]
        public int OperatorpvpDbno15Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:1:4:infinite")]
        public int OperatorpvpTotalxp14Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:1A:infinite")]
        public int OperatorpvpTimeplayed31AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:4:17:infinite")]
        public int OperatorpvpRoundplayed417Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:4:4:infinite")]
        public int OperatorpvpHeadshot44Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:10:infinite")]
        public int OperatorpvpTimeplayed210Infinite { get; set; }

        [JsonPropertyName("operatorpvp_rook_armorboxdeployed:3:3:infinite")]
        public int OperatorpvpRookArmorboxdeployed33Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:3:2:infinite")]
        public int OperatorpvpMeleekills32Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:5:3:infinite")]
        public int OperatorpveDeath53Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:1:3:infinite")]
        public int OperatorpvpRoundlost13Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:3:4:infinite")]
        public int OperatorpvpDbno34Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:3:7:infinite")]
        public int OperatorpveRoundwon37Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:2:infinite")]
        public int OperatorpvpRoundplayed22Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:2:6:infinite")]
        public int OperatorpveTimeplayed26Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:12:infinite")]
        public int OperatorpvpTotalxp312Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:A:infinite")]
        public int OperatorpvpTotalxp3AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:4:E:infinite")]
        public int OperatorpvpHeadshot4EInfinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:5:4:infinite")]
        public int OperatorpvpHeadshot54Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:1:infinite")]
        public int OperatorpvpRoundplayed21Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:4:4:infinite")]
        public int OperatorpvpRoundwon44Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:1:2:infinite")]
        public int OperatorpvpDeath12Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:1:1:infinite")]
        public int OperatorpveRoundplayed11Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:2:2:infinite")]
        public int OperatorpveHeadshot22Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:5:infinite")]
        public int OperatorpvpRoundplayed35Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:1:1:infinite")]
        public int OperatorpvpDeath11Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:5:1:infinite")]
        public int OperatorpveHeadshot51Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:7:infinite")]
        public int OperatorpvpHeadshot27Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:1:1B:infinite")]
        public int OperatorpvpRoundplayed11BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:3:2:infinite")]
        public int OperatorpvpRoundwon32Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:3:5:infinite")]
        public int OperatorpveRoundplayed35Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:6:infinite")]
        public int OperatorpvpKills36Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:2:9:infinite")]
        public int OperatorpveMeleekills29Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:3:9:infinite")]
        public int OperatorpveTotalxp39Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:3:D:infinite")]
        public int OperatorpveRoundplayed3DInfinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:2:B:infinite")]
        public int OperatorpvpMeleekills2BInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:2:B:infinite")]
        public int OperatorpveRoundlost2BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:F:infinite")]
        public int OperatorpvpDbno2FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:5:1:infinite")]
        public int OperatorpvpTotalxp51Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:3:5:infinite")]
        public int OperatorpveRoundwon35Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:2:11:infinite")]
        public int OperatorpveMeleekills211Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:6:16:infinite")]
        public int OperatorpvpTimeplayed616Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:A:infinite")]
        public int OperatorpvpRoundplayed3AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:1:3:infinite")]
        public int OperatorpvpTotalxp13Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:4:1A:infinite")]
        public int OperatorpvpDeath41AInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:2:10:infinite")]
        public int OperatorpveRoundwon210Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:1:1:infinite")]
        public int OperatorpveTotalxp11Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:18:infinite")]
        public int OperatorpvpDeath218Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:3:1A:infinite")]
        public int OperatorpvpRoundlost31AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:3:infinite")]
        public int OperatorpvpTotalxp23Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:3:5:infinite")]
        public int OperatorpvpHeadshot35Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:3:1:infinite")]
        public int OperatorpvpRoundlost31Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:5:2:infinite")]
        public int OperatorpvpHeadshot52Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:3:D:infinite")]
        public int OperatorpveRoundlost3DInfinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:8:infinite")]
        public int OperatorpvpTimeplayed38Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:17:infinite")]
        public int OperatorpvpTimeplayed317Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:4:1A:infinite")]
        public int OperatorpvpRoundplayed41AInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:2:8:infinite")]
        public int OperatorpveRoundplayed28Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:3:infinite")]
        public int OperatorpvpKills23Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:2:18:infinite")]
        public int OperatorpveTotalxp218Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:5:3:infinite")]
        public int OperatorpveKills53Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:3:D:infinite")]
        public int OperatorpvpRoundwon3DInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:1:16:infinite")]
        public int OperatorpvpRoundwon116Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:1A:infinite")]
        public int OperatorpvpKills21AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:5:5:infinite")]
        public int OperatorpvpDbno55Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:3:5:infinite")]
        public int OperatorpvpRoundwon35Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:4:E:infinite")]
        public int OperatorpveTimeplayed4EInfinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:18:infinite")]
        public int OperatorpvpHeadshot218Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:C:infinite")]
        public int OperatorpvpTotalxp2CInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:3:B:infinite")]
        public int OperatorpveRoundplayed3BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_rush_adrenalinerush:4:E:infinite")]
        public int OperatorpvpRushAdrenalinerush4EInfinite { get; set; }

        [JsonPropertyName("operatorpve_kills:4:E:infinite")]
        public int OperatorpveKills4EInfinite { get; set; }

        [JsonPropertyName("operatorpve_death:5:5:infinite")]
        public int OperatorpveDeath55Infinite { get; set; }

        [JsonPropertyName("operatorpve_thermite_reinforcementbreached:5:2:infinite")]
        public int OperatorpveThermiteReinforcementbreached52Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:5:1:infinite")]
        public int OperatorpvpRoundplayed51Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:3:2:infinite")]
        public int OperatorpveMeleekills32Infinite { get; set; }

        [JsonPropertyName("operatorpvp_caveira_interrogations:3:8:infinite")]
        public int OperatorpvpCaveiraInterrogations38Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:4:17:infinite")]
        public int OperatorpveRoundwon417Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:1:1:infinite")]
        public int OperatorpvpRoundlost11Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:3:F:infinite")]
        public int OperatorpveKills3FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:15:infinite")]
        public int OperatorpvpRoundwon215Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:7:16:infinite")]
        public int OperatorpvpRoundlost716Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:E:infinite")]
        public int OperatorpvpTimeplayed3EInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:4:4:infinite")]
        public int OperatorpvpRoundlost44Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:3:6:infinite")]
        public int OperatorpvpHeadshot36Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:1:3:infinite")]
        public int OperatorpvpTimeplayed13Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:2:19:infinite")]
        public int OperatorpveRoundplayed219Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:2:F:infinite")]
        public int OperatorpveTotalxp2FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:10:infinite")]
        public int OperatorpvpDeath210Infinite { get; set; }

        [JsonPropertyName("operatorpvp_mute_jammerdeployed:3:1:infinite")]
        public int OperatorpvpMuteJammerdeployed31Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:2:8:infinite")]
        public int OperatorpvpMeleekills28Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:4:16:infinite")]
        public int OperatorpvpTimeplayed416Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:3:infinite")]
        public int OperatorpvpHeadshot23Infinite { get; set; }

        [JsonPropertyName("operatorpvp_rook_armortakenourself:3:3:infinite")]
        public int OperatorpvpRookArmortakenourself33Infinite { get; set; }

        [JsonPropertyName("operatorpvp_melusi_sloweddown:2:1A:infinite")]
        public int OperatorpvpMelusiSloweddown21AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:1:4:infinite")]
        public int OperatorpvpKills14Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:16:infinite")]
        public int OperatorpvpDeath216Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:11:infinite")]
        public int OperatorpvpKills211Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:F:infinite")]
        public int OperatorpvpKills3FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_ash_bonfirewallbreached:3:2:infinite")]
        public int OperatorpvpAshBonfirewallbreached32Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:4:3:infinite")]
        public int OperatorpvpMeleekills43Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:2:C:infinite")]
        public int OperatorpveTotalxp2CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:6:infinite")]
        public int OperatorpvpDeath26Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:1:infinite")]
        public int OperatorpvpTimeplayed31Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:5:3:infinite")]
        public int OperatorpvpMeleekills53Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:3:5:infinite")]
        public int OperatorpveTimeplayed35Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:16:infinite")]
        public int OperatorpvpTimeplayed316Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:10:infinite")]
        public int OperatorpvpHeadshot210Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:7:infinite")]
        public int OperatorpvpTotalxp27Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:3:4:infinite")]
        public int OperatorpveMeleekills34Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:6:16:infinite")]
        public int OperatorpvpRoundplayed616Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:2:12:infinite")]
        public int OperatorpveHeadshot212Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:5:3:infinite")]
        public int OperatorpvpRoundwon53Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:3:17:infinite")]
        public int OperatorpvpDbno317Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:2:10:infinite")]
        public int OperatorpveTotalxp210Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:4:4:infinite")]
        public int OperatorpvpMeleekills44Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:4:E:infinite")]
        public int OperatorpvpDbno4EInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:2:1:infinite")]
        public int OperatorpveRoundwon21Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:3:4:infinite")]
        public int OperatorpveRoundplayed34Infinite { get; set; }

        [JsonPropertyName("operatorpve_glaz_sniperpenetrationkill:2:4:infinite")]
        public int OperatorpveGlazSniperpenetrationkill24Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:4:infinite")]
        public int OperatorpvpTotalxp24Infinite { get; set; }

        [JsonPropertyName("operatorpve_sledge_hammerhole:4:1:infinite")]
        public int OperatorpveSledgeHammerhole41Infinite { get; set; }

        [JsonPropertyName("operatorpvp_thatcher_gadgetdestroywithemp:5:1:infinite")]
        public int OperatorpvpThatcherGadgetdestroywithemp51Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:16:infinite")]
        public int OperatorpvpKills316Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:2:2:infinite")]
        public int OperatorpveKills22Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:3:D:infinite")]
        public int OperatorpveRoundwon3DInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:3:A:infinite")]
        public int OperatorpvpRoundlost3AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:3:17:infinite")]
        public int OperatorpvpRoundlost317Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:5:3:infinite")]
        public int OperatorpveTotalxp53Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:7:infinite")]
        public int OperatorpvpTimeplayed27Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:1:3:infinite")]
        public int OperatorpveTotalxp13Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:4:3:infinite")]
        public int OperatorpvpHeadshot43Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:3:9:infinite")]
        public int OperatorpveMeleekills39Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:4:4:infinite")]
        public int OperatorpveRoundplayed44Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:3:4:infinite")]
        public int OperatorpvpRoundwon34Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:3:9:infinite")]
        public int OperatorpvpRoundlost39Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:2:5:infinite")]
        public int OperatorpvpMeleekills25Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:9:infinite")]
        public int OperatorpvpKills39Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:4:5:infinite")]
        public int OperatorpvpRoundwon45Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:1:infinite")]
        public int OperatorpvpRoundwon21Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:4:infinite")]
        public int OperatorpvpTimeplayed24Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundlost:2:9:infinite")]
        public int OperatorpveRoundlost29Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:F:infinite")]
        public int OperatorpvpRoundlost2FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:4:infinite")]
        public int OperatorpvpRoundplayed34Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:3:11:infinite")]
        public int OperatorpvpRoundwon311Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:3:12:infinite")]
        public int OperatorpvpDbno312Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:5:2:infinite")]
        public int OperatorpvpTimeplayed52Infinite { get; set; }

        [JsonPropertyName("operatorpvp_thermite_chargedeployed:5:2:infinite")]
        public int OperatorpvpThermiteChargedeployed52Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:4:1:infinite")]
        public int OperatorpveKills41Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:5:2:infinite")]
        public int OperatorpvpRoundplayed52Infinite { get; set; }

        [JsonPropertyName("operatorpvp_glaz_sniperkill:2:4:infinite")]
        public int OperatorpvpGlazSniperkill24Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:4:infinite")]
        public int OperatorpvpDeath24Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:1:3:infinite")]
        public int OperatorpveTimeplayed13Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:5:infinite")]
        public int OperatorpvpTotalxp25Infinite { get; set; }

        [JsonPropertyName("operatorpve_glaz_sniperkill:2:4:infinite")]
        public int OperatorpveGlazSniperkill24Infinite { get; set; }

        [JsonPropertyName("operatorpve_fuze_clusterchargekill:3:4:infinite")]
        public int OperatorpveFuzeClusterchargekill34Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:B:infinite")]
        public int OperatorpvpKills2BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:4:5:infinite")]
        public int OperatorpvpKills45Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:3:7:infinite")]
        public int OperatorpveMeleekills37Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:3:11:infinite")]
        public int OperatorpveHeadshot311Infinite { get; set; }

        [JsonPropertyName("operatorpve_buck_kill:2:6:infinite")]
        public int OperatorpveBuckKill26Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:8:infinite")]
        public int OperatorpvpRoundlost28Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:1A:infinite")]
        public int OperatorpvpRoundlost21AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:3:F:infinite")]
        public int OperatorpvpMeleekills3FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:B:infinite")]
        public int OperatorpvpDbno2BInfinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:4:17:infinite")]
        public int OperatorpveTotalxp417Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:5:infinite")]
        public int OperatorpvpDbno25Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:15:infinite")]
        public int OperatorpvpTimeplayed215Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:5:5:infinite")]
        public int OperatorpvpMeleekills55Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:5:3:infinite")]
        public int OperatorpveRoundwon53Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:2:infinite")]
        public int OperatorpvpRoundplayed32Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:4:E:infinite")]
        public int OperatorpveMeleekills4EInfinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:14:infinite")]
        public int OperatorpvpHeadshot214Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:19:infinite")]
        public int OperatorpvpRoundplayed219Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:1A:infinite")]
        public int OperatorpvpDbno21AInfinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:4:2:infinite")]
        public int OperatorpveTimeplayed42Infinite { get; set; }

        [JsonPropertyName("operatorpvp_jager_gadgetdestroybycatcher:4:5:infinite")]
        public int OperatorpvpJagerGadgetdestroybycatcher45Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:4:3:infinite")]
        public int OperatorpvpRoundlost43Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:12:infinite")]
        public int OperatorpvpDbno212Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:2:9:infinite")]
        public int OperatorpveRoundwon29Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:4:5:infinite")]
        public int OperatorpvpDeath45Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:5:infinite")]
        public int OperatorpvpRoundplayed25Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:3:F:infinite")]
        public int OperatorpveTimeplayed3FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:A:infinite")]
        public int OperatorpvpKills3AInfinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:4:17:infinite")]
        public int OperatorpveHeadshot417Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:1:5:infinite")]
        public int OperatorpvpHeadshot15Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:2:4:infinite")]
        public int OperatorpveTimeplayed24Infinite { get; set; }

        [JsonPropertyName("operatorpvp_blackbeard_gunshieldblockdamage:2:7:infinite")]
        public int OperatorpvpBlackbeardGunshieldblockdamage27Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:1:2:infinite")]
        public int OperatorpvpRoundplayed12Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:17:infinite")]
        public int OperatorpvpRoundplayed317Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:A:infinite")]
        public int OperatorpvpTotalxp2AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:E:infinite")]
        public int OperatorpvpRoundplayed3EInfinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:5:4:infinite")]
        public int OperatorpvpKills54Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:8:infinite")]
        public int OperatorpvpRoundwon28Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:1:2:infinite")]
        public int OperatorpvpRoundwon12Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:2:1:infinite")]
        public int OperatorpveKills21Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:2:C:infinite")]
        public int OperatorpveRoundplayed2CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:3:10:infinite")]
        public int OperatorpvpRoundwon310Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:13:infinite")]
        public int OperatorpvpDbno213Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:4:5:infinite")]
        public int OperatorpvpRoundlost45Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:6:infinite")]
        public int OperatorpvpTotalxp36Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:3:2:infinite")]
        public int OperatorpveRoundwon32Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:1:3:infinite")]
        public int OperatorpveRoundwon13Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:5:3:infinite")]
        public int OperatorpvpRoundlost53Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:4:17:infinite")]
        public int OperatorpvpRoundlost417Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:3:1:infinite")]
        public int OperatorpvpDbno31Infinite { get; set; }

        [JsonPropertyName("operatorpvp_cazador_assist_kill:2:A:infinite")]
        public int OperatorpvpCazadorAssistKill2AInfinite { get; set; }

        [JsonPropertyName("operatorpve_death:2:8:infinite")]
        public int OperatorpveDeath28Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:4:16:infinite")]
        public int OperatorpvpDeath416Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:3:4:infinite")]
        public int OperatorpveHeadshot34Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:4:infinite")]
        public int OperatorpvpTimeplayed34Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:16:infinite")]
        public int OperatorpvpHeadshot216Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:3:B:infinite")]
        public int OperatorpveDeath3BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:3:E:infinite")]
        public int OperatorpvpHeadshot3EInfinite { get; set; }

        [JsonPropertyName("operatorpve_death:3:D:infinite")]
        public int OperatorpveDeath3DInfinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:3:C:infinite")]
        public int OperatorpvpMeleekills3CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:3:7:infinite")]
        public int OperatorpvpDbno37Infinite { get; set; }

        [JsonPropertyName("operatorpvp_capitao_lethaldartkills:2:8:infinite")]
        public int OperatorpvpCapitaoLethaldartkills28Infinite { get; set; }

        [JsonPropertyName("operatorpvp_frost_dbno:3:6:infinite")]
        public int OperatorpvpFrostDbno36Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:3:7:infinite")]
        public int OperatorpveRoundplayed37Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:F:infinite")]
        public int OperatorpvpTotalxp2FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_concussionmine_detonate:2:C:infinite")]
        public int OperatorpvpConcussionmineDetonate2CInfinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:4:17:infinite")]
        public int OperatorpveTimeplayed417Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:11:infinite")]
        public int OperatorpvpRoundplayed211Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:3:4:infinite")]
        public int OperatorpvpHeadshot34Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:2:3:infinite")]
        public int OperatorpveKills23Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:1A:infinite")]
        public int OperatorpvpDeath31AInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:2:5:infinite")]
        public int OperatorpveRoundplayed25Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:13:infinite")]
        public int OperatorpvpKills213Infinite { get; set; }

        [JsonPropertyName("operatorpvp_doc_selfrevive:2:3:infinite")]
        public int OperatorpvpDocSelfrevive23Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:8:16:infinite")]
        public int OperatorpvpRoundlost816Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:15:infinite")]
        public int OperatorpvpDeath215Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:5:4:infinite")]
        public int OperatorpvpRoundlost54Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:1:infinite")]
        public int OperatorpvpTotalxp31Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:E:infinite")]
        public int OperatorpvpKills3EInfinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:3:infinite")]
        public int OperatorpvpTimeplayed33Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:5:5:infinite")]
        public int OperatorpveRoundwon55Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:4:2:infinite")]
        public int OperatorpvpTotalxp42Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:2:B:infinite")]
        public int OperatorpveTimeplayed2BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_montagne_shieldblockdamage:5:3:infinite")]
        public int OperatorpvpMontagneShieldblockdamage53Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:3:5:infinite")]
        public int OperatorpvpMeleekills35Infinite { get; set; }

        [JsonPropertyName("operatorpvp_maverick_wallbreached:2:10:infinite")]
        public int OperatorpvpMaverickWallbreached210Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:12:infinite")]
        public int OperatorpvpDeath212Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:4:1:infinite")]
        public int OperatorpveTimeplayed41Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:2:F:infinite")]
        public int OperatorpveDeath2FInfinite { get; set; }

        [JsonPropertyName("operatorpve_kills:4:3:infinite")]
        public int OperatorpveKills43Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:D:infinite")]
        public int OperatorpvpKills2DInfinite { get; set; }

        [JsonPropertyName("operatorpvp_buck_kill:2:6:infinite")]
        public int OperatorpvpBuckKill26Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:5:4:infinite")]
        public int OperatorpvpDbno54Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:B:infinite")]
        public int OperatorpvpRoundwon2BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:11:infinite")]
        public int OperatorpvpRoundlost211Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:2:12:infinite")]
        public int OperatorpveRoundplayed212Infinite { get; set; }

        [JsonPropertyName("operatorpve_twitch_gadgetdestroybyshockdrone:4:3:infinite")]
        public int OperatorpveTwitchGadgetdestroybyshockdrone43Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:2:3:infinite")]
        public int OperatorpveTotalxp23Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:4:4:infinite")]
        public int OperatorpveHeadshot44Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:2:2:infinite")]
        public int OperatorpveDeath22Infinite { get; set; }

        [JsonPropertyName("operatorpve_death:3:3:infinite")]
        public int OperatorpveDeath33Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:10:infinite")]
        public int OperatorpvpKills310Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:F:infinite")]
        public int OperatorpvpKills2FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:4:infinite")]
        public int OperatorpvpKills24Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:10:infinite")]
        public int OperatorpvpDbno210Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:1A:infinite")]
        public int OperatorpvpTimeplayed21AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:14:infinite")]
        public int OperatorpvpKills214Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:3:16:infinite")]
        public int OperatorpvpRoundlost316Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:5:1:infinite")]
        public int OperatorpveRoundwon51Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:D:infinite")]
        public int OperatorpvpRoundplayed2DInfinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:3:6:infinite")]
        public int OperatorpvpMeleekills36Infinite { get; set; }

        [JsonPropertyName("operatorpve_ash_bonfirewallbreached:3:2:infinite")]
        public int OperatorpveAshBonfirewallbreached32Infinite { get; set; }

        [JsonPropertyName("operatorpve_kapkan_boobytrapdeployed:4:4:infinite")]
        public int OperatorpveKapkanBoobytrapdeployed44Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:2:infinite")]
        public int OperatorpvpTotalxp22Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:4:1:infinite")]
        public int OperatorpvpTimeplayed41Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:2:infinite")]
        public int OperatorpvpTotalxp32Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:3:1A:infinite")]
        public int OperatorpvpTotalxp31AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:2:14:infinite")]
        public int OperatorpvpRoundplayed214Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:1:infinite")]
        public int OperatorpvpDeath31Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kaid_electroclawelectrify:3:11:infinite")]
        public int OperatorpvpKaidElectroclawelectrify311Infinite { get; set; }

        [JsonPropertyName("operatorpve_hibana_detonate_projectile:2:9:infinite")]
        public int OperatorpveHibanaDetonateProjectile29Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:9:infinite")]
        public int OperatorpvpRoundplayed39Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:2:A:infinite")]
        public int OperatorpvpDeath2AInfinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:3:B:infinite")]
        public int OperatorpvpHeadshot3BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:3:6:infinite")]
        public int OperatorpvpDbno36Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:2:9:infinite")]
        public int OperatorpveTotalxp29Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:3:12:infinite")]
        public int OperatorpveTotalxp312Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:E:infinite")]
        public int OperatorpvpDeath3EInfinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:3:D:infinite")]
        public int OperatorpveHeadshot3DInfinite { get; set; }

        [JsonPropertyName("operatorpvp_death:1:4:infinite")]
        public int OperatorpvpDeath14Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:2:1:infinite")]
        public int OperatorpvpDbno21Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:2:10:infinite")]
        public int OperatorpveRoundplayed210Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:2:6:infinite")]
        public int OperatorpvpKills26Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:4:2:infinite")]
        public int OperatorpvpKills42Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:1:4:infinite")]
        public int OperatorpvpTimeplayed14Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:3:F:infinite")]
        public int OperatorpveHeadshot3FInfinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:1:infinite")]
        public int OperatorpvpKills31Infinite { get; set; }

        [JsonPropertyName("operatorpvp_tachanka_turretkill:5:4:infinite")]
        public int OperatorpvpTachankaTurretkill54Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:12:infinite")]
        public int OperatorpvpTimeplayed212Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:3:5:infinite")]
        public int OperatorpveHeadshot35Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:5:2:infinite")]
        public int OperatorpvpDeath52Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:2:C:infinite")]
        public int OperatorpveTimeplayed2CInfinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:2:14:infinite")]
        public int OperatorpvpTotalxp214Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:3:7:infinite")]
        public int OperatorpveTotalxp37Infinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:2:6:infinite")]
        public int OperatorpvpMeleekills26Infinite { get; set; }

        [JsonPropertyName("operatorpve_totalxp:2:1:infinite")]
        public int OperatorpveTotalxp21Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:C:infinite")]
        public int OperatorpvpRoundplayed3CInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:3:3:infinite")]
        public int OperatorpveRoundplayed33Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:8:infinite")]
        public int OperatorpvpTimeplayed28Infinite { get; set; }

        [JsonPropertyName("operatorpvp_kills:3:3:infinite")]
        public int OperatorpvpKills33Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:9:infinite")]
        public int OperatorpvpDeath39Infinite { get; set; }

        [JsonPropertyName("operatorpvp_blitz_flashfollowupkills:2:5:infinite")]
        public int OperatorpvpBlitzFlashfollowupkills25Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundwon:2:1A:infinite")]
        public int OperatorpvpRoundwon21AInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:3:6:infinite")]
        public int OperatorpveRoundwon36Infinite { get; set; }

        [JsonPropertyName("operatorpve_timeplayed:2:9:infinite")]
        public int OperatorpveTimeplayed29Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:2:6:infinite")]
        public int OperatorpvpRoundlost26Infinite { get; set; }

        [JsonPropertyName("operatorpvp_totalxp:8:16:infinite")]
        public int OperatorpvpTotalxp816Infinite { get; set; }

        [JsonPropertyName("operatorpve_capitao_lethaldartkills:2:8:infinite")]
        public int OperatorpveCapitaoLethaldartkills28Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundplayed:3:12:infinite")]
        public int OperatorpvpRoundplayed312Infinite { get; set; }

        [JsonPropertyName("operatorpve_meleekills:5:2:infinite")]
        public int OperatorpveMeleekills52Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:9:infinite")]
        public int OperatorpvpTimeplayed29Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:3:C:infinite")]
        public int OperatorpvpTimeplayed3CInfinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:2:6:infinite")]
        public int OperatorpveRoundwon26Infinite { get; set; }

        [JsonPropertyName("operatorpvp_roundlost:3:5:infinite")]
        public int OperatorpvpRoundlost35Infinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:12:infinite")]
        public int OperatorpvpHeadshot212Infinite { get; set; }

        [JsonPropertyName("operatorpvp_castle_kevlarbarricadedeployed:2:2:infinite")]
        public int OperatorpvpCastleKevlarbarricadedeployed22Infinite { get; set; }

        [JsonPropertyName("operatorpve_headshot:2:1:infinite")]
        public int OperatorpveHeadshot21Infinite { get; set; }

        [JsonPropertyName("operatorpvp_death:5:16:infinite")]
        public int OperatorpvpDeath516Infinite { get; set; }

        [JsonPropertyName("operatorpvp_dbno:4:1:infinite")]
        public int OperatorpvpDbno41Infinite { get; set; }

        [JsonPropertyName("operatorpvp_timeplayed:2:D:infinite")]
        public int OperatorpvpTimeplayed2DInfinite { get; set; }

        [JsonPropertyName("operatorpvp_meleekills:2:3:infinite")]
        public int OperatorpvpMeleekills23Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundplayed:2:6:infinite")]
        public int OperatorpveRoundplayed26Infinite { get; set; }

        [JsonPropertyName("operatorpve_roundwon:2:B:infinite")]
        public int OperatorpveRoundwon2BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_death:3:10:infinite")]
        public int OperatorpvpDeath310Infinite { get; set; }

        [JsonPropertyName("operatorpve_kills:2:B:infinite")]
        public int OperatorpveKills2BInfinite { get; set; }

        [JsonPropertyName("operatorpvp_headshot:2:11:infinite")]
        public int OperatorpvpHeadshot211Infinite { get; set; }
    }
}
