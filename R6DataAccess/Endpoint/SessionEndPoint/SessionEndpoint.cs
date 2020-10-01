
using R6DataAccess;
using R6DataAccess.Builder;
using R6DataAccess.Interfaces;
using R6DataAccess.Models;
using R6Sharp.Models;
using R6Sharp.Response;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace R6Sharp.Endpoint
{
    public class SessionEndpoint : ISessionEndpoint
    {
        /// <summary>
        /// Credential in base64 acquired from constructor.
        /// </summary>
        private readonly string _credentialsb64;
        private string  _sessionFileName = "session.json";

        /// <summary>
        /// Current session details with Ubisoft.
        /// </summary>
        private ISession _currentSession;

        private ISession _savedSession;

        private HttpClient _httpclient = Factory.GetHttpclient();

        /// <summary>
        /// Control if Ubisoft's session handler should remember current session.
        /// </summary>
        private bool RememberMe { get; set; }

        public SessionEndpoint(IAuth auth)
        {

            _credentialsb64 = auth.GetCredentialBase64();
        }


        // only needed if needed to access endpointwithout ticket/authentication
       public SessionEndpoint()
       {

               

       }


        private async Task<string> GetTicketAsync()
        {
            

           
            // If Session exists in memory, check if it has expired

            if(!IsTicketInMemoryValid())
            {
                // check if json one is valid
                if (IsTicketInJsonValid())
                {
                    //used the saved session
                    _currentSession = _savedSession;

                    return _currentSession.Ticket;
                }
       

                return await GenerateNewKeyToken();
                
            }
                
            return _currentSession.Ticket; 
        }

        private bool IsTicketInMemoryValid()
        {
            if (_currentSession != null)
            {
                var now = DateTime.UtcNow;
                //expired
                if (now >= _currentSession.Expiration)
                {
                    return false;
                }

                return true;
            }

            return false;
        }

        private bool IsTicketInJsonValid()
        {

            _savedSession = GetSavedSession();

            if(_savedSession != null && DateTime.UtcNow < _savedSession.Expiration)
            {

                return true;
            }

            return false;
              
        }

        private ISession GetSavedSession()
        {
           
            try
            {
                var json = File.ReadAllText(_sessionFileName);

                

                return JsonSerializer.Deserialize<Session>(json);

               
            }
            catch (FileNotFoundException )

            {
                // Session file was not found or it was malformed/invalid
                return null;
            }
        }


        private void UpdateSessionJson()
        {
            // Save new session to file
            var serialisedSession = JsonSerializer.Serialize(_currentSession);

            File.WriteAllText(_sessionFileName, serialisedSession);
        }

        private async Task<string> GenerateNewKeyToken()
        { 
            // Refresh current session details (will get new session if expired or non-existent)
            _currentSession = await GetSessionAsync();

            return _currentSession.Ticket;
        }


        // need to write check to see if there arent too many request coming through
        private async Task<ISession> GetSessionAsync()
        {
           

            var data = new StringContent($"{{\"rememberMe\": {(RememberMe ? "true" : "false")}}}");


            var response = await HttpPostAsync(data);

            CheckHttpResponseIsValid(response);

            return JsonSerializer.Deserialize<Session>(response);
        }


        private void CheckHttpResponseIsValid(string data)
        {
            var HttpMessage = JsonSerializer.Deserialize<HttpError>(data);

            if(HttpMessage != null)
            {
                if(HttpMessage.HttpCode > 400)
                {
                    throw new HttpToManyRequestException(HttpMessage.Message);
                }
            }

        }
        // this could probably go and stick with httpclientrequest
        public async Task<string> GetDataAsync(IRequest request)
        {
            await SetTicketHeader();

            return await HttpclientRequestAsync(request); 

        }

        public async Task<string> GetDataNoTicketRequiredAsync(IRequest request)
        {

            return await HttpclientRequestAsync(request);

        }


        private async Task<string> HttpPostAsync(HttpContent content)
        {
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            // just in case the method gets reused
            setAuthorizationHeader(new AuthenticationHeaderValue("Basic", _credentialsb64));

            //$"Basic {_credentialsb64}")

            var response = await _httpclient.PostAsync(EndPoints.Sessions.Url, content);

            //response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return await response.Content.ReadAsStringAsync();
        }

        private async Task SetTicketHeader()
        {
            var ticket = await GetTicketAsync();


            setAuthorizationHeader(new AuthenticationHeaderValue("Ubi_v1", $"t={ticket}"));
            //$"Ubi_v1 t={ticket}"


        }


        private async Task<string> HttpclientRequestAsync(IRequest request)
        {

          
          
            var response = await _httpclient.GetAsync(request.URL);

            return await response.Content.ReadAsStringAsync();

        }


        private void setAuthorizationHeader(AuthenticationHeaderValue header)
        {
            // currently have it in another  method in case for future validation is required
            _httpclient.DefaultRequestHeaders.Authorization = header;

        }



    }
}
