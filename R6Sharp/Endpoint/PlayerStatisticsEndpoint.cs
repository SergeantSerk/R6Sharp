using R6Sharp.Response;
using R6Sharp.Response.Statistic;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace R6Sharp.Endpoint
{
    public class PlayerStatisticsEndpoint
    {
        private readonly SessionEndpoint _sessionHandler;

        public PlayerStatisticsEndpoint(SessionEndpoint sessionHandler)
        {
            _sessionHandler = sessionHandler;
        }

        public async Task<Dictionary<string, double>> GetQueueStatisticsAsync(Guid uuid,
            Platform platform,
            CancellationToken cancellationToken = default)
        {
            Dictionary<string, Dictionary<string, double>> results = await GetQueueStatisticsAsync(new Guid[] { uuid },
                platform,
                cancellationToken).ConfigureAwait(false);
            return results[uuid.ToString()];
        }

        public async Task<Dictionary<string, Dictionary<string, double>>> GetQueueStatisticsAsync(Guid[] uuids,
            Platform platform,
            CancellationToken cancellationToken = default)
        {
            var queries = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("populations", HttpUtility.UrlEncode(string.Join(',', uuids))),
                new KeyValuePair<string, string>("statistics", Constant.QueuesStatisticsVariables)
            };

            Session session = await _sessionHandler.GetCurrentSessionAsync().ConfigureAwait(false);
            QueueStatistics results = await ApiHelper.GetDataAsync<QueueStatistics>(Endpoints.UbiServices.Statistics,
                platform: platform,
                queries,
                session,
                cancellationToken).ConfigureAwait(false);
            return results.PlayerQueueStatistics;
        }
    }
}