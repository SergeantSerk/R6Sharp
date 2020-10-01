using R6DataAccess.DataFactory;
using R6DataAccess.Models;
using R6Sharp.Endpoint;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6DataAccessTest.EndpointTest
{
    public class SessionEndPointFixture : IDisposable
    {
      
        public ISessionEndpoint sessionEndpoint { get; private set; }

        public Guid TestAccount { get; set; } =  Guid.Parse("3e22dc81-bb7e-42ac-88b9-2e6fcac447eb");
        public Guid serkanTestAccount = Guid.Parse("0a32319d-f7de-4ec1-a845-25ee53f978a7");


        public SessionEndPointFixture()
        {
            sessionEndpoint = EndPointFactory.GetSessionEndpoint(new Auth("email", "password", false)); 
        }

        public void Dispose()
        {
           
        }
    }
}
