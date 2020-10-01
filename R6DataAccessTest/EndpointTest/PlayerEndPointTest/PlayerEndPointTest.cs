using R6DataAccess.DataFactory;
using R6DataAccess.Endpoint.PlayerEndPoint;
using R6DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace R6DataAccessTest.EndpointTest
{
    public class PlayerEndPointTest : IClassFixture<SessionEndPointFixture>
    {

        private readonly SessionEndPointFixture _fixture;

        private readonly IPlayerEndpoint _playerEndpoint;

        private Guid testRankAccount = Guid.Parse("0a32319d-f7de-4ec1-a845-25ee53f978a7");

        public PlayerEndPointTest(SessionEndPointFixture fixture)
        {
            _fixture = fixture;
            _playerEndpoint = EndPointFactory.GetPlayerEndpoint(_fixture.sessionEndpoint);
        }


        [Fact]
        public async Task TestUserRank_ShouldReturnKillsGreaterThan1WithSession()
        {

            var player = await _playerEndpoint.GetRankedAsync(_fixture.TestAccount, Platform.UPLAY, Region.EMEA, -1);

            Assert.True(player.Kills > 1);
        }

        [Fact]
        public async Task TestUserRank_ShouldReturnKillsGreaterThan1WithoutSession()
        {

            var player = await _playerEndpoint.GetRankedAsync(_fixture.TestAccount, Platform.UPLAY, Region.EMEA);

            Assert.True(player.Kills > 1);
        }

        [Fact]
        public async Task TestUsersRank_ShouldReturnKillsGreaterThan1WithoutSession()
        {
            var guids = new Guid[]
        {
            Guid.Parse("00000000-0000-0000-0000-000000000000"),
            Guid.Parse("11111111-1111-1111-1111-111111111111"),
            Guid.Parse("22222222-2222-2222-2222-222222222222"),
            Guid.Parse("33333333-3333-3333-3333-333333333333"),
            Guid.Parse("44444444-4444-4444-4444-444444444444")
        };

            var players = await _playerEndpoint.GetRankedAsync(guids, Platform.UPLAY, Region.EMEA);

            Assert.True(players.Count > 1);
        }


    }
}
