using R6Sharp.Response;
using R6Sharp.Response.DataResponse;
using R6Sharp.Response.Statistic;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace R6Sharp.Endpoint
{
    public class R6SStatsEndpoint
    {
        private readonly SessionEndpoint _sessionHandler;

        public R6SStatsEndpoint(SessionEndpoint sessionHandler)
        {
            _sessionHandler = sessionHandler;
        }

        public async Task<CurrentDataResponse<PlayerStatistics[]>> GetSummaryAsync(Guid uuid, Gamemode gamemodes, Platform platforms, DateTime start, DateTime end)
        {
            // ?gameMode=all,ranked,unranked,casual&platform=PC&startDate=20200718&endDate=20201115
            var queries = BuildQuery(gamemodes, start, end, platforms, null, null);
            return await GetData<CurrentDataResponse<PlayerStatistics[]>>(string.Format(Endpoints.R6SStats.Summary, uuid), queries).ConfigureAwait(false);
        }

        public async Task<CurrentDataResponse<PlayerStatistics[]>> GetOperatorAsync(Guid uuid, Gamemode gamemodes, Platform platforms, TeamRole teamroles, DateTime start, DateTime end)
        {
            // teamRole=all?
            // ?gameMode=all,ranked,unranked,casual&platform=PC&teamRole=attacker,defender&startDate=20200718&endDate=20201115
            var queries = BuildQuery(gamemodes, start, end, platforms, teamroles, null);
            return await GetData<CurrentDataResponse<PlayerStatistics[]>>(string.Format(Endpoints.R6SStats.Operator, uuid), queries).ConfigureAwait(false);
        }

        public async Task<CurrentDataResponse<PlayerStatistics[]>> GetMapAsync(Guid uuid, Gamemode gamemodes, Platform platforms, TeamRole teamroles, DateTime start, DateTime end)
        {
            // // ?gameMode=all,ranked,unranked,casual&platform=PC&teamRole=all,attacker,defender&startDate=20200718&endDate=20201115
            var queries = BuildQuery(gamemodes, start, end, platforms, teamroles, null);
            return await GetData<CurrentDataResponse<PlayerStatistics[]>>(string.Format(Endpoints.R6SStats.Map, uuid), queries).ConfigureAwait(false);
        }

        public async Task<CurrentDataResponse<WeaponStatistics>> GetWeaponAsync(Guid uuid, Gamemode gamemodes, Platform platforms, TeamRole teamroles, DateTime start, DateTime end)
        {
            // ?gameMode=all,ranked,unranked,casual&platform=PC&teamRole=all&startDate=20200718&endDate=20201115
            var queries = BuildQuery(gamemodes, start, end, platforms, teamroles, null);
            return await GetData<CurrentDataResponse<WeaponStatistics>>(string.Format(Endpoints.R6SStats.Weapon, uuid), queries).ConfigureAwait(false);
        }

        public async Task<CurrentDataResponse<TrendStatistics[]>> GetTrendAsync(Guid uuid, Gamemode gamemodes, DateTime start, DateTime end, TeamRole teamroles, TrendType trendType)
        {
            // ?gameMode=all,ranked,unranked,casual&startDate=20200718&endDate=20201115&teamRole=all,attacker,defender&trendType=weeks
            var queries = BuildQuery(gamemodes, start, end, null, teamroles, trendType);
            return await GetData<CurrentDataResponse<TrendStatistics[]>>(string.Format(Endpoints.R6SStats.Trend, uuid), queries).ConfigureAwait(false);
        }

        public async Task<SeasonalDataResponse<SeasonalPlayerStatistics[]>> GetSeasonalAsync(Guid uuid, Gamemode gamemodes, Platform platforms)
        {
            // ?gameMode=all,ranked,unranked,casual&platform=PC
            var queries = BuildQuery(gamemodes, null, null, platforms, null, null);
            return await GetData<SeasonalDataResponse<SeasonalPlayerStatistics[]>>(string.Format(Endpoints.R6SStats.Seasonal, uuid), queries).ConfigureAwait(false);
        }

        public async Task<NarrativeDataResponse> GetNarrativeAsync(Guid uuid, DateTime start, DateTime end)
        {
            // ?startDate=20200718&endDate=20201115
            var queries = BuildQuery(null, start, end, null, null, null);
            return await GetData<NarrativeDataResponse>(string.Format(Endpoints.R6SStats.Narrative, uuid), queries).ConfigureAwait(false);
        }

        private KeyValuePair<string, string>[] BuildQuery(Gamemode? gamemodes, DateTime? start, DateTime? end,
                                                          Platform? platforms, TeamRole? teamroles, TrendType? trend)
        {
            var queries = new List<KeyValuePair<string, string>>();

            if (gamemodes.HasValue)
            {
                var flags = ApiHelper.DeriveGamemodeFlags(gamemodes.Value);
                var query = new KeyValuePair<string, string>("gameMode", flags);
                queries.Add(query);
            }

            if (start.HasValue)
            {
                var value = start.Value.ToString("yyyyMMdd");
                var query = new KeyValuePair<string, string>("startDate", value);
                queries.Add(query);
            }

            if (end.HasValue)
            {
                var value = end.Value.ToString("yyyyMMdd");
                var query = new KeyValuePair<string, string>("endDate", value);
                queries.Add(query);
            }

            if (platforms.HasValue)
            {
                var flags = ApiHelper.DerivePlatformFlags(platforms.Value);
                var query = new KeyValuePair<string, string>("platform", flags);
                queries.Add(query);
            }

            if (teamroles.HasValue)
            {
                var flags = ApiHelper.DeriveTeamRoleFlags(teamroles.Value);
                var query = new KeyValuePair<string, string>("teamRole", flags);
                queries.Add(query);
            }

            if (trend.HasValue)
            {
                var query = new KeyValuePair<string, string>("trendType", trend.Value.ToString().ToLower());
                queries.Add(query);
            }

            return queries.ToArray();
        }

        private async Task<T> GetData<T>(string uri, KeyValuePair<string, string>[] queries)
        {
            Session session = await _sessionHandler.GetCurrentSessionAsync();
            var endpoint = new Uri(uri);
            var restRequest = new RestRequest(endpoint, Method.Get);

            foreach (var query in queries)
            {
                restRequest = restRequest.AddQueryParameter(query.Key, query.Value);
            }

            return await ApiHelper
                .BuildRestClient(session)
                .GetAsync<T>(restRequest);
        }
    }
}
