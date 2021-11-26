using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using bragapi;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Newtonsoft.Json;
using Xunit;

namespace bragapi_tests.Controllers
{
    public class WeatherForecastControllerTests
    {

        [Fact]
        public async Task GetWeatherForecast_WhenRequested_ShouldReturnArray()
        {
            await using var application = new BragaApiApplication();

            var client = application.CreateClient();
            var response = await client.GetAsync("/WeatherForecast");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var jsonString = await response.Content.ReadAsStringAsync();
            IEnumerable<WeatherForecast> weatherForecasts = JsonConvert.DeserializeObject<IEnumerable<WeatherForecast>>(jsonString);
            Assert.True(weatherForecasts.Any());
        }
        class BragaApiApplication : WebApplicationFactory<Program>
        {
            protected override IHost CreateHost(IHostBuilder builder)
            {
                // Add mock/test services to the builder here
                builder.ConfigureServices(services => { });

                return base.CreateHost(builder);
            }
        }
     
    }
}