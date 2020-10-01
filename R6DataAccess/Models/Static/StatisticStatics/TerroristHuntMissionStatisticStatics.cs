using System;
using System.Collections.Generic;
using System.Text;

namespace R6DataAccess.Models.Static.StatisticStatics
{
    class TerroristHuntMissionStatisticStatics
    {

        // Terrorist Hunt/Training Grounds and missions
        private const string AllTerroHunt = "allterrohuntcoop_hard_bestscore,allterrohuntcoop_normal_bestscore,allterrohuntcoop_realistic_bestscore,allterrohuntsolo_hard_bestscore,allterrohuntsolo_normal_bestscore,allterrohuntsolo_realistic_bestscore";
        private const string TerroHuntClassic = "terrohuntclassicpve_bestscore,terrohuntclassicpve_matchlost,terrohuntclassicpve_matchplayed,terrohuntclassicpve_matchwlratio,terrohuntclassicpve_matchwon,terrohuntclassicpve_timeplayed";
        private const string MissionSolo = "missionsolo_hard_bestscore,missionsolo_normal_bestscore,missionsolo_realistic_bestscore";
        private const string MissionCoop = "missioncoop_hard_bestscore,missioncoop_normal_bestscore,missioncoop_realistic_bestscore";
        private const string MissionsByPlaylist = "missionsbyplaylistpve_bestscore";


        public static string GetStatistic()
        {
            return string.Join(",", AllTerroHunt, TerroHuntClassic, MissionCoop, MissionSolo, MissionsByPlaylist);
        }
    }
}

