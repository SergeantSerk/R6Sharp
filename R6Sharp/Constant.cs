using System;
using System.Collections.Generic;
using System.Linq;

namespace R6Sharp
{
    public enum StatisticsType
    {
        Equipments,
        Gamemodes,
        Operators,
        TerroristHuntMissions,
        Queues
    }

    internal static class Constant
    {
        internal static readonly string EquipmentsStatisticsVariable =
            $"{GadgetPve},{GadgetPvp},{WeaponPve}," +
            $"{WeaponPvp},{WeaponTypePve},{WeaponTypePvp}";

        internal static readonly string GamemodesStatisticsVariables =
            $"{ProtectHostagePve},{PlantBombPve},{PlantBombPvp}," +
            $"{RescueHostagePve},{RescueHostagePvp},{SecureAreaPve}," +
            $"{SecureAreaPvp}";

        internal static readonly string OperatorsStatisticsVariables =
            $"{OperatorPve},{OperatorPvp}";

        internal static readonly string QueuesStatisticsVariables =
            $"{GeneralPve},{GeneralPvp},{NormalPvp}," +
            $"{CasualPvp},{RankedPvp},{CustomPvp}";

        internal static readonly string TerroristHuntMissionsStatisticsVariables =
            $"{AllTerroHunt},{TerroHuntClassic},{MissionSolo},{MissionCoop},{MissionsByPlaylist}";

        // General and queues
        private const string GeneralPve = "generalpve_accuracy,generalpve_barricadedeployed,generalpve_blindkills,generalpve_bulletfired,generalpve_bullethit,generalpve_dbno,generalpve_dbnoassists,generalpve_death,generalpve_death:infinite,generalpve_distancetravelled,generalpve_gadgetdestroy,generalpve_headshot,generalpve_hostagedefense,generalpve_hostagerescue,generalpve_kdratio,generalpve_killassists,generalpve_kills,generalpve_kills:infinite,generalpve_matchlost,generalpve_matchlost:infinite,generalpve_matchplayed,generalpve_matchplayed:infinite,generalpve_matchwlratio,generalpve_matchwon,generalpve_matchwon:infinite,generalpve_meleekills,generalpve_penetrationkills,generalpve_rappelbreach,generalpve_reinforcementdeploy,generalpve_revive,generalpve_revivedenied,generalpve_serveraggression,generalpve_serverdefender,generalpve_servershacked,generalpve_suicide,generalpve_timeplayed,generalpve_timeplayed:infinite,generalpve_totalxp";
        private const string GeneralPvp = "generalpvp_accuracy,generalpvp_barricadedeployed,generalpvp_barricadedeployed:infinite,generalpvp_blindkills,generalpvp_bulletfired,generalpvp_bulletfired:infinite,generalpvp_bullethit,generalpvp_bullethit:infinite,generalpvp_dbno,generalpvp_dbno:infinite,generalpvp_dbnoassists,generalpvp_death,generalpvp_death:infinite,generalpvp_distancetravelled,generalpvp_gadgetdestroy,generalpvp_headshot,generalpvp_headshot:infinite,generalpvp_hostagedefense,generalpvp_hostagerescue,generalpvp_kdratio,generalpvp_killassists,generalpvp_killassists:infinite,generalpvp_kills,generalpvp_kills:infinite,generalpvp_matchlost,generalpvp_matchlost:infinite,generalpvp_matchplayed,generalpvp_matchplayed:infinite,generalpvp_matchwlratio,generalpvp_matchwon,generalpvp_matchwon:infinite,generalpvp_meleekills,generalpvp_penetrationkills,generalpvp_rappelbreach,generalpvp_reinforcementdeploy,generalpvp_reinforcementdeploy:infinite,generalpvp_revive,generalpvp_revive:infinite,generalpvp_revivedenied,generalpvp_serveraggression,generalpvp_serverdefender,generalpvp_servershacked,generalpvp_suicide,generalpvp_suicide:infinite,generalpvp_timeplayed,generalpvp_timeplayed:infinite,generalpvp_totalxp";
        private const string NormalPvp = "normalpvp_matchlost,normalpvp_matchplayed,normalpvp_matchwlratio,normalpvp_matchwon,normalpvp_timeplayed";
        private const string CasualPvp = "casualpvp_death,casualpvp_death:infinite,casualpvp_kdratio,casualpvp_kills,casualpvp_kills:infinite,casualpvp_matchlost,casualpvp_matchlost:infinite,casualpvp_matchplayed,casualpvp_matchplayed:infinite,casualpvp_matchwlratio,casualpvp_matchwon,casualpvp_matchwon:infinite,casualpvp_timeplayed,casualpvp_timeplayed:infinite";
        private const string RankedPvp = "rankedpvp_death,rankedpvp_death:infinite,rankedpvp_kdratio,rankedpvp_kills,rankedpvp_kills:infinite,rankedpvp_matchlost,rankedpvp_matchlost:infinite,rankedpvp_matchplayed,rankedpvp_matchplayed:infinite,rankedpvp_matchwlratio,rankedpvp_matchwon,rankedpvp_matchwon:infinite,rankedpvp_timeplayed,rankedpvp_timeplayed:infinite";
        private const string CustomPvp = "custompvp_timeplayed";

        // Gamemode specific
        private const string ProtectHostagePve = "protecthostagepve_bestscore,protecthostagepve_hostagedefense,protecthostagepve_hostagerescue,protecthostagepve_matchlost,protecthostagepve_matchplayed,protecthostagepve_matchwlratio,protecthostagepve_matchwon,protecthostagepve_timeplayed";
        private const string PlantBombPve = "plantbombpve_bestscore,plantbombpve_matchlost,plantbombpve_matchplayed,plantbombpve_matchwlratio,plantbombpve_matchwon,plantbombpve_timeplayed";
        private const string PlantBombPvp = "plantbombpvp_bestscore,plantbombpvp_matchlost,plantbombpvp_matchplayed,plantbombpvp_matchwlratio,plantbombpvp_matchwon,plantbombpvp_timeplayed,plantbombpvp_totalxp";
        private const string RescueHostagePve = "rescuehostagepve_bestscore,rescuehostagepve_hostagedefense,rescuehostagepve_hostagerescue,rescuehostagepve_matchlost,rescuehostagepve_matchplayed,rescuehostagepve_matchwlratio,rescuehostagepve_matchwon,rescuehostagepve_timeplayed";
        private const string RescueHostagePvp = "rescuehostagepvp_bestscore,rescuehostagepvp_matchlost,rescuehostagepvp_matchplayed,rescuehostagepvp_matchwlratio,rescuehostagepvp_matchwon,rescuehostagepvp_totalxp";
        private const string SecureAreaPve = "secureareapve_bestscore,secureareapve_matchlost,secureareapve_matchplayed,secureareapve_matchwlratio,secureareapve_matchwon,secureareapve_serveraggression,secureareapve_serverdefender,secureareapve_servershacked,secureareapve_timeplayed";

        private const string SecureAreaPvp = "secureareapvp_bestscore,secureareapvp_matchlost,secureareapvp_matchplayed,secureareapvp_matchwlratio,secureareapvp_matchwon,secureareapvp_totalxp";

        // Terrorist Hunt/Training Grounds and missions
        private const string AllTerroHunt = "allterrohuntcoop_hard_bestscore,allterrohuntcoop_normal_bestscore,allterrohuntcoop_realistic_bestscore,allterrohuntsolo_hard_bestscore,allterrohuntsolo_normal_bestscore,allterrohuntsolo_realistic_bestscore";
        private const string TerroHuntClassic = "terrohuntclassicpve_bestscore,terrohuntclassicpve_matchlost,terrohuntclassicpve_matchplayed,terrohuntclassicpve_matchwlratio,terrohuntclassicpve_matchwon,terrohuntclassicpve_timeplayed";
        private const string MissionSolo = "missionsolo_hard_bestscore,missionsolo_normal_bestscore,missionsolo_realistic_bestscore";
        private const string MissionCoop = "missioncoop_hard_bestscore,missioncoop_normal_bestscore,missioncoop_realistic_bestscore";
        private const string MissionsByPlaylist = "missionsbyplaylistpve_bestscore";

        // Operator specific
        private const string OperatorPve = "operatorpve_ash_bonfirekill,operatorpve_ash_bonfirewallbreached,operatorpve_bandit_batterykill,operatorpve_black_mirror_gadget_deployed,operatorpve_blackbeard_gunshieldblockdamage,operatorpve_blitz_flashedenemy,operatorpve_blitz_flashfollowupkills,operatorpve_blitz_flashshieldassist,operatorpve_buck_kill,operatorpve_capitao_lethaldartkills,operatorpve_capitao_smokedartslaunched,operatorpve_castle_kevlarbarricadedeployed,operatorpve_caveira_aikilledinstealth,operatorpve_cazador_assist_kill,operatorpve_dbno,operatorpve_death,operatorpve_doc_hostagerevive,operatorpve_doc_selfrevive,operatorpve_doc_teammaterevive,operatorpve_echo_enemy_sonicburst_affected,operatorpve_frost_beartrap_kill,operatorpve_fuze_clusterchargekill,operatorpve_glaz_sniperkill,operatorpve_glaz_sniperpenetrationkill,operatorpve_headshot,operatorpve_hibana_detonate_projectile,operatorpve_iq_gadgetspotbyef,operatorpve_jager_gadgetdestroybycatcher,operatorpve_kapkan_boobytrapdeployed,operatorpve_kapkan_boobytrapkill,operatorpve_kdratio,operatorpve_kills,operatorpve_meleekills,operatorpve_montagne_shieldblockdamage,operatorpve_mostused,operatorpve_mute_gadgetjammed,operatorpve_mute_jammerdeployed,operatorpve_pulse_heartbeatassist,operatorpve_pulse_heartbeatspot,operatorpve_rook_armorboxdeployed,operatorpve_rook_armortakenourself,operatorpve_rook_armortakenteammate,operatorpve_roundlost,operatorpve_roundplayed,operatorpve_roundwlratio,operatorpve_roundwon,operatorpve_sledge_hammerhole,operatorpve_sledge_hammerkill,operatorpve_smoke_poisongaskill,operatorpve_tachanka_turretdeployed,operatorpve_tachanka_turretkill,operatorpve_thatcher_gadgetdestroywithemp,operatorpve_thermite_chargedeployed,operatorpve_thermite_chargekill,operatorpve_thermite_reinforcementbreached,operatorpve_timeplayed,operatorpve_totalxp,operatorpve_twitch_gadgetdestroybyshockdrone,operatorpve_twitch_shockdronekill,operatorpve_valkyrie_camdeployed";
        private const string OperatorPvp = "operatorpvp_ace_selmadetonate,operatorpvp_amaru_distancereeled,operatorpvp_ash_bonfirekill,operatorpvp_ash_bonfirewallbreached,operatorpvp_attackerdrone_diminishedrealitymode,operatorpvp_bandit_batterykill,operatorpvp_barrage_killswithturret,operatorpvp_black_mirror_gadget_deployed,operatorpvp_blackbeard_gunshieldblockdamage,operatorpvp_blitz_flashedenemy,operatorpvp_blitz_flashfollowupkills,operatorpvp_blitz_flashshieldassist,operatorpvp_buck_kill,operatorpvp_caltrop_enemy_affected,operatorpvp_capitao_lethaldartkills,operatorpvp_capitao_smokedartslaunched,operatorpvp_castle_kevlarbarricadedeployed,operatorpvp_caveira_interrogations,operatorpvp_cazador_assist_kill,operatorpvp_clash_sloweddown,operatorpvp_concussiongrenade_detonate,operatorpvp_concussionmine_detonate,operatorpvp_dazzler_gadget_detonate,operatorpvp_dbno,operatorpvp_death,operatorpvp_deceiver_revealedattackers,operatorpvp_doc_hostagerevive,operatorpvp_doc_selfrevive,operatorpvp_doc_teammaterevive,operatorpvp_echo_enemy_sonicburst_affected,operatorpvp_frost_dbno,operatorpvp_fuze_clusterchargekill,operatorpvp_glaz_sniperkill,operatorpvp_glaz_sniperpenetrationkill,operatorpvp_goyo_volcandetonate,operatorpvp_gridlock_traxdeployed,operatorpvp_headshot,operatorpvp_hibana_detonate_projectile,operatorpvp_iana_killsafterreplicator,operatorpvp_iq_gadgetspotbyef,operatorpvp_jager_gadgetdestroybycatcher,operatorpvp_kaid_electroclawelectrify,operatorpvp_kali_gadgetdestroywithexplosivelance,operatorpvp_kapkan_boobytrapdeployed,operatorpvp_kapkan_boobytrapkill,operatorpvp_kdratio,operatorpvp_kills,operatorpvp_maverick_wallbreached,operatorpvp_meleekills,operatorpvp_melusi_sloweddown,operatorpvp_montagne_shieldblockdamage,operatorpvp_mostused,operatorpvp_mozzie_droneshacked,operatorpvp_mute_gadgetjammed,operatorpvp_mute_jammerdeployed,operatorpvp_nokk_observationtooldeceived,operatorpvp_nomad_airjabdetonate,operatorpvp_oryx_killsafterdash,operatorpvp_phoneshacked,operatorpvp_pulse_heartbeatassist,operatorpvp_pulse_heartbeatspot,operatorpvp_rook_armorboxdeployed,operatorpvp_rook_armortakenourself,operatorpvp_rook_armortakenteammate,operatorpvp_roundlost,operatorpvp_roundplayed,operatorpvp_roundwlratio,operatorpvp_roundwon,operatorpvp_rush_adrenalinerush,operatorpvp_sledge_hammerhole,operatorpvp_sledge_hammerkill,operatorpvp_smoke_poisongaskill,operatorpvp_tachanka_turretdeployed,operatorpvp_tachanka_turretkill,operatorpvp_tagger_tagdevice_spot,operatorpvp_thatcher_gadgetdestroywithemp,operatorpvp_thermite_chargedeployed,operatorpvp_thermite_chargekill,operatorpvp_thermite_reinforcementbreached,operatorpvp_timeplayed,operatorpvp_totalxp,operatorpvp_twitch_gadgetdestroybyshockdrone,operatorpvp_twitch_shockdronekill,operatorpvp_valkyrie_camdeployed,operatorpvp_wamai_gadgetdestroybymagnet,operatorpvp_warden_killswithglasses,operatorpvp_zero_gadgetsdestroyed";

        // Equipment specific
        private const string GadgetPve = "gadgetpve_chosen,gadgetpve_gadgetdestroy,gadgetpve_kills,gadgetpve_mostused";
        private const string GadgetPvp = "gadgetpvp_chosen,gadgetpvp_gadgetdestroy,gadgetpvp_kills,gadgetpvp_mostused";
        private const string WeaponPve = "weaponpve_mostkills,weaponpve_mostused";
        private const string WeaponPvp = "weaponpvp_mostkills,weaponpvp_mostused";
        private const string WeaponTypePve = "weapontypepve_accuracy,weapontypepve_bulletfired,weapontypepve_bullethit,weapontypepve_chosen,weapontypepve_dbno,weapontypepve_dbnoassists,weapontypepve_death,weapontypepve_deaths,weapontypepve_efficiency,weapontypepve_headshot,weapontypepve_headshotratio,weapontypepve_kdratio,weapontypepve_killassists,weapontypepve_kills,weapontypepve_mostkills,weapontypepve_power";
        private const string WeaponTypePvp = "weapontypepvp_accuracy,weapontypepvp_bulletfired,weapontypepvp_bullethit,weapontypepvp_chosen,weapontypepvp_dbno,weapontypepvp_dbnoassists,weapontypepvp_death,weapontypepvp_deaths,weapontypepvp_efficiency,weapontypepvp_headshot,weapontypepvp_headshotratio,weapontypepvp_kdratio,weapontypepvp_killassists,weapontypepvp_kills,weapontypepvp_mostkills,weapontypepvp_power";

        internal static readonly Guid Rainbow6S = Guid.Parse("39baebad-39e5-4552-8c25-2c9b919064e2");
        internal static readonly Guid Uplay = Guid.Parse("5172a557-50b5-4665-b7db-e3f2e8c5041d");
        internal static readonly Guid PSN = Guid.Parse("05bfb3f7-6c21-4c42-be1f-97a33fb5cf66");
        internal static readonly Guid XBL = Guid.Parse("98a601e5-ca91-4440-b1c5-753f601a2c90");

        /// <summary>
        /// Build a string of player-based variables.
        /// </summary>
        /// <param name="statistics">
        /// Which statistics are to be used to build the variables line.
        /// </param>
        /// <returns>
        /// A comma-separated string full of variables interpretted from requested statistics.
        /// </returns>
        internal static string StatisticsBuilder(params StatisticsType[] statistics)
        {
            // deduplicate input
            statistics = statistics.Distinct().ToArray();

            // keep distinct variables for returning
            var uniques = new HashSet<string>();
            foreach (var statistic in statistics)
            {
                var variables = GetVariables(statistic);
                foreach (var variable in variables)
                {
                    uniques.Add(variable);
                }
            }

            return string.Join(',', uniques);
        }

        internal static string[] GetVariables(StatisticsType statisticsType)
        {
            string line = statisticsType switch
            {
                StatisticsType.Equipments => EquipmentsStatisticsVariable,
                StatisticsType.Gamemodes => GamemodesStatisticsVariables,
                StatisticsType.Operators => OperatorsStatisticsVariables,
                StatisticsType.Queues => QueuesStatisticsVariables,
                StatisticsType.TerroristHuntMissions => TerroristHuntMissionsStatisticsVariables,
                _ => string.Empty,
            };
            return line.Split(',');
        }

        internal static string PlatformToString(Platform Platform)
        {
            return Platform switch
            {
                Platform.PSN => "psn",
                Platform.PC => "uplay",
                Platform.XBL => "xbl",
                _ => throw new Exception("Platform does not exist.")
            };
        }

        internal static string RegionToString(Region Region)
        {
            return Region switch
            {
                Region.APAC => "apac",
                Region.EMEA => "emea",
                Region.NCSA => "ncsa",
                _ => throw new Exception("Region does not exist."),
            };
        }

        internal static Guid PlatformToGuid(Platform Platform)
        {
            return Platform switch
            {
                Platform.PSN => PSN,
                Platform.PC => Uplay,
                Platform.XBL => XBL,
                _ => throw new Exception("Platform does not exist."),
            };
        }

        internal static string GamemodeToString(Gamemode gamemode)
        {
            return gamemode switch
            {
                Gamemode.All => "all",
                Gamemode.Ranked => "ranked",
                Gamemode.Unranked => "unranked",
                Gamemode.Casual => "casual",
                _ => throw new Exception("Gamemode does not exist")
            };
        }

        internal static string PlatformToName(Platform platform)
        {
            return platform switch
            {
                Platform.PC => "PC",
                Platform.PSN => "PS4",
                Platform.XBL => "XONE",
                _ => throw new Exception("New platform does not exist."),
            };
        }

        internal static string PlatformToSandbox(Platform platform)
        {
            return platform switch
            {
                Platform.PSN => "OSBOR_PS4_LNCH_A",
                Platform.PC => "OSBOR_PC_LNCH_A",
                Platform.XBL => "OSBOR_XBOXONE_LNCH_A",
                _ => throw new Exception("Platform does not exist."),
            };
        }

        internal static string TeamRoleToString(TeamRole teamrole)
        {
            return teamrole switch
            {
                TeamRole.All => "all",
                TeamRole.Attacker => "attacker",
                TeamRole.Defender => "defender",
                _ => throw new Exception("Team role does not exist."),
            };
        }
    }
}
