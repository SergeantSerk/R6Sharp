
using R6DataAccess.Builder.BuildHelper;
using R6DataAccess.Interfaces;
using R6DataAccess.Models;
using R6Sharp;
using R6Sharp.Endpoint;
using R6Sharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using static R6DataAccess.Models.PlayerProgression;

namespace R6DataAccess.Endpoint
{
    public class PlayerProgressionEndpoint : IPlayerProgressionEndpoint
    {

        private readonly ISessionEndpoint _sessionHandler;

        public PlayerProgressionEndpoint(ISessionEndpoint sessionHandler)
        {
            _sessionHandler = sessionHandler;
        }

    
        public async Task<IPlayerProgression> GetPlayerProgressionAsync(Guid uuid, IPlatform platform)
        {

            IQuery query = BuildHelper.BuildPlayerProgressQuery(uuid, platform);
    

            var data = await requestData(query);


            return data.PlayerProgressions.FirstOrDefault();

           
        }

        public async Task<List<IPlayerProgression>> GetPlayerProgressionAsync(Guid[] uuid, IPlatform platform)
        {

            IQuery query = BuildHelper.BuildPlayerProgressQuery(uuid, platform); 


            var data = await requestData(query);


            return data.PlayerProgressions.Cast<IPlayerProgression>().ToList();


        }



        // can go into single helper or something
        private async Task<PlayerProgressionFetch> requestData(IQuery query)

        {
            // build a request 
            IRequest request = Factory.GetRequest(EndPoints.Progressions, query);

            var result = await _sessionHandler.GetDataAsync(request);

            return JsonSerializer.Deserialize<PlayerProgressionFetch>(result);

        }
    }
}
