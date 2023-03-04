using R6Sharp.Response;
using System;
using System.Collections.Generic;
using System.Threading;
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

        public async Task<PlayersSkillRecords> GetPlayersSkillRecordsAsync(Guid[] uuids,
            Platform platform,
            Region region,
            IEnumerable<int> seasons,
            CancellationToken cancellationToken = default)
        {
            var queries = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("profile_ids", string.Join(',', uuids)),
                new KeyValuePair<string, string>("board_ids", "pvp_ranked"),
                new KeyValuePair<string, string>("region_ids", Constant.RegionToString(region)),
                new KeyValuePair<string, string>("season_ids", string.Join(',', seasons))
            };

            Session session = await _sessionHandler.GetCurrentSessionAsync().ConfigureAwait(false);
            return await ApiHelper.GetDataAsync<PlayersSkillRecords>(Endpoints.UbiServices.PlayerSkillRecords,
                platform: platform,
                queries,
                session,
                cancellationToken).ConfigureAwait(false);
        }

        public async Task<PlayersSkillRecords> GetPlayerSkillRecordsAsync(Guid uuid,
            Platform platform,
            Region region,
            IEnumerable<int> seasons,
            CancellationToken cancellationToken = default)
        {
            return await GetPlayersSkillRecordsAsync(new[] { uuid }, platform, region, seasons, cancellationToken).ConfigureAwait(false);
        }
    }
}