using R6DataAccess.DataFactory;
using R6DataAccess.Interfaces;
using R6DataAccess.Models;
using R6Sharp;
using R6Sharp.Endpoint;
using R6Sharp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace R6DataAccessTest.EndpointTest.ProfileEndpointTest
{
    public class ProfileEndpointTest:IClassFixture<SessionEndPointFixture>
    {

        private readonly SessionEndPointFixture _fixture;

        private readonly IProfileEndpoint _profileEndpoint;

        public ProfileEndpointTest(SessionEndPointFixture fixture)
        {
            _fixture = fixture;
            _profileEndpoint = EndPointFactory.GetProfileEndpoint(_fixture.sessionEndpoint);
        }

     


        private const string username = "itspizzatimeXDD";


        IPlatform platform = Platform.UPLAY;

        [Fact]
        public async Task UserMatchesTheCorrectProfileId()
        {

            //arrange

            Guid expectedProfileId = Guid.Parse("3e22dc81-bb7e-42ac-88b9-2e6fcac447eb");

            //expected

            var profile = await _profileEndpoint.GetProfileAsync(username, platform);

            var actualId = profile.ProfileId;

            //assert

            Assert.Equal(expectedProfileId, actualId);


        }

        [Fact]
        public async Task TestUserButDifferentPlatform_ShouldReturnNull()
        {

            //arrange

            Guid expectedProfileId = Guid.Parse("3e22dc81-bb7e-42ac-88b9-2e6fcac447eb");

            //expected
            //following user does not exist on PSN
            var profile = await _profileEndpoint.GetProfileAsync(username, Platform.PSN);



            //assert

            // should return null for invalid
            Assert.Null(profile);


        }

        [Fact]
        public async Task ProvideInvalidProfile()
        {

            //arrange

            //EXPECTING NULL 

            var randomMadeUpName = "aosdjoajsd0asd";

            var platform = Platform.PSN;

            //expected

            var profile = await _profileEndpoint.GetProfileAsync(randomMadeUpName, platform);


            //assert

            // should return null for invalid
            Assert.Null(profile);


        }




        [Fact]
        public async Task Get_MultipleProfilesFromUbSoft()
        {

     
            //expected

            var profile = await _profileEndpoint.GetProfileAsync(new string[] { username }, platform);


            //assert

            Assert.True(profile.Count >= 1);




        }


        [Fact]
            public async Task Get_GuidProfileFromUbSoft()
            {

            //arrange

            Guid expectedProfileId = Guid.Parse("3e22dc81-bb7e-42ac-88b9-2e6fcac447eb");

            //expected

            var profile = await _profileEndpoint.GetProfileAsync(expectedProfileId, platform);

                var actualTotal = profile.ProfileId;

                //assert

                Assert.Equal(expectedProfileId, actualTotal);


            }

        [Fact]
        public async Task Get_MultipleGuidProfileFromUbSoft()
        {

            //arrange

           
            Guid profileId = Guid.Parse("3e22dc81-bb7e-42ac-88b9-2e6fcac447eb");

            //expected

            var profile = await _profileEndpoint.GetProfileAsync(new Guid[] { profileId }, platform);

           


            //assert

            Assert.True(profile.Count >= 1 );


        }
    }
}
