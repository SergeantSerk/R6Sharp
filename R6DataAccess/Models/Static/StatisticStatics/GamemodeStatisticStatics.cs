using System;
using System.Collections.Generic;
using System.Text;

namespace R6DataAccess.Models.Static
{
    public class GamemodeStatisticStatics
    {

        private const string ProtectHostagePve = "protecthostagepve_bestscore,protecthostagepve_hostagedefense,protecthostagepve_hostagerescue,protecthostagepve_matchlost,protecthostagepve_matchplayed,protecthostagepve_matchwlratio,protecthostagepve_matchwon,protecthostagepve_timeplayed";
        private const string PlantBombPve = "plantbombpve_bestscore,plantbombpve_matchlost,plantbombpve_matchplayed,plantbombpve_matchwlratio,plantbombpve_matchwon,plantbombpve_timeplayed";
        private const string PlantBombPvp = "plantbombpvp_bestscore,plantbombpvp_matchlost,plantbombpvp_matchplayed,plantbombpvp_matchwlratio,plantbombpvp_matchwon,plantbombpvp_timeplayed,plantbombpvp_totalxp";
        private const string RescueHostagePve = "rescuehostagepve_bestscore,rescuehostagepve_hostagedefense,rescuehostagepve_hostagerescue,rescuehostagepve_matchlost,rescuehostagepve_matchplayed,rescuehostagepve_matchwlratio,rescuehostagepve_matchwon,rescuehostagepve_timeplayed";
        private const string RescueHostagePvp = "rescuehostagepvp_bestscore,rescuehostagepvp_matchlost,rescuehostagepvp_matchplayed,rescuehostagepvp_matchwlratio,rescuehostagepvp_matchwon,rescuehostagepvp_totalxp";
        private const string SecureAreaPve = "secureareapve_bestscore,secureareapve_matchlost,secureareapve_matchplayed,secureareapve_matchwlratio,secureareapve_matchwon,secureareapve_serveraggression,secureareapve_serverdefender,secureareapve_servershacked,secureareapve_timeplayed";
        private const string SecureAreaPvp = "secureareapvp_bestscore,secureareapvp_matchlost,secureareapvp_matchplayed,secureareapvp_matchwlratio,secureareapvp_matchwon,secureareapvp_totalxp";
        public static string GetStatistic()
        {
            return string.Join(",", ProtectHostagePve, PlantBombPve, PlantBombPvp, RescueHostagePve, RescueHostagePvp, SecureAreaPve, SecureAreaPvp);
        }
    }
}
