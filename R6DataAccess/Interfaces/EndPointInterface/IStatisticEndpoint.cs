using R6DataAccess.Interfaces;
using R6DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace R6DataAccess.Endpoint.StatisticEndPoint
{
    public interface IStatisticEndpoint
    {

        Task<Dictionary<string, EquipmentStatistic>> GetEquipmentStatistics(Guid[] uuids, IPlatform platform);
        Task<IEquipmentStatistic> GetEquipmentStatistics(Guid uuids, IPlatform platform);

        Task<Dictionary<string, GamemodeStatistic>> GetGamemodeStatistics(Guid[] uuids, IPlatform platform);
        Task<IGamemodeStatistic> GetGamemodeStatistics(Guid uuid, IPlatform platform);

        Task<Dictionary<string, OperatorStatistic>> GetOperatorStatistics(Guid[] uuids, IPlatform platform);
        Task<IOperatorStatistic> GetOperatorStatistics(Guid uuid, IPlatform platform);

        Task<Dictionary<string, QueueStatistic>> GetQueueStatistics(Guid[] uuids, IPlatform platform);

        Task<IQueueStatistic> GetQueueStatistics(Guid uuid, IPlatform platform);

        Task<Dictionary<string, TerroristHuntMissionStatistic>> GetTerroristHuntMissionsStatistics(Guid[] uuids, IPlatform platform);

        Task<ITerroristHuntMissionStatistic> GetTerroristHuntMissionsStatistics(Guid uuid, IPlatform platform);


    }
}