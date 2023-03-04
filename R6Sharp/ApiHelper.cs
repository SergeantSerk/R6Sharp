using R6Sharp.Response;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace R6Sharp
{
    internal static class ApiHelper
    {
        internal static async Task<T> GetDataAsync<T>(string url,
            Guid player,
            IEnumerable<KeyValuePair<string, string>> queries,
            Session session,
            CancellationToken cancellationToken = default)
        {
            url = string.Format(url, player.ToString());
            return await GetDataAsync<T>(url, queries, session, cancellationToken).ConfigureAwait(false);
        }

        internal static async Task<T> GetDataAsync<T>(string url,
            Platform? platform,
            IEnumerable<KeyValuePair<string, string>> queries,
            Session session,
            CancellationToken cancellationToken)
        {
            if (platform != null)
            {
                if (url.Equals(Endpoints.UbiServices.Progressions) ||
                    url.Equals(Endpoints.UbiServices.Players) ||
                    url.Equals(Endpoints.UbiServices.PlayerSkillRecords) ||
                    url.Equals(Endpoints.UbiServices.Statistics))
                {
                    url = string.Format(url, Constant.PlatformToGuid(platform ?? default), Constant.PlatformToSandbox(platform ?? default));
                }
                else
                {
                    url = string.Format(url, Constant.PlatformToGuid(platform ?? default));
                }
            }
            return await GetDataAsync<T>(url, queries, session, cancellationToken).ConfigureAwait(false);
        }

        private static async Task<T> GetDataAsync<T>(string url,
            IEnumerable<KeyValuePair<string, string>> queries,
            Session session,
            CancellationToken cancellationToken)
        {
            if (queries != null)
            {
                // TO-DO: find a better, more secure way of doing this
                var completeQueries = new List<string>();
                foreach (var query in queries)
                {
                    completeQueries.Add(string.Join('=', query.Key, query.Value));
                }

                url = string.Join('?', url, string.Join('&', completeQueries));
            }

            var uri = new Uri(url);
            // Add authorization header with ticket (may be null, for requests that are static)
            var headerValuePairs = new List<KeyValuePair<string, string>>();
            if (session != null)
            {
                headerValuePairs.Add(new KeyValuePair<string, string>("Authorization", $"Ubi_v1 t={session.Ticket}"));
                headerValuePairs.Add(new KeyValuePair<string, string>("Expiration", session.Expiration.ToString("O")));
                headerValuePairs.Add(new KeyValuePair<string, string>("Ubi-SessionID", session.SessionId.ToString()));
            }

            return await BuildRequestAsync<T>(uri, headerValuePairs.ToArray(), null, true, cancellationToken).ConfigureAwait(false);
        }

        internal static async Task<T> BuildRequestAsync<T>(Uri uri,
            KeyValuePair<string, string>[] additionalHeaderValues,
            string data,
            bool get,
            CancellationToken cancellationToken)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.Clear();
            client.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("R6Sharp", "3.0"));
            client.DefaultRequestHeaders.Add("Ubi-AppId", Constant.Rainbow6S.ToString());

            // Apply auxiliary headers supplied to method
            foreach (var additionalHeaderValue in additionalHeaderValues)
            {
                client.DefaultRequestHeaders.Add(additionalHeaderValue.Key, additionalHeaderValue.Value);
            }

            if (get)
            {
                return await client.GetFromJsonAsync<T>(uri, cancellationToken).ConfigureAwait(false);
            }
            else
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(uri,
                    data,
                    cancellationToken).ConfigureAwait(false);
                return await response.Content.ReadFromJsonAsync<T>(cancellationToken: cancellationToken);
            }
        }

        internal static string DeriveGamemodeFlags(Gamemode gamemode)
        {
            var gamemodes = new List<string>();

            if (gamemode.HasFlag(Gamemode.Casual))
            {
                gamemodes.Add(Constant.GamemodeToString(Gamemode.Casual));
            }

            if (gamemode.HasFlag(Gamemode.Unranked))
            {
                gamemodes.Add(Constant.GamemodeToString(Gamemode.Unranked));
            }

            if (gamemode.HasFlag(Gamemode.Ranked))
            {
                gamemodes.Add(Constant.GamemodeToString(Gamemode.Ranked));
            }

            if (gamemode.HasFlag(Gamemode.All))
            {
                gamemodes.Add(Constant.GamemodeToString(Gamemode.All));
            }

            return string.Join(',', gamemodes);
        }

        internal static string DerivePlatformFlags(Platform platform)
        {
            var platforms = new List<string>();

            if (platform.HasFlag(Platform.PC))
            {
                platforms.Add(Constant.PlatformToName(Platform.PC));
            }
            if (platform.HasFlag(Platform.PSN))
            {
                platforms.Add(Constant.PlatformToName(Platform.PSN));
            }
            if (platform.HasFlag(Platform.XBL))
            {
                platforms.Add(Constant.PlatformToName(Platform.XBL));
            }

            return string.Join(',', platforms);
        }

        internal static string DeriveTeamRoleFlags(TeamRole teamrole)
        {
            var teamroles = new List<string>();

            if (teamrole.HasFlag(TeamRole.All))
            {
                teamroles.Add(Constant.TeamRoleToString(TeamRole.All));
            }
            if (teamrole.HasFlag(TeamRole.Attacker))
            {
                teamroles.Add(Constant.TeamRoleToString(TeamRole.Attacker));
            }
            if (teamrole.HasFlag(TeamRole.Defender))
            {
                teamroles.Add(Constant.TeamRoleToString(TeamRole.Defender));
            }

            return string.Join(',', teamroles);
        }
    }
}
