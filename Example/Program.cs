using R6DataAccess.Interfaces;
using R6DataAccess.Models;
using R6Sharp;
using R6Sharp.Response;
using R6Sharp.Response.Static;
using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Example
{
    public static class Program
    {

        public static void  Main()
        {
          

            var api = new R6Api(new Auth ("email", "password", false));


            var guids = new[]
            {
                Guid.Parse("00000000-0000-0000-0000-000000000000"),
                Guid.Parse("11111111-1111-1111-1111-111111111111"),
                Guid.Parse("22222222-2222-2222-2222-222222222222"),
                Guid.Parse("33333333-3333-3333-3333-333333333333"),
                Guid.Parse("44444444-4444-4444-4444-444444444444")
            };

            #region Player Data
            var username = Guid.Parse("0a32319d-f7de-4ec1-a845-25ee53f978a7");
            IPlatform platform = Platform.UPLAY;
            var region = Region.EMEA;

            IProfile profile = api.Profile.GetProfileAsync(username, platform).Result;

            // var profile = api.GetProfileAsync(guids, platform).Result;
            Console.WriteLine($"Profile ID:         {profile.UserId}");

            IPlayerProgression progression = api.PlayerProgression.GetPlayerProgressionAsync(profile.ProfileId, platform).Result;
            Console.WriteLine($"Level:              {progression.Level}");


            IBoardInfo ranked = api.Player.GetRankedAsync(profile.ProfileId, platform, region).Result;
            Console.WriteLine($"Ranked Rank:        {ranked.Rank}");

            IBoardInfo casual = api.Player.GetCasualAsync(profile.ProfileId, platform, region).Result;
            Console.WriteLine($"Casual Rank:        {casual.Rank}");

            IEquipmentStatistic equipments = api.Statistic.GetEquipmentStatistics(profile.ProfileId, platform).Result;
            IGamemodeStatistic gamemodes = api.Statistic.GetGamemodeStatistics(profile.ProfileId, platform).Result;
            IOperatorStatistic operators = api.Statistic.GetOperatorStatistics(profile.ProfileId, platform).Result;
            IQueueStatistic queues = api.Statistic.GetQueueStatistics(profile.ProfileId, platform).Result;
            ITerroristHuntMissionStatistic terroristhuntmissions = api.Statistic.GetTerroristHuntMissionsStatistics(profile.ProfileId, platform).Result;
            #endregion

            #region Static Data
            SeasonsInfo seasonsInfo = api.Static.GetSeasonsInfoAsync().Result;
            Console.WriteLine($"Latest Season:      {seasonsInfo.LatestSeason}");

            Season season = api.Static.GetSeasonAsync(seasonsInfo.LatestSeason).Result;
            // Season season = Season.GetSeasonAsync().Result;
            Console.WriteLine($"Current Season:     {season.Id}");

            var locales = api.Static.GetLocaleAsync(LanguageEndPoint.BritishEnglish).Result;
            var seasonDetails = api.Static.GetSeasonDetailsAsync().Result;

            var seasonId = 18;
            // Find season details for season 18
            var seasonDetail = seasonDetails.Find(x => x.Id == seasonId);
            // Get the highest rank for that season (should be champion)
            var highestSeasonRank = seasonDetail.Ranks[^1];
            var rankOasis = highestSeasonRank.Name.OasisId;
            // Get rank name from locale dictionary to localise variable names (e.g. champion -> şampiyon)
            Console.WriteLine($"Highest Rank Name:  {locales[rankOasis.ToString()]}");
            Console.WriteLine($"Highest Rank URL:   {highestSeasonRank.Images.Hd}");
            #endregion
        }

    }
}