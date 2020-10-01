using R6DataAccess.Interfaces;
using R6DataAccess.Models;
using R6Sharp;
using R6Sharp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6DataAccess.Builder.BuildHelper
{
    public class BuildHelper
    {

        // may need to be broken down into seperate methods overloaded



        public static IQuery BuildProfileQuery(string player, IPlatform platform)
        {
            IQuery query = Factory.GetQueryBuilder()
               .NameOnPlatform(player)
               .PlatformType(platform)
               .Build()
               ;

            return query;
        }


        public static IQuery BuildProfileQuery(string[] player, IPlatform platform)
        {
            IQuery query = Factory.GetQueryBuilder()
               .NameOnPlatform(player)
               .PlatformType(platform)
               .Build()
               ;

            return query;
        }

        public static IQuery BuildProfileQuery(Guid uuid, IPlatform platform)
        {
            IQuery query = Factory.GetQueryBuilder()
               .IdOnPlatform(uuid)
               .PlatformType(platform)
               .Build()
               ;

            return query;
        }
        public static IQuery BuildProfileQuery(Guid[] uuid, IPlatform platform)
        {
            IQuery query = Factory.GetQueryBuilder()
               .IdOnPlatform(uuid)
               .PlatformType(platform)
               .Build()
               ;

            return query;
        }

        public static IQuery BuildPlayerProgressQuery(Guid[] uuid, IPlatform platform)
        {
            IQuery query = Factory.GetQueryBuilder()
               .ProfileId(uuid)
               .PlatformType(platform)
               .Build()
               ;

            return query;
        }


        public static IQuery BuildPlayerProgressQuery(Guid uuid, IPlatform platform)
        {
            IQuery query = Factory.GetQueryBuilder()
               .ProfileId(uuid)
               .PlatformType(platform)
               .Build()
               ;

            return query;
        }

        public static IQuery BuildPlayersQuery(Guid[] uuids, IPlatform platform, IRegion region, string boardId, string season= null)
        {
            IQuery query = Factory.GetQueryBuilder()
                 .ProfileId(uuids)
                 .BoardId(boardId)
                 .Region(region)
                 .SeasonId(season)
                 .PlatformType(platform)
                 .Build()
                 ;

            return query;
        }
        public static IQuery BuildPlayersQuery(Guid uuids, IPlatform platform, IRegion region,  string boardId, string season = null)
        {
            IQuery query = Factory.GetQueryBuilder()
                 .ProfileId(uuids)
                 .BoardId(boardId)
                 .Region(region)
                 .SeasonId(season)
                 .PlatformType(platform)
                 .Build()
                 ;

            return query;
        }


        public static IQuery BuildStatisticQuery(Guid uuids, IPlatform platform, string statistics)
        {
            IQuery query = Factory.GetQueryBuilder()
                .PlatformType(platform)
                .Population(uuids)
                .Statistics(statistics)
                .Build();


            return query;
        }
        public static IQuery BuildStatisticQuery(Guid[] uuids, IPlatform platform, string statistics)
        {
            IQuery query = Factory.GetQueryBuilder()
                .PlatformType(platform)
                .Population(uuids)
                .Statistics(statistics)
                .Build();


            return query;
        }

     
    }
}
