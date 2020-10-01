using R6DataAccess.Builder;
using R6DataAccess.Models;
using R6Sharp.Endpoint;
using R6Sharp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace R6Sharp
{
    public static class Factory
    {

        public static HttpClient GetHttpclient()
        {
            var client = new HttpClient();

            Guid Rainbow6S = Guid.Parse("39baebad-39e5-4552-8c25-2c9b919064e2");


            client.DefaultRequestHeaders.Add("Ubi-AppId",Rainbow6S.ToString());


            return client;
        }


        public static IQuery GetQuery()
        {
            return new Query();
        }
     
        public static IQueryBuilder GetQueryBuilder()
        {
            return new QueryBuilder();
        }

        public static IRequest GetRequest(IEndPoints endPoint, IQuery query)
        {

            return new Request(endPoint, query);
        }


        public static IRequest GetRequest(IEndPoints endPoint, ILanguage language)
        {

            return new Request(endPoint, language);
        }

        public static IRequest GetRequest(IEndPoints endPoint)
        {

            return new Request(endPoint);
        }
    }
}
