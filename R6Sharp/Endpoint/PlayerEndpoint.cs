using R6Sharp.Response;
using RestSharp;
using System;
using System.Collections.Generic;
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
        public async Task<Dictionary<string, BoardInfo>> GetRankedAsync(Guid[] uuids, Platform platform, Region region, int season)
        {
            return await Get(uuids, platform, region, season, true).ConfigureAwait(false);
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
        public async Task<Dictionary<string, BoardInfo>> GetCasualAsync(Guid[] uuids, Platform platform, Region region, int season)
        {
            return await Get(uuids, platform, region, season, false).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<BoardInfo> GetRankedAsync(Guid uuid, Platform platform)
        {
            var result = await GetRankedAsync(uuid, platform, Region.NCSA, -1).ConfigureAwait(false);
            return result;
        }

        /// <inheritdoc/>
        public async Task<Dictionary<string, BoardInfo>> GetRankedAsync(Guid[] uuids, Platform platform)
        {
            return await GetRankedAsync(uuids, platform, Region.NCSA, -1).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<BoardInfo> GetRankedAsync(Guid uuid, Platform platform, Region region, int season)
        {
            var result = await GetRankedAsync(new[] { uuid }, platform, region, season).ConfigureAwait(false);
            return result[uuid.ToString()];
        }

        /// <inheritdoc/>
        public async Task<BoardInfo> GetCasualAsync(Guid uuid, Platform platform)
        {
            var result = await GetCasualAsync(uuid, platform, Region.NCSA, -1).ConfigureAwait(false);
            return result;
        }

        /// <inheritdoc/>
        public async Task<Dictionary<string, BoardInfo>> GetCasualAsync(Guid[] uuids, Platform platform)
        {
            return await GetCasualAsync(uuids, platform, Region.NCSA, -1).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<BoardInfo> GetCasualAsync(Guid uuid, Platform platform, Region region, int season)
        {
            var result = await GetCasualAsync(new[] { uuid }, platform, region, season).ConfigureAwait(false);
            return result[uuid.ToString()];
        }

        #region Obsoletes
        // Since no season is specified, it is assumed the latest season is to be retrieved,
        // which doesn't matter what region is selected since they all have been merged from
        // season 18 and onwards.
        [Obsolete]
        /// <inheritdoc/>
        public async Task<BoardInfo> GetRankedAsync(Guid uuid, Platform platform, Region region)
        {
            return await GetRankedAsync(uuid, platform, region, -1).ConfigureAwait(false);
        }

        [Obsolete]
        /// <inheritdoc/>
        public async Task<Dictionary<string, BoardInfo>> GetRankedAsync(Guid[] uuids, Platform platform, Region region)
        {
            return await GetRankedAsync(uuids, platform, region, -1).ConfigureAwait(false);
        }

        [Obsolete]
        /// <inheritdoc/>
        public async Task<BoardInfo> GetCasualAsync(Guid uuid, Platform platform, Region region)
        {
            return await GetCasualAsync(uuid, platform, region, -1).ConfigureAwait(false);
        }

        [Obsolete]
        /// <inheritdoc/>
        public async Task<Dictionary<string, BoardInfo>> GetCasualAsync(Guid[] uuids, Platform platform, Region region)
        {
            return await GetCasualAsync(uuids, platform, region, -1).ConfigureAwait(false);
        }
        #endregion

        private async Task<Dictionary<string, BoardInfo>> Get(Guid[] uuids, Platform platform, Region region, int season, bool ranked)
        {
            Session session = await _sessionHandler.GetCurrentSessionAsync();

            string constructedUrl = string.Format(Endpoints.UbiServices.Players, Constant.PlatformToGuid(platform), Constant.PlatformToSandbox(platform));
            var endpoint = new Uri(constructedUrl);
            var restRequest = new RestRequest(endpoint, Method.Get)
                .AddQueryParameter("profile_ids", string.Join(',', uuids))
                .AddQueryParameter("board_id", ranked ? "pvp_ranked" : "pvp_casual")
                .AddQueryParameter("region_id", Constant.RegionToString(region))
                .AddQueryParameter("season_id", season.ToString());

            BoardInfoFetch boardInfoFetch = await ApiHelper
                .BuildRestClient(session)
                .GetAsync<BoardInfoFetch>(restRequest);
            return boardInfoFetch.Players;
        }
    }
}
