using R6DataAccess.Models;
using R6Sharp.Response.Static;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace R6Sharp.Endpoint
{
    public interface IStaticEndpoint
    {
        Task<Dictionary<string, string>> GetLocaleAsync(ILanguage language);
        Task<List<SeasonDetail>> GetSeasonDetailsAsync();

        Task<SeasonsInfo> GetSeasonsInfoAsync();
        Task<Season> GetCurrentSeasonAsync();
      Task<Season> GetSeasonAsync(int id);
    }
}