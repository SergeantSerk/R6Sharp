using R6Sharp.Response;
using System;
using System.Collections.Generic;
using System.Threading;
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
        public async Task<List<PlayerProgression>> GetPlayerProgressionAsync(Guid[] uuids,
            Platform platform,
            CancellationToken cancellationToken = default)
        {
            var queries = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("profile_ids", string.Join(',', uuids))
            };

            Session session = await _sessionHandler.GetCurrentSessionAsync().ConfigureAwait(false);
            PlayerProgressionFetch results = await ApiHelper.GetDataAsync<PlayerProgressionFetch>(Endpoints.UbiServices.Progressions,
                platform: platform,
                queries,
                session,
                cancellationToken).ConfigureAwait(false);
            foreach (var result in results.PlayerProgressions)
            {
                // Attach link to player profile icon url
                string formatted = string.Format(Endpoints.Static.Avatar, result.ProfileId, Constant.Rainbow6S);
                result.ProfileIcon = new Uri(formatted);
            }
            return results.PlayerProgressions;
        }

        /// <inheritdoc/>
        public async Task<PlayerProgression> GetPlayerProgressionAsync(Guid uuid,
            Platform platform,
            CancellationToken cancellationToken = default)
        {
            List<PlayerProgression> playerProgressions = await GetPlayerProgressionAsync(new[] { uuid },
                platform,
                cancellationToken).ConfigureAwait(false);
            return playerProgressions.Count > 0 ? playerProgressions[0] : null;
        }
    }
}
