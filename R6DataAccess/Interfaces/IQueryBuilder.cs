using R6DataAccess.Builder;
using R6DataAccess.Interfaces;
using R6Sharp.Models;
using System;

namespace R6DataAccess.Models
{
    public interface IQueryBuilder
    {
        IQuery Build();
        QueryBuilder NameOnPlatform(string player);
        QueryBuilder PlatformType(IPlatform player);
        QueryBuilder NameOnPlatform(string[] players);

        QueryBuilder IdOnPlatform(Guid uuid);
        QueryBuilder IdOnPlatform(Guid[] uuid);

        QueryBuilder ProfileId(Guid guid);

        QueryBuilder ProfileId(Guid[] guid);

        QueryBuilder BoardId(string id);

        QueryBuilder Region(IRegion region);

        QueryBuilder Population(Guid[] population);

             QueryBuilder Population(Guid population);

        QueryBuilder Statistics(string[] statistics);

        QueryBuilder SeasonId(string id);
    }
}