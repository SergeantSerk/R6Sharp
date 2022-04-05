using R6Sharp.Response;
using RestSharp;

namespace R6Sharp.Endpoint
{
    internal static class EndpointHelper
    {
        internal static RestClient BuildRestClient(Session session)
        {
            // TO-DO: figure out dynamic versioning for User-Agent
            var restClientOptions = new RestClientOptions { UserAgent = "R6Sharp/3.0" };
            var restClient = new RestClient(restClientOptions);
            restClient.AddDefaultHeader("Ubi-AppId", Constant.Rainbow6S.ToString());

            if (session != null)
            {
                restClient.AddDefaultHeader(KnownHeaders.Authorization, $"Ubi_v1 t={session.Ticket}");
                restClient.AddDefaultHeader("Expiration", session.Expiration.ToString("O"));
                restClient.AddDefaultHeader("Ubi-SessionID", session.SessionId.ToString());
            }

            return restClient;
        }
    }
}
