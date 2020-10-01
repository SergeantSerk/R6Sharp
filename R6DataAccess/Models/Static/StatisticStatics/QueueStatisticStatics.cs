using System;
using System.Collections.Generic;
using System.Text;

namespace R6DataAccess.Models.Static.StatisticStatics
{
    class QueueStatisticStatics
    {

        // General and queues
        private const string GeneralPve = "generalpve_accuracy,generalpve_barricadedeployed,generalpve_blindkills,generalpve_bulletfired,generalpve_bullethit,generalpve_dbno,generalpve_dbnoassists,generalpve_death,generalpve_death:infinite,generalpve_distancetravelled,generalpve_gadgetdestroy,generalpve_headshot,generalpve_hostagedefense,generalpve_hostagerescue,generalpve_kdratio,generalpve_killassists,generalpve_kills,generalpve_kills:infinite,generalpve_matchlost,generalpve_matchlost:infinite,generalpve_matchplayed,generalpve_matchplayed:infinite,generalpve_matchwlratio,generalpve_matchwon,generalpve_matchwon:infinite,generalpve_meleekills,generalpve_penetrationkills,generalpve_rappelbreach,generalpve_reinforcementdeploy,generalpve_revive,generalpve_revivedenied,generalpve_serveraggression,generalpve_serverdefender,generalpve_servershacked,generalpve_suicide,generalpve_timeplayed,generalpve_timeplayed:infinite,generalpve_totalxp";
        private const string GeneralPvp = "generalpvp_accuracy,generalpvp_barricadedeployed,generalpvp_barricadedeployed:infinite,generalpvp_blindkills,generalpvp_bulletfired,generalpvp_bulletfired:infinite,generalpvp_bullethit,generalpvp_bullethit:infinite,generalpvp_dbno,generalpvp_dbno:infinite,generalpvp_dbnoassists,generalpvp_death,generalpvp_death:infinite,generalpvp_distancetravelled,generalpvp_gadgetdestroy,generalpvp_headshot,generalpvp_headshot:infinite,generalpvp_hostagedefense,generalpvp_hostagerescue,generalpvp_kdratio,generalpvp_killassists,generalpvp_killassists:infinite,generalpvp_kills,generalpvp_kills:infinite,generalpvp_matchlost,generalpvp_matchlost:infinite,generalpvp_matchplayed,generalpvp_matchplayed:infinite,generalpvp_matchwlratio,generalpvp_matchwon,generalpvp_matchwon:infinite,generalpvp_meleekills,generalpvp_penetrationkills,generalpvp_rappelbreach,generalpvp_reinforcementdeploy,generalpvp_reinforcementdeploy:infinite,generalpvp_revive,generalpvp_revive:infinite,generalpvp_revivedenied,generalpvp_serveraggression,generalpvp_serverdefender,generalpvp_servershacked,generalpvp_suicide,generalpvp_suicide:infinite,generalpvp_timeplayed,generalpvp_timeplayed:infinite,generalpvp_totalxp";
        private const string NormalPvp = "normalpvp_matchlost,normalpvp_matchplayed,normalpvp_matchwlratio,normalpvp_matchwon,normalpvp_timeplayed";
        private const string CasualPvp = "casualpvp_death,casualpvp_death:infinite,casualpvp_kdratio,casualpvp_kills,casualpvp_kills:infinite,casualpvp_matchlost,casualpvp_matchlost:infinite,casualpvp_matchplayed,casualpvp_matchplayed:infinite,casualpvp_matchwlratio,casualpvp_matchwon,casualpvp_matchwon:infinite,casualpvp_timeplayed,casualpvp_timeplayed:infinite";
        private const string RankedPvp = "rankedpvp_death,rankedpvp_death:infinite,rankedpvp_kdratio,rankedpvp_kills,rankedpvp_kills:infinite,rankedpvp_matchlost,rankedpvp_matchlost:infinite,rankedpvp_matchplayed,rankedpvp_matchplayed:infinite,rankedpvp_matchwlratio,rankedpvp_matchwon,rankedpvp_matchwon:infinite,rankedpvp_timeplayed,rankedpvp_timeplayed:infinite";
        private const string CustomPvp = "custompvp_timeplayed";

        public static string GetStatistic()
        {
            return string.Join(",", GeneralPve, GeneralPvp, NormalPvp, CasualPvp, RankedPvp, CustomPvp);
        }
    }
}

