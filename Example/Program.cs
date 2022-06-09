using R6Sharp;
using R6Sharp.Response;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Example
{
    public static class Program
    {
        internal class Credential
        {
            [JsonPropertyName("email")]
            public string Email { get; set; }

            [JsonPropertyName("password")]
            public string Password { get; set; }
        }

        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // credentials.json = {"email": "email@email.com", "password": "somepassword"}
            var json = File.ReadAllText(@"credentials.json");
            var credentials = JsonSerializer.Deserialize<Credential>(json);
            var api = new R6Api(credentials.Email, credentials.Password);

            var guids = new[]
            {
                Guid.Parse("00000000-0000-0000-0000-000000000000"),
                Guid.Parse("11111111-1111-1111-1111-111111111111"),
                Guid.Parse("22222222-2222-2222-2222-222222222222"),
                Guid.Parse("33333333-3333-3333-3333-333333333333"),
                Guid.Parse("44444444-4444-4444-4444-444444444444")
            };

            var username = "Sudocrem.";
            var platform = Platform.PC;

            Profile profile = api.Profile.GetProfileAsync(username, platform).Result;
            var uuid = profile.ProfileId;

            PlayerProgression playerProgression = api.PlayerProgression.GetPlayerProgressionAsync(uuid, platform).Result;
            var playerLevel = playerProgression.Level;

            // As of season 18, regional board (ranked and casual) statistics have merged and cross regions now
            BoardInfo playerRanked = api.Player.GetRankedAsync(uuid, platform).Result;
            var playerMMR = playerRanked.MMR;
            // get casual queue stats
            // var playerCasual = api.Player.GetCasualAsync(uuid, platform);                            
            // get season 17 ranked stats for EMEA
            // var playerRankedSeason17 = api.Player.GetRankedAsync(uuid, platform, Region.EMEA, 17);

            var seasons = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            PlayersSkillRecords playerSkillRecords = api.PlayersSkillRecordsEndpoint
                                                        .GetPlayerSkillRecordsAsync(uuid, platform, Region.EMEA, seasons)
                                                        .Result;
            var recordMMR = playerSkillRecords.SeasonsPlayerSkillRecords.Last()
                                              .RegionsPlayerSkillRecords.First()
                                              .BoardsPlayerSkillRecords.First()
                                              .PlayerSkillRecords.First()
                                              .MMR;

            var queues = api.PlayerStatisticsEndpoint.GetQueueStatisticsAsync(uuid, platform).Result;
            // Time played in ranked since recorded history (in seconds)
            var rankedPlaytimeInfinite = queues["rankedpvp_timeplayed:infinite"];

            var gamemodes = Gamemode.All | Gamemode.Ranked | Gamemode.Unranked | Gamemode.Casual;
            var from = new DateTime(2020, 06, 16);
            // Narrative is weekly, therefore it is better thing to use UtcNow
            // over specific dates unless you need a specific period
            // var to = new DateTime(2020, 06, 16);
            var to = DateTime.UtcNow;

            var summary = api.R6SStatsEndpoint.GetSummaryAsync(uuid, gamemodes, platform, from, to).Result;
            var summaryKills = summary.Platforms["PC"]
                                      .Gamemodes["all"]
                                      .TeamRoles["all"].Last()
                                      .Kills;

            var operators = api.R6SStatsEndpoint.GetOperatorAsync(uuid, gamemodes, platform, TeamRole.Attacker | TeamRole.Defender, from, to).Result;
            var zofiaRankedWins = operators.Platforms["PC"]
                                              .Gamemodes["ranked"]
                                              .TeamRoles["attacker"]
                                              .Where(x => x.StatsDetail == "Zofia").First()
                                              .RoundsWon;

            var maps = api.R6SStatsEndpoint.GetMapAsync(uuid, gamemodes, platform, TeamRole.All | TeamRole.Attacker | TeamRole.Defender, from, to).Result;
            var kanalDefenderTeamKills = maps.Platforms["PC"]
                                             .Gamemodes["casual"]
                                             .TeamRoles["defender"]
                                             .Where(m => m.StatsDetail == "KANAL").First()
                                             .TeamKills;

            var weapons = api.R6SStatsEndpoint.GetWeaponAsync(uuid, gamemodes, platform, TeamRole.All, from, to).Result;
            var allSpear308HeadshotAccuracy = weapons.Platforms["PC"]
                                                     .Gamemodes["all"]
                                                     .TeamRoles["all"]
                                                     .WeaponSlots
                                                     .PrimaryWeapons
                                                     .WeaponTypes
                                                     .Where(t => t.WeaponTypeType == "Assault Rifles").First()
                                                     .Weapons
                                                     .Where(w => w.WeaponName == "SPEAR .308").First()
                                                     .HeadshotAccuracy;

            var trends = api.R6SStatsEndpoint.GetTrendAsync(uuid, gamemodes, from, to, TeamRole.All | TeamRole.Attacker | TeamRole.Defender, TrendType.Weeks).Result;
            var rankedAttackKDRTrend = trends.Platforms["PC"]
                                             .Gamemodes["ranked"]
                                             .TeamRoles["attacker"].Last()
                                             .KillDeathRatio;

            var seasonal = api.R6SStatsEndpoint.GetSeasonalAsync(uuid, gamemodes, platform).Result;
            var rankedY4S4MinutesPlayed = seasonal.Platforms["PC"]
                                                  .Gamemodes["ranked"]
                                                  .TeamRoles["all"]
                                                  .Where(s => s.SeasonYear == "Y4")
                                                  .Where(s => s.SeasonNumber == "S4").First()
                                                  .MinutesPlayed;

            var narrative = api.R6SStatsEndpoint.GetNarrativeAsync(uuid, from, to).Result;
            var bestMatchScoreAnyWeek = narrative.Profiles[uuid.ToString()]
                                                 .Years.First()
                                                 .Value.Weeks.First()
                                                 .Value.BestMatchFullStatistics
                                                 .Score;
        }
    }
}