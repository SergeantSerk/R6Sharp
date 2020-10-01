using R6DataAccess.Interfaces;
using R6DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace R6DataAccess.Interfaces
{
    public interface IPlayerProgressionEndpoint
    {
        Task<IPlayerProgression> GetPlayerProgressionAsync(Guid uuid, IPlatform platform);
        Task<List<IPlayerProgression>> GetPlayerProgressionAsync(Guid[] uuid, IPlatform platform);

    }
}