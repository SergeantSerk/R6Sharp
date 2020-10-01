using R6DataAccess.Builder.BuildHelper;
using R6DataAccess.Interfaces;
using R6DataAccess.Models;
using R6Sharp;
using R6Sharp.Endpoint;
using R6Sharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static R6DataAccess.Models.PlayerProgression;

namespace R6DataAccess.Endpoint.PlayerEndPoint
{
    public class PlayerEndpoint : IPlayerEndpoint
    {

        private readonly ISessionEndpoint _sessionHandler;

        public PlayerEndpoint(ISessionEndpoint sessionHandler)
        {
            _sessionHandler = sessionHandler;
        }

        public async Task<Dictionary<string, BoardInfo>> GetCasualAsync(Guid[] uuids, IPlatform platform, IRegion region, int season = -1)
        {
            IQuery query = BuildHelper.BuildPlayersQuery
                (uuids,platform,region,"pvp_casual", season.ToString());
             

            var data = await requestData(query);


            return data.Players;
        }

      

        public async Task<IBoardInfo> GetCasualAsync(Guid uuid, IPlatform platform, IRegion region, int season = -1)
        {
            IQuery query = BuildHelper.BuildPlayersQuery
               (uuid, platform, region, "pvp_casual", season.ToString());


            var data = await requestData(query);


            return data.Players.FirstOrDefault().Value;
        }


     

        public async Task<Dictionary<string, BoardInfo>> GetRankedAsync(Guid[] uuids, IPlatform platform, IRegion region, int season = -1)
        {
            IQuery query = BuildHelper.BuildPlayersQuery
                (uuids, platform, region, "pvp_ranked", season.ToString());



            var data = await requestData(query);


            return data.Players;
        }

     

        public async Task<IBoardInfo> GetRankedAsync(Guid uuid, IPlatform platform, IRegion region, int season = -1)
        {
            IQuery query = BuildHelper.BuildPlayersQuery
               (uuid, platform, region, "pvp_ranked", season.ToString());



            var data = await requestData(query);


            return data.Players.FirstOrDefault().Value;
        }


     

     
       



        // can go into single helper or something
        private async Task<BoardInfoFetch> requestData(IQuery query)

        {
            // build a request 
            IRequest request = Factory.GetRequest(EndPoints.Players, query);

            var result = await _sessionHandler.GetDataAsync(request);

            return JsonSerializer.Deserialize<BoardInfoFetch>(result);

        }
    }
}
