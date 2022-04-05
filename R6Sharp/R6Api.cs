using R6Sharp.Endpoint;
using R6Sharp.Response;
using R6Sharp.Response.DataResponse;
using R6Sharp.Response.Statistic;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace R6Sharp
{
    /// <summary>
    /// Region the player is based in.
    /// </summary>
    public enum Region
    {
        All,    // Unified regions
        APAC,   // Asia Pacific :(
        EMEA,   // Europe, Middle East and Africa
        NCSA    // North, Central and South America
    }

    /// <summary>
    /// Platform the player is based on.
    /// </summary>
    [Flags]
    public enum Platform
    {
        PC = 1,     // PC/Uplay
        PSN = 2,    // Playstation Network
        XBL = 4     // Xbox Live
    }

    /// <summary>
    /// Gamemode data to retrieve for player.
    /// </summary>
    [Flags]
    public enum Gamemode
    {
        Casual = 1,
        Unranked = 2,
        Ranked = 4,
        All = 8
    }

    /// <summary>
    /// The role the player has played in the matches.
    /// </summary>
    [Flags]
    public enum TeamRole
    {
        All = 1,
        Attacker = 2,
        Defender = 4
    }

    /// <summary>
    /// The type of trend to retrieve.
    /// </summary>
    public enum TrendType
    {
        Weeks
    }

    public class R6Api
    {
        private SessionEndpoint _session { get; }

        public ProfileEndpoint Profile { get; }
        public PlayerProgressionEndpoint PlayerProgression { get; }
        public PlayerEndpoint Player { get; }
        public PlayersSkillRecordsEndpoint PlayersSkillRecordsEndpoint { get; }
        public PlayerStatisticsEndpoint PlayerStatisticsEndpoint { get; }

        #region Constructors
        /// <summary>
        /// Create a R6S API instance with remember me defaulting to true
        /// </summary>
        /// <param name="email">
        /// Email address of a Ubisoft account.
        /// </param>
        /// <param name="password">
        /// Password of a Ubisoft account.
        /// </param>
        public R6Api(string email, string password) : this(email, password, true)
        {

        }

        /// <summary>
        /// Create a R6S API instance with optional remember me option.
        /// </summary>
        /// <param name="email">
        /// Email address of a Ubisoft account.
        /// </param>
        /// <param name="password">
        /// Password of a Ubisoft account.
        /// </param>
        /// <param name="rememberMe">
        /// Option for Ubisoft to remember this instance's session (can be changed over time by <see cref="RememberMe"/>.
        /// </param>
        public R6Api(string email, string password, bool rememberMe)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentNullException(this.GetType().FullName, "Email address cannot be null or empty.");
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException(this.GetType().FullName, "Password cannot be null or empty.");
            }

            _session = new SessionEndpoint(email, password, rememberMe);
            Profile = new ProfileEndpoint(_session);
            PlayerProgression = new PlayerProgressionEndpoint(_session);
            Player = new PlayerEndpoint(_session);
            PlayersSkillRecordsEndpoint = new PlayersSkillRecordsEndpoint(_session);
            PlayerStatisticsEndpoint = new PlayerStatisticsEndpoint(_session);
        }
        #endregion

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
            Session session = await _session.GetCurrentSessionAsync();
            var endpoint = new Uri(uri);
            var restRequest = new RestRequest(endpoint, Method.Get);

            foreach (var query in queries)
            {
                restRequest = restRequest.AddQueryParameter(query.Key, query.Value);
            }

            return await EndpointHelper
                .BuildRestClient(session)
                .GetAsync<T>(restRequest);
        }
    }
}