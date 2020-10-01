using R6DataAccess.Interfaces;
using R6DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace R6DataAccess.Endpoint.PlayerEndPoint
{
    public interface IPlayerEndpoint
    {
        Task<IBoardInfo> GetRankedAsync(Guid uuid, IPlatform platform, IRegion region, int season = -1);


        Task<Dictionary<string, BoardInfo>> GetRankedAsync(Guid[] uuids, IPlatform platform, IRegion region, int season = -1);


        Task<Dictionary<string, BoardInfo>> GetCasualAsync(Guid[] uuids, IPlatform platform, IRegion region, int season = -1);



        Task<IBoardInfo> GetCasualAsync(Guid uuid, IPlatform platform, IRegion region, int season = -1);


      

    }
}