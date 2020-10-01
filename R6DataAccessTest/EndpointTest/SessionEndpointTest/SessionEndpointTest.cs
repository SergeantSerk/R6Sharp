using R6DataAccess.DataFactory;
using R6DataAccess.Interfaces;
using R6DataAccess.Models;
using R6Sharp.Endpoint;
using R6Sharp.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace R6DataAccessTest.EndpointTest.SessionEndpointTest
{
    public class SessionEndpointTest:IClassFixture<SessionEndPointFixture>
    {

        private readonly SessionEndPointFixture _fixture;

        public SessionEndpointTest(SessionEndPointFixture fixture)
        {
            _fixture = fixture;
        }


        // not much test can be done here apart from get data

        //[Fact]
        //public async Task Get_SessionTicketFromUbiSoft()
        //{

        //    //Arrange - expected value

        //    Guid expectedProfileId = Guid.Parse("f883c40b-1bb9-48b6-96bc-22252aa3692b"); 

        //    //Act actual value 

        //    ISession session = await _fixture.sessionEndpoint.GetSessionAsync();

        //    var actual = session.ProfileId;

        //    //Assert - testing


        //    Assert.Equal(expectedProfileId, actual);


        //}




    }
}
