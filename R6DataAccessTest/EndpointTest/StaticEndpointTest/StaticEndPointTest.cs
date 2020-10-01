using R6DataAccess.DataFactory;
using R6DataAccess.Models;
using R6Sharp.Endpoint;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace R6DataAccessTest.EndpointTest.StaticEndpointTest
{
    public class StaticEndPointTest:IClassFixture<SessionEndPointFixture>
    {

        private IStaticEndpoint _staticEndpoint;

        private SessionEndPointFixture _fixture;

        private readonly ITestOutputHelper output;

        private ILanguage _testLanguage;

        public StaticEndPointTest(SessionEndPointFixture fixture, ITestOutputHelper output)
        {
            _fixture = fixture;

            _staticEndpoint = EndPointFactory.GetStaticEndpoint(_fixture.sessionEndpoint);

            _testLanguage = LanguageEndPoint.SimplifiedChinese;

            this.output = output;


        }

        [Fact]
        public async Task Language_TranslatedAll100Translated()
        {

            var translation = await _staticEndpoint.GetLocaleAsync(_testLanguage);

            Assert.True(translation.Count > 50);


        }

        [Fact]
        public async Task Language_AllShouldReturnTranslation()
        {
            var languageEndPoint = new LanguageEndPoint();

            var languages = languageEndPoint.GetType().GetProperties();

            var InvalidLanguages = new List<ILanguage>();

            foreach(var language in languages)
            {
                var languageProp = (ILanguage) language.GetValue(languageEndPoint);

                var translation = await _staticEndpoint.GetLocaleAsync(languageProp);

                if(translation is null)
                {
                    InvalidLanguages.Add(languageProp);

                    output.WriteLine(languageProp.ShortHand);
                }


            }



            Assert.Empty(InvalidLanguages);

           


        }

  


        [Fact]
        public async Task SeasonDetail_FirstSeasonShouldReturnId2()
        {
            var expected = 2;

            var seasonDetail = await _staticEndpoint.GetSeasonDetailsAsync();

            var actual = seasonDetail[0].Id;

            Assert.Equal(expected, actual);

        }


        [Fact]
        public async Task GetSeason_ShouldReturnDustLineForSeason2()
        {
            var expected = "DUST LINE";

            var season = await _staticEndpoint.GetSeasonAsync(2);

            Assert.Equal(expected, season.Name);

        }
        [Fact]
        public async Task GetSeason_Season20ShouldReturnCurrentSeason18()
        {
            // current season
            var expected = 18;

            var season = await _staticEndpoint.GetSeasonAsync(20);


            Assert.Equal(expected, season.Id);

        }

    }
}
