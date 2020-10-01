using R6DataAccess.DataFactory;
using R6DataAccess.Endpoint.PlayerEndPoint;
using R6DataAccess.Endpoint.StatisticEndPoint;
using R6DataAccess.Interfaces;
using R6DataAccess.Models;
using R6Sharp.Endpoint;


namespace R6Sharp
{
    

    public class R6Api
    {
        public readonly IProfileEndpoint Profile;
        private readonly ISessionEndpoint _sessionEndpoint;
        public readonly IPlayerProgressionEndpoint PlayerProgression;
        public readonly IPlayerEndpoint Player;
        public readonly IStaticEndpoint Static;
        public readonly IStatisticEndpoint Statistic;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="auth"></param>
        public R6Api(IAuth auth)
        {
           
            _sessionEndpoint = EndPointFactory.GetSessionEndpoint(auth);

            Profile = EndPointFactory.GetProfileEndpoint(_sessionEndpoint);
            PlayerProgression = EndPointFactory.GetPlayerProgressionEndpoint(_sessionEndpoint);
            Player = EndPointFactory.GetPlayerEndpoint(_sessionEndpoint);
            Static = EndPointFactory.GetStaticEndpoint(_sessionEndpoint);
            Statistic = EndPointFactory.GetStatisticEndpoint(_sessionEndpoint);

            
           
        }
       
    }
}
