using R6Sharp.Response;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace R6Sharp.Endpoint
{
    public class SessionEndpoint
    {
        /// <summary>
        /// Credential in base64 acquired from constructor.
        /// </summary>
        private readonly string _credentialsb64;

        /// <summary>
        /// Current session details with Ubisoft.
        /// </summary>
        private Session _currentSession;

        /// <summary>
        /// Control if Ubisoft's session handler should remember current session.
        /// </summary>
        public bool RememberMe { get; set; }

        public SessionEndpoint(string email, string password, bool rememberMe)
        {
            RememberMe = rememberMe;
            // Generate an auth for acquiring a token
            var auth = $"{email}:{password}";
            var bytes = Encoding.UTF8.GetBytes(auth);
            _credentialsb64 = Convert.ToBase64String(bytes);
        }

        public async Task<Session> GetCurrentSessionAsync(CancellationToken cancellationToken = default)
        {
            // refresh ticket state
            await GetTicketAsync(cancellationToken).ConfigureAwait(false);

            return _currentSession;
        }

        public async Task<string> GetTicketAsync(CancellationToken cancellationToken = default)
        {
            var sessionFileName = "session.json";
            var now = DateTime.UtcNow;
            var requestNewSession = false;
            // If Session exists in memory, check if it has expired
            if (_currentSession != null)
            {
                if (!ValidateSession(now, _currentSession.Expiration))
                {
                    // Session expired, get new session
                    requestNewSession = true;
                }
            }
            else
            {
                // This is the first time starting session, check if session details were saved as JSON
                try
                {
                    using var fileStream = File.OpenRead(sessionFileName);
                    Session loadedSession = await JsonSerializer.DeserializeAsync<Session>(fileStream,
                        cancellationToken: cancellationToken);

                    // If Session was readable and there is time before expiration
                    if (loadedSession != null && ValidateSession(now, loadedSession.Expiration))
                    {
                        // Use the loaded session
                        _currentSession = loadedSession;
                    }
                    else
                    {
                        // Get new session
                        requestNewSession = true;
                    }
                }
                catch (Exception e)
                {
                    // Session file was not found or it was malformed/invalid
                    if (e is FileNotFoundException || e is JsonException)
                    {
                        requestNewSession = true;
                    }
                    else
                    {
                        // Error is unknown, rethrow it
                        throw;
                    }
                }
            }

            if (requestNewSession)
            {
                // Refresh current session details (will get new session if expired or non-existent)
                _currentSession = await GetSessionAsync(cancellationToken).ConfigureAwait(false);
                // Save new session to file
                using var file = File.OpenWrite(sessionFileName);
                await JsonSerializer.SerializeAsync(file, _currentSession,
                    cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            return _currentSession.Ticket;
        }

        private bool ValidateSession(DateTime nowUtc, DateTime expirationUtc)
        {
            // Check if there is one minute left until expiration
            // TO-DO: One minute is arbitrary, maybe use error 401 to detect
            // session expiration for edge cases
            return nowUtc.AddMinutes(1) <= expirationUtc;
        }

        private async Task<Session> GetSessionAsync(CancellationToken cancellationToken = default)
        {
            // Build json for remembering (or not) the user/session
            var data = $"{{\"rememberMe\": {(RememberMe ? "true" : "false")}}}";
            // Add authorization header
            var headervaluepairs = new[]
            {
                new KeyValuePair<string, string>(HttpRequestHeader.Authorization.ToString(), $"Basic {_credentialsb64}")
            };

            // Get result from endpoint
            var endpoint = new Uri(Endpoints.UbiServices.Sessions);
            return await ApiHelper.BuildRequestAsync<Session>(endpoint,
                headervaluepairs,
                data,
                false,
                cancellationToken).ConfigureAwait(false);
        }
    }
}
