using R6DataAccess.Interfaces;
using R6DataAccess.Models;
using R6Sharp.Models;
using R6Sharp.Response;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using R6DataAccess.Builder.BuildHelper;

namespace R6Sharp.Endpoint
{
    public class ProfileEndpoint : IProfileEndpoint
    {
        private readonly ISessionEndpoint _sessionHandler;


      


        public ProfileEndpoint(ISessionEndpoint sessionHandler)
        {
            _sessionHandler = sessionHandler;
        }

        /// <summary>
        /// Search for a player on Rainbow 6 Siege.
        /// </summary>
        /// <param name="players">
        /// The player names to search for.
        /// </param>
        /// <param name="platform">
        /// The platform the player is on.d
        /// </param>
        /// <returns>
        /// A list of players that matched the terms.
        /// </returns>


        /// <inheritdoc/>
        public async Task<IProfile> GetProfileAsync(string player, IPlatform platform)
        {


            //var ProfileUrlEndPoint = Endpoints.Search;

            IQuery query = BuildHelper.BuildProfileQuery(player, platform);

            var data = await requestData(query);

            // the search result could contain more than one result, return first anyways
            return data.Profiles.FirstOrDefault();
        }


        public async Task<List<IProfile>> GetProfileAsync(string[] players, IPlatform platform)
        {

            IQuery query = BuildHelper.BuildProfileQuery(players, platform);

            var data = await requestData(query);

            return data.Profiles.Cast<IProfile>().ToList();
        }




        public async Task<IProfile> GetProfileAsync(Guid uuid, IPlatform platform)
        {

            IQuery query = BuildHelper.BuildProfileQuery(uuid,platform);


            var data = await requestData(query);

            return data.Profiles.FirstOrDefault();
        }

        public async Task<List<IProfile>> GetProfileAsync(Guid[] uuids, IPlatform platform)
        {

            IQuery query = BuildHelper.BuildProfileQuery(uuids, platform);


            var data = await requestData(query);

            return data.Profiles.Cast<IProfile>().ToList();
        }



        // can go into single helper or something
        private async Task<ProfileSearch> requestData(IQuery query)

        {
            // build a request 
            IRequest request = Factory.GetRequest(EndPoints.Search, query);

            var result = await _sessionHandler.GetDataAsync(request);

            return JsonSerializer.Deserialize<ProfileSearch>(result);

        }



    }
}
