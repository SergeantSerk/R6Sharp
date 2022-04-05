using R6Sharp.Response;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace R6Sharp.Endpoint
{
    public class PlayerProgressionEndpoint
    {
        private readonly SessionEndpoint _sessionHandler;

        public PlayerProgressionEndpoint(SessionEndpoint sessionHandler)
        {
            _sessionHandler = sessionHandler;
        }

        /// <inheritdoc/>
        public async Task<PlayerProgression> GetPlayerProgressionAsync(Guid uuid, Platform platform)
        {
            var profiles = await GetPlayerProgressionAsync(new[] { uuid }, platform).ConfigureAwait(false);
            return profiles.Count > 0 ? profiles[0] : null;
        }

        /// <summary>
        /// Get a list of basic profiles (like <see cref="PlayerProgression.XP"/> and <see cref="PlayerProgression.Level"/>).
        /// </summary>
        /// <param name="uuids">
        /// The UUIDs matching the player profiles (should be searched with <see cref="GetProfileAsync(string, Platform)"/> beforehand).
        /// </param>
        /// <param name="platform">
        /// The platform <paramref name="uuids"/> belong to.
        /// </param>
        /// <returns>
        /// A list of basic profiles matching the request terms.
        /// </returns>
        public async Task<List<PlayerProgression>> GetPlayerProgressionAsync(Guid[] uuids, Platform platform)
        {
            Session session = await _sessionHandler.GetCurrentSessionAsync();

            string constructedUrl = string.Format(Endpoints.UbiServices.Progressions, Constant.PlatformToGuid(platform), Constant.PlatformToSandbox(platform));
            var endpoint = new Uri(constructedUrl);
            var restRequest = new RestRequest(endpoint, Method.Get)
                .AddQueryParameter("profile_ids", string.Join(',', uuids));

            PlayerProgressionFetch playerProgressionFetch = await ApiHelper
                .BuildRestClient(session)
                .GetAsync<PlayerProgressionFetch>(restRequest);

            foreach (var result in playerProgressionFetch.PlayerProgressions)
            {
                // Attach link to player profile icon url
                var formatted = string.Format(Endpoints.Static.Avatar, result.ProfileId, Constant.Rainbow6S);
                result.ProfileIcon = new Uri(formatted);
            }
            return playerProgressionFetch.PlayerProgressions;
        }
    }
}
