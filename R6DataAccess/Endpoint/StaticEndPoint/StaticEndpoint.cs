using R6DataAccess.Models;
using R6Sharp.Response.Static;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace R6Sharp.Endpoint
{
  

    public class StaticEndpoint : IStaticEndpoint
    {

        private ISessionEndpoint _sessionEndpoint;

        public StaticEndpoint(ISessionEndpoint sessionEndpoint)
        {
            _sessionEndpoint = sessionEndpoint;
        }

        /// <summary>
        /// Get locale dictionary based on requested language.
        /// </summary>
        /// <returns>
        /// Dictionary with list of items (oasisId and value) that contains localization items.
        /// </returns>
        public async Task<Dictionary<string, string>> GetLocaleAsync(ILanguage language)
        {



            IRequest request = Factory.GetRequest(EndPoints.Locales, language);


            var results = await _sessionEndpoint.GetDataNoTicketRequiredAsync(request);


            return translationAvaliable(results);
        }


        private Dictionary<string, string> translationAvaliable(string results)
        {
            try
            {
                var Deserialize = JsonSerializer.Deserialize<Dictionary<string, string>>(results);

                return Deserialize;
            }
            catch(JsonException)
            {
              // no translation UbiSoft returned 404
            }

            return null;
        }

        /// <summary>
        /// Get overall seasons data (season 2 and onwards).
        /// </summary>
        /// <returns>
        /// List of seasons with their respective details like ranks and divisions.
        /// </returns>
        public async Task<List<SeasonDetail>> GetSeasonDetailsAsync()
        {

            IRequest request = Factory.GetRequest(EndPoints.Ranks);

            // Fetch ranked static data
            var fetch = await _sessionEndpoint.GetDataNoTicketRequiredAsync(request);


            var deserialized = JsonSerializer.Deserialize<RankFetch>(fetch);
            // Prefix R6 base URL to the images URL so it is ready to use as it is
         
            return deserialized.Seasons;
        }

        /// <summary>
        /// Get information based on past and current seasons.
        /// </summary>
        /// <returns>
        /// Latest season and dictionary of seasons with their respective names and URL to season background.
        /// </returns>
        public async Task<SeasonsInfo> GetSeasonsInfoAsync()
        {

            IRequest request = Factory.GetRequest(EndPoints.Seasons);

            var results = await _sessionEndpoint.GetDataNoTicketRequiredAsync(request);

            return JsonSerializer.Deserialize<SeasonsInfo>(results);
        }

        /// <summary>
        /// Get information specific to a season.
        /// </summary>
        /// <param name="id">
        /// The season number, such as 18 for Steel Wave, or -1 for latest.
        /// </param>
        /// <returns>
        /// Season details.
        /// </returns>
        public async Task<Season> GetSeasonAsync(int id)
        {
            var info = await GetSeasonsInfoAsync().ConfigureAwait(false);


            

            if(!isValidSeason(id, info))
            {
                id = info.LatestSeason;
            }

            var season = info.Seasons[id.ToString()];

            season.Id = id;

            return season;
        }

        private bool isValidSeason(int id , SeasonsInfo seasonsInfo)
        {
         
            // not safe if the dictonary gets added or removed as dictnary is not sorted
            var currentSeason = int.Parse(seasonsInfo.Seasons.Keys.Last());


            return true ? id < currentSeason && id > 0 : false; 
        }

        /// <inheritdoc/>
        public async Task<Season> GetCurrentSeasonAsync()
        {
            return await GetSeasonAsync(-1).ConfigureAwait(false);
        }
    }
}
