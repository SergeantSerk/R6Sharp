using R6Sharp.Response;
using R6Sharp.Response.Statistic;
using RestSharp;
using System;
using System.Collections.Generic;
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

        public async Task<Dictionary<string, double>> GetQueueStatisticsAsync(Guid uuid, Platform platform)
        {
            var results = await GetQueueStatisticsAsync(new Guid[] { uuid }, platform).ConfigureAwait(false);
            return results[uuid.ToString()];
        }

        public async Task<Dictionary<string, Dictionary<string, double>>> GetQueueStatisticsAsync(Guid[] uuids, Platform platform)
        {
            Session session = await _sessionHandler.GetCurrentSessionAsync();

            string constructedUrl = string.Format(Endpoints.UbiServices.Statistics, Constant.PlatformToGuid(platform), Constant.PlatformToSandbox(platform));
            var endpoint = new Uri(constructedUrl);
            var restRequest = new RestRequest(endpoint, Method.Get)
                .AddQueryParameter("populations", HttpUtility.UrlEncode(string.Join(',', uuids)))
                .AddQueryParameter("statistics", Constant.QueuesStatisticsVariables);

            QueueStatistics queueStatistics = await ApiHelper
                .BuildRestClient(session)
                .GetAsync<QueueStatistics>(restRequest);
            return queueStatistics.PlayerQueueStatistics;
        }
    }
}