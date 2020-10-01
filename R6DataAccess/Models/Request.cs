using R6DataAccess.Builder.BuildHelper;
using R6Sharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace R6DataAccess.Models
{
    public class Request : IRequest
    {


      
        private readonly IEndPoints _endPoints;

        private readonly  IQuery _query;

        private readonly ILanguage _language;



        public string URL { get; set; } 

        //endpoints that require more information passed
        //such as platform guid and sandbox
        private string[] endPointsThatRequireFormat()
        {
            
            return new string[] {
                EndPoints.Progressions.Name ,
                EndPoints.Players.Name,
                EndPoints.Statistics.Name
            };
        }

        private string getFullEndpoint()
        {

            var endPointName = _endPoints.Name;

            // yhp, cant come up with a name
            var endpointsWithMoreInfo = endPointsThatRequireFormat();

            if (endpointsWithMoreInfo.Contains(endPointName))
            {

                return string.Format(_endPoints.Url, _query.PlatformType.Guid, _query.PlatformType.SandBox);
            }
            else
            {

                return _endPoints.Url;
            }
              

        }
        public Request(IEndPoints endPoints, IQuery query)
        {
            _endPoints = endPoints;
            _query = query;
            setUpUrlWithQuery();
        }
        public Request(IEndPoints endPoints, ILanguage language)
        {
            _endPoints = endPoints;
            _language = language;
            updateEndpointLanguage();



        }
        public Request(IEndPoints endPoints)
        {
            _endPoints = endPoints;

            URL = _endPoints.Url;


        }


        private void setUpUrlWithQuery()
        {
            var queryString = QueryHelper.GetQueryString(_query, _endPoints);


            URL =  $"{getFullEndpoint()}?{queryString}";
        }


        private void updateEndpointLanguage()
        {
          URL = string.Format(_endPoints.Url, _language.ShortHand, _language.LocalHash); 
        }

        public Uri GetEndPointUri()
        {
           

            return new Uri(URL);
        }

       
    }
}
