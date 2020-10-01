using R6DataAccess.Builder.BuildHelper;
using R6DataAccess.Interfaces;
using R6DataAccess.Models;
using R6DataAccess.Models.Static;
using R6DataAccess.Models.Static.StatisticStatics;
using R6Sharp;
using R6Sharp.Endpoint;
using R6Sharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace R6DataAccess.Endpoint.StatisticEndPoint
{
    public class StatisticEndpoint: IStatisticEndpoint
    {
        private readonly ISessionEndpoint _sessionHandler;

        public StatisticEndpoint(ISessionEndpoint sessionHandler)
        {
            _sessionHandler = sessionHandler;
        }

     
        public async Task<Dictionary<string, EquipmentStatistic>> GetEquipmentStatistics(Guid[] uuids, IPlatform platform)
        {

            IQuery query = BuildHelper.BuildStatisticQuery(uuids, platform, EquipmentStatisticStatics.GetStatistic());

            var data = await requestData(query);

            var deserialised = JsonSerializer.Deserialize<EquipmentStatisticsFetch>(data);

            return deserialised.EquipmentStatistics;
        }

        public async Task<IEquipmentStatistic> GetEquipmentStatistics(Guid uuids, IPlatform platform)
        {

            IQuery query = BuildHelper.BuildStatisticQuery(uuids, platform, EquipmentStatisticStatics.GetStatistic());


            var data = await requestData(query);

            var deserialised = JsonSerializer.Deserialize<EquipmentStatisticsFetch>(data);

            return deserialised.EquipmentStatistics.FirstOrDefault().Value;
        }



        public async Task<Dictionary<string, GamemodeStatistic>> GetGamemodeStatistics(Guid[] uuids, IPlatform platform)
        {
            IQuery query = BuildHelper.BuildStatisticQuery(uuids, platform, GamemodeStatisticStatics.GetStatistic());

            var data = await requestData(query);

            var deserialised = JsonSerializer.Deserialize<GamemodeStatisticFetch>(data);

            return deserialised.GamemodeStatistics;
        }

        public async Task<IGamemodeStatistic> GetGamemodeStatistics(Guid uuid, IPlatform platform)
        {
            IQuery query = BuildHelper.BuildStatisticQuery(uuid, platform, GamemodeStatisticStatics.GetStatistic());

            var data = await requestData(query);

            var deserialised = JsonSerializer.Deserialize<GamemodeStatisticFetch>(data);


            return deserialised.GamemodeStatistics.FirstOrDefault().Value;

        }

        public async Task<Dictionary<string, OperatorStatistic>> GetOperatorStatistics(Guid[] uuids, IPlatform platform)
        {


            IQuery query = BuildHelper.BuildStatisticQuery(uuids, platform, QueueStatisticsStatics.GetStatistic());

            var data = await requestData(query);

            var deserialised = JsonSerializer.Deserialize<OperatorStatisticFetch>(data);

            return deserialised.OperatorStatistics;
        }

        public async Task<IOperatorStatistic> GetOperatorStatistics(Guid uuid, IPlatform platform)
        {


            IQuery query = BuildHelper.BuildStatisticQuery(uuid, platform, QueueStatisticsStatics.GetStatistic());

            var data = await requestData(query);

            var deserialised = JsonSerializer.Deserialize<OperatorStatisticFetch>(data);

            return deserialised.OperatorStatistics.FirstOrDefault().Value;
        }



        public async Task<Dictionary<string, QueueStatistic>> GetQueueStatistics(Guid[] uuids, IPlatform platform)
        {

            IQuery query = BuildHelper.BuildStatisticQuery(uuids, platform, QueueStatisticsStatics.GetStatistic());

            var data = await requestData(query);

            var deserialised = JsonSerializer.Deserialize<QueueStatisticFetch>(data);

            return deserialised.QueueStatistics;
        }

        public async Task<IQueueStatistic> GetQueueStatistics(Guid uuid, IPlatform platform)
        {
            IQuery query = BuildHelper.BuildStatisticQuery(uuid, platform, QueueStatisticsStatics.GetStatistic());

            var data = await requestData(query);

            var deserialised = JsonSerializer.Deserialize<QueueStatisticFetch>(data);

            return deserialised.QueueStatistics.FirstOrDefault().Value;

        }

        public async Task<Dictionary<string, TerroristHuntMissionStatistic>> GetTerroristHuntMissionsStatistics(Guid[] uuids, IPlatform platform)
        {
          
            IQuery query = BuildHelper.BuildStatisticQuery(uuids, platform, TerroristHuntMissionStatisticStatics.GetStatistic());

            var data = await requestData(query);

            var deserialised = JsonSerializer.Deserialize<TerroristHuntMissionStatisticFetch>(data);

            return deserialised.TerroristHuntMissionStatistics;
        }

        public async Task<ITerroristHuntMissionStatistic> GetTerroristHuntMissionsStatistics(Guid uuid, IPlatform platform)
        {
            IQuery query = BuildHelper.BuildStatisticQuery(uuid, platform, TerroristHuntMissionStatisticStatics.GetStatistic());

            var data = await requestData(query);

            var deserialised = JsonSerializer.Deserialize<TerroristHuntMissionStatisticFetch>(data);

            return deserialised.TerroristHuntMissionStatistics.FirstOrDefault().Value;
        }

      

        // may need to rewrite this for it to be  dynamic 
        //https://stackoverflow.com/questions/57211425/deserialize-json-object-to-specific-instance-created-on-the-fly-in-run-time-by-s
        // can go into single helper or something
        private async Task<string> requestData(IQuery query)

        {
            // build a request 
            IRequest request = Factory.GetRequest(EndPoints.Statistics, query);

            return await _sessionHandler.GetDataAsync(request);

        }
    }
}
