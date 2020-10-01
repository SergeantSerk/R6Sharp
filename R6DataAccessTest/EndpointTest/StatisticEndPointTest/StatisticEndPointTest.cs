using R6DataAccess.DataFactory;
using R6DataAccess.Endpoint.StatisticEndPoint;
using R6DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace R6DataAccessTest.EndpointTest.StatisticEndPointTest
{
    public class StatisticEndPointTest:IClassFixture<SessionEndPointFixture>
    {



        private readonly SessionEndPointFixture _fixture;

        private readonly IStatisticEndpoint _statisticEndpoint;

        public StatisticEndPointTest(SessionEndPointFixture fixture)
        {
            _fixture = fixture;
            _statisticEndpoint = EndPointFactory.GetStatisticEndpoint(_fixture.sessionEndpoint);
        }



        [Fact]

        public async Task TestUser_GetEquipmentKillGreaterThan10()
        {
           var weaponStatistic = await _statisticEndpoint.GetEquipmentStatistics(_fixture.serkanTestAccount, Platform.UPLAY);

              Assert.True(weaponStatistic.WeapontypepveBulletfired1Infinite > 10);


        }


        [Fact]

        public async Task TestUser_GetEquipmentsFromMultipleAccount()
        {
            var weaponStatistic = await _statisticEndpoint.GetEquipmentStatistics(new Guid[] { _fixture.serkanTestAccount, _fixture.TestAccount }, Platform.UPLAY);

            Assert.True(weaponStatistic.Count >= 2);


        }


        [Fact]

        public async Task TestUser_GetGameModeFromMultipleAccount()
        {
            var weaponStatistic = await _statisticEndpoint.GetEquipmentStatistics(new Guid[] { _fixture.serkanTestAccount, _fixture.TestAccount }, Platform.UPLAY);

            Assert.True(weaponStatistic.Count >= 2);


        }

        [Fact]

        public async Task TestUser_GetGameModeStatsGreaterThan5()
        {
            var gameStatistic = await _statisticEndpoint.GetGamemodeStatistics(_fixture.serkanTestAccount, Platform.UPLAY);

            Assert.True(gameStatistic.PlantbombpvpMatchlostInfinite > 10);

        }



        [Fact]

        public async Task TestUser_GetOperatorFromMultipleAccount()
        {
            var OperatorStatistic = await _statisticEndpoint.GetOperatorStatistics(new Guid[] { _fixture.serkanTestAccount, _fixture.TestAccount }, Platform.UPLAY);

            Assert.True(OperatorStatistic.Count >= 2);


        }

        [Fact]

        public async Task TestUser_GetOperatorStatsGreaterThan5()
        {
            var OperatorStatistic = await _statisticEndpoint.GetOperatorStatistics(_fixture.serkanTestAccount, Platform.UPLAY);

            Assert.True(OperatorStatistic.OperatorpveAshBonfirewallbreached32Infinite > 10);

        }



        [Fact]

        public async Task TestUser_GetQueueFromMultipleAccount()
        {
            var QueueStatistic = await _statisticEndpoint.GetQueueStatistics(new Guid[] { _fixture.serkanTestAccount, _fixture.TestAccount }, Platform.UPLAY);

            Assert.True(QueueStatistic.Count >= 2);


        }

        [Fact]

        public async Task TestUser_GetQueueStatsGreaterThan5()
        {
            var QueueStatistic = await _statisticEndpoint.GetQueueStatistics(_fixture.serkanTestAccount, Platform.UPLAY);

            Assert.True(QueueStatistic != null);

        }



        [Fact]

        public async Task TestUser_GetTerroristHuntMissionsFromMultipleAccount()
        {
            var TerroristHuntMissionsStatistic = await _statisticEndpoint.GetTerroristHuntMissionsStatistics(new Guid[] { _fixture.serkanTestAccount, _fixture.TestAccount }, Platform.UPLAY);

            Assert.True(TerroristHuntMissionsStatistic.Count >= 2);


        }

        [Fact]

        public async Task TestUser_GetTerroristHuntMissionsStatsGreaterThan5()
        {
            var TerroristHuntMissionsStatistic = await _statisticEndpoint.GetTerroristHuntMissionsStatistics(_fixture.serkanTestAccount, Platform.UPLAY);

            Assert.True(TerroristHuntMissionsStatistic.AllterrohuntcoopNormalBestscoreInfinite > 10);

        }

    }
}
