using R6DataAccess.Interfaces;
using R6Sharp.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace R6Sharp.Endpoint
{
    public interface IProfileEndpoint
    {
        Task<IProfile> GetProfileAsync(string player, IPlatform platform);
        Task<List<IProfile>> GetProfileAsync(string[] players, IPlatform platform);
        Task<IProfile> GetProfileAsync(Guid uuid, IPlatform platform);
        Task<List<IProfile>> GetProfileAsync(Guid[] uuids, IPlatform platform);
    }
}