using R6Sharp.Response;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace R6Sharp.Endpoint
{
    public class ProfileEndpoint
    {
        private readonly SessionEndpoint _sessionHandler;

        public ProfileEndpoint(SessionEndpoint sessionHandler)
        {
            _sessionHandler = sessionHandler;
        }

        /// <summary>
        /// Search for a player on Rainbow 6 Siege.
        /// </summary>
        /// <param name="players">
        /// The player names to search for.
        /// </param>
        /// <param name="platform">
        /// The platform the player is on.
        /// </param>
        /// <returns>
        /// A list of players that matched the terms.
        /// </returns>
        public async Task<List<Profile>> GetProfileAsync(string[] players, Platform platform)
        {
            if (players == null || players.Length == 0)
            {
                throw new ArgumentException($"{nameof(players)} cannot be null or empty.");
            }

            foreach (var player in players)
            {
                if (string.IsNullOrEmpty(player))
                {
                    throw new ArgumentException($"Provided PlayerName ({player}) cannot be null or empty.");
                }
            }

            Session session = await _sessionHandler.GetCurrentSessionAsync();

            var endpoint = new Uri(Endpoints.UbiServices.Search);
            var restRequest = new RestRequest(endpoint, Method.Get)
                .AddQueryParameter("namesOnPlatform", string.Join(',', players))
                .AddQueryParameter("platformType", Constant.PlatformToString(platform));

            ProfileSearch profileSearch = await EndpointHelper
                .BuildRestClient(session)
                .GetAsync<ProfileSearch>(restRequest);
            return profileSearch.Profiles;
        }

        public async Task<List<Profile>> GetProfileAsync(Guid[] uuids)
        {
            Session session = await _sessionHandler.GetCurrentSessionAsync();

            var endpoint = new Uri(Endpoints.UbiServices.Search);
            var restRequest = new RestRequest(endpoint, Method.Get)
                .AddQueryParameter("profileIds", string.Join(',', uuids));

            ProfileSearch profileSearch = await EndpointHelper
                .BuildRestClient(session)
                .GetAsync<ProfileSearch>(restRequest);
            return profileSearch.Profiles;
        }

        /// <inheritdoc/>
        public async Task<Profile> GetProfileAsync(string player, Platform platform)
        {
            var profiles = await GetProfileAsync(new string[] { player }, platform).ConfigureAwait(false);
            // the search result could contain more than one result, return first anyways
            return profiles.Count > 0 ? profiles[0] : null;
        }

        /// <inheritdoc/>
        public async Task<Profile> GetProfileAsync(Guid uuid)
        {
            var profiles = await GetProfileAsync(new Guid[] { uuid }).ConfigureAwait(false);
            // the search result could contain more than one result, return first anyways
            return profiles.Count > 0 ? profiles[0] : null;
        }
    }
}
