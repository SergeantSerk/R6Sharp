using R6DataAccess.Interfaces;
using R6DataAccess.Models;
using R6Sharp;
using R6Sharp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6DataAccess.Builder
{
    public sealed class QueryBuilder : IQueryBuilder
    {
        private string _nameOnPlatform { get; set; }
        private IPlatform _platformType { get; set; }

        private string _idOnPlatform { get; set; }

        private string _profileId { get; set; }

        private string _boardId { get; set; }

        private IRegion _region { get; set; }

        private string _seasonId { get; set; }


        private string _population { get; set; }

        private string _statistics { get; set; }





        public QueryBuilder NameOnPlatform(string player)
        {
            _nameOnPlatform = player;

            return this;
        }

        public QueryBuilder NameOnPlatform(string[] players)
        {   
            if(players != null)
            _nameOnPlatform = string.Join(',', players);

            return this;
        }

        public QueryBuilder PlatformType(IPlatform platform)
        {
            _platformType = platform;

            return this;
        }

        public QueryBuilder ProfileId(Guid guid)
        {
            if (guid != Guid.Empty)
                _profileId = guid.ToString();

            return this;
        }

        public IQuery Build()
        {

            var query = Factory.GetQuery();

            query.NameOnPlatform = _nameOnPlatform;

            query.PlatformType = _platformType;

            query.IdOnPlatform = _idOnPlatform;

            query.ProfileId = _profileId;

            query.BoardId = _boardId;

            query.Region = _region;

            query.SeasonId = _seasonId;

            query.Population = _population;

            query.Statistics = _statistics;

            return query;
            
        }

        public QueryBuilder IdOnPlatform(Guid uuid)
        {
            if (uuid != Guid.Empty)
                _idOnPlatform = uuid.ToString();

            return this;
        }

        public QueryBuilder IdOnPlatform(Guid[] uuid)
        {
            if (uuid != null)
                _idOnPlatform = string.Join(',', uuid);

            return this;
        }

        public QueryBuilder ProfileId(Guid[] guid)
        {
            if (guid != null)
                _profileId = string.Join(',', guid);

            return this;
        }

        public QueryBuilder BoardId(string id)
        {
            _boardId = id;
            return this;
        }

        public QueryBuilder Region(IRegion region)
        {
            _region = region;

            return this;
        }

        public QueryBuilder SeasonId(string id)
        {
            _seasonId = id;

            return this;  
        }

        public QueryBuilder Population(Guid[] population)
        {
            _population = string.Join(',', population);

            return this;
        }

        public QueryBuilder Statistics(string statistics)
        {
            _statistics = statistics;
            return this;
        }

        public QueryBuilder Population(Guid population)
        {
            _population = population.ToString();

            return this;
        }

        public QueryBuilder Statistics(string[] statistics)
        {
            _statistics = string.Join(',', statistics);

            return this;
        }
    }
}
