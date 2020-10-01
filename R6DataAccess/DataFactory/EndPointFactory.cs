using R6DataAccess.Endpoint;
using R6DataAccess.Endpoint.PlayerEndPoint;
using R6DataAccess.Endpoint.StatisticEndPoint;
using R6DataAccess.Interfaces;
using R6DataAccess.Models;
using R6Sharp.Endpoint;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6DataAccess.DataFactory
{
    public static class EndPointFactory
    {
        public static ISessionEndpoint GetSessionEndpoint(IAuth auth)
        {

            return new SessionEndpoint(auth);
        }


        public static IProfileEndpoint GetProfileEndpoint(ISessionEndpoint session)
        {
           return  new ProfileEndpoint(session);
        }

        public static IPlayerProgressionEndpoint GetPlayerProgressionEndpoint(ISessionEndpoint session)
        {
            return new PlayerProgressionEndpoint(session);
        }

        public static IPlayerEndpoint GetPlayerEndpoint(ISessionEndpoint session)
        {
            return new PlayerEndpoint(session);
        }

        public static IStatisticEndpoint GetStatisticEndpoint(ISessionEndpoint session)
        {
            return new StatisticEndpoint(session);
        }

        public static IStaticEndpoint GetStaticEndpoint(ISessionEndpoint session)
        {
            return new StaticEndpoint(session);
        }

    }
}
