using R6DataAccess.DataFactory;
using R6DataAccess.Interfaces;
using R6DataAccess.Models;
using R6Sharp.Endpoint;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace R6DataAccessTest.EndpointTest.PlayerProgressionEndPointTest
{
  

    public class PlayerProgressionEndPointTest:IClassFixture<SessionEndPointFixture>
    {

        private readonly SessionEndPointFixture _fixture;

        private readonly IPlayerProgressionEndpoint _playerProgressionEndpoint;

        public PlayerProgressionEndPointTest(SessionEndPointFixture fixture)
        {
            _fixture = fixture;
            _playerProgressionEndpoint = EndPointFactory.GetPlayerProgressionEndpoint(_fixture.sessionEndpoint);
        }
     

        IPlatform platform = Platform.UPLAY;

        [Fact]
        public async Task GetPlayerProgressionTest()
        {

            Guid ProfileId = Guid.Parse("3e22dc81-bb7e-42ac-88b9-2e6fcac447eb");

            //arrange

            var expectedLevel = 187;

            //expected

            var progression = await _playerProgressionEndpoint.GetPlayerProgressionAsync(ProfileId, platform);

            var actualLevel = progression.Level;

            //assert

            Assert.Equal(expectedLevel, actualLevel);

        }

        [Fact]
        public async Task GetPlayersProgressionTest()
        {

            Guid ProfileId = Guid.Parse("3e22dc81-bb7e-42ac-88b9-2e6fcac447eb");

            //arrange


            //expected

            var progression = await _playerProgressionEndpoint.GetPlayerProgressionAsync(new Guid[] { ProfileId }, platform);

         

            //assert

            Assert.True(progression.Count >= 1);

        }


        [Fact]
        public async Task ValidUserButDifferentPlatform()
        {

            //arrange

            var expectedExp = 0;

            Guid profileId = Guid.Parse("3e22dc81-bb7e-42ac-88b9-2e6fcac447eb");

            //expected
            //following user does not exist on PSN
            var profile = await _playerProgressionEndpoint.GetPlayerProgressionAsync(profileId, Platform.PSN);



            //assert

            // should return null for invalid
            Assert.Equal(expectedExp, profile.XP);


        }

    }
}
