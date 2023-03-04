using R6Sharp.Response;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace R6Sharp.Endpoint
{
    public class PlayerEndpoint
    {
        private readonly SessionEndpoint _sessionHandler;

        public PlayerEndpoint(SessionEndpoint sessionHandler)
        {
            _sessionHandler = sessionHandler;
        }

        /// <summary>
        /// Get a list of ranked profiles (like <see cref="BoardInfo.SkillMean"/> or <see cref="BoardInfo.MMR"/>).
        /// </summary>
        /// <param name="uuids">
        /// The UUIDs matching the player profiles./> beforehand).
        /// </param>
        /// <param name="platform">
        /// The platform <paramref name="uuids"/> belong to.
        /// </param>
        /// <param name="region">
        /// The region <paramref name="uuids"/> belong to.
        /// </param>
        /// <param name="season">
        /// The seasonal stats to search for.
        /// </param>
        /// <returns>
        /// A list of players matching the request terms in a dictionary (to be referenced with the player UUID as key).
        /// </returns>
        public async Task<Dictionary<string, BoardInfo>> GetRankedAsync(Guid[] uuids,
            Platform platform,
            Region region,
            int season,
            CancellationToken cancellationToken = default)
        {
            return await Get(uuids, platform, region, season, true, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a list of casual profiles (like <see cref="BoardInfo.SkillMean"/> or <see cref="BoardInfo.MMR"/>).
        /// </summary>
        /// <param name="uuids">
        /// The UUIDs matching the player profiles./> beforehand).
        /// </param>
        /// <param name="platform">
        /// The platform <paramref name="uuids"/> belong to.
        /// </param>
        /// <param name="region">
        /// The region <paramref name="uuids"/> belong to.
        /// </param>
        /// <param name="season">
        /// The seasonal stats to search for.
        /// </param>
        /// <returns>
        /// A list of players matching the request terms in a dictionary (to be referenced with the player UUID as key).
        /// </returns>
        public async Task<Dictionary<string, BoardInfo>> GetCasualAsync(Guid[] uuids,
            Platform platform,
            Region region,
            int season,
            CancellationToken cancellationToken = default)
        {
            return await Get(uuids, platform, region, season, false, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<BoardInfo> GetRankedAsync(Guid uuid,
            Platform platform,
            CancellationToken cancellationToken = default)
        {
            BoardInfo result = await GetRankedAsync(uuid, platform, Region.NCSA, -1, cancellationToken).ConfigureAwait(false);
            return result;
        }

        /// <inheritdoc/>
        public async Task<Dictionary<string, BoardInfo>> GetRankedAsync(Guid[] uuids,
            Platform platform,
            CancellationToken cancellationToken = default)
        {
            return await GetRankedAsync(uuids, platform, Region.NCSA, -1, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<BoardInfo> GetRankedAsync(Guid uuid,
            Platform platform,
            Region region,
            int season,
            CancellationToken cancellationToken = default)
        {
            Dictionary<string, BoardInfo> result = await GetRankedAsync(new[] { uuid },
                platform,
                region,
                season,
                cancellationToken).ConfigureAwait(false);
            return result[uuid.ToString()];
        }

        /// <inheritdoc/>
        public async Task<BoardInfo> GetCasualAsync(Guid uuid,
            Platform platform,
            CancellationToken cancellationToken = default)
        {
            BoardInfo result = await GetCasualAsync(uuid, platform, Region.NCSA, -1, cancellationToken).ConfigureAwait(false);
            return result;
        }

        /// <inheritdoc/>
        public async Task<Dictionary<string, BoardInfo>> GetCasualAsync(Guid[] uuids,
            Platform platform,
            CancellationToken cancellationToken = default)
        {
            return await GetCasualAsync(uuids, platform, Region.NCSA, -1, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<BoardInfo> GetCasualAsync(Guid uuid,
            Platform platform,
            Region region,
            int season,
            CancellationToken cancellationToken = default)
        {
            Dictionary<string, BoardInfo> result = await GetCasualAsync(new[] { uuid },
                platform,
                region,
                season,
                cancellationToken).ConfigureAwait(false);
            return result[uuid.ToString()];
        }

        private async Task<Dictionary<string, BoardInfo>> Get(Guid[] uuids,
            Platform platform,
            Region region,
            int season,
            bool ranked,
            CancellationToken cancellationToken = default)
        {
            var queries = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("profile_ids", string.Join(',', uuids)),
                new KeyValuePair<string, string>("board_id", ranked ? "pvp_ranked" : "pvp_casual"),
                new KeyValuePair<string, string>("region_id", Constant.RegionToString(region)),
                new KeyValuePair<string, string>("season_id", season.ToString())
            };

            Session session = await _sessionHandler.GetCurrentSessionAsync().ConfigureAwait(false);
            BoardInfoFetch results = await ApiHelper.GetDataAsync<BoardInfoFetch>(Endpoints.UbiServices.Players,
                platform,
                queries,
                session,
                cancellationToken).ConfigureAwait(false);
            return results.Players;
        }
    }
}
