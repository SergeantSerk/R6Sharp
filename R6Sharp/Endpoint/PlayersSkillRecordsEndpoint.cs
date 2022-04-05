using R6Sharp.Response;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace R6Sharp.Endpoint
{
    public class PlayersSkillRecordsEndpoint
    {
        private readonly SessionEndpoint _sessionHandler;

        public PlayersSkillRecordsEndpoint(SessionEndpoint sessionHandler)
        {
            _sessionHandler = sessionHandler;
        }

        public async Task<PlayersSkillRecords> GetPlayersSkillRecordsAsync(Guid[] uuids, Platform platform, Region region, params int[] seasons)
        {
            Session session = await _sessionHandler.GetCurrentSessionAsync();

            string constructedUrl = string.Format(Endpoints.UbiServices.PlayerSkillRecords, Constant.PlatformToGuid(platform), Constant.PlatformToSandbox(platform));
            var endpoint = new Uri(constructedUrl);
            var restRequest = new RestRequest(endpoint, Method.Get)
                .AddQueryParameter("profile_ids", string.Join(',', uuids))
                .AddQueryParameter("board_ids", "pvp_ranked")   // TO-DO: pvp_ranked only? Investigate
                .AddQueryParameter("region_ids", Constant.RegionToString(region))
                .AddQueryParameter("season_ids", string.Join(',', seasons));

            return await EndpointHelper
                .BuildRestClient(session)
                .GetAsync<PlayersSkillRecords>(restRequest);
        }

        public async Task<PlayersSkillRecords> GetPlayerSkillRecordsAsync(Guid uuid, Platform platform, Region region, params int[] seasons)
        {
            return await GetPlayersSkillRecordsAsync(new[] { uuid }, platform, region, seasons).ConfigureAwait(false);
        }
    }
}