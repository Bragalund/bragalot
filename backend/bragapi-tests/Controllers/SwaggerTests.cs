using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace bragapi_tests.Controllers
{
    public class SwaggerTests
    {
        [Fact]
        public async Task GetSwaggerUI_Returns_OK()
        {
            await using var application = new BragaApiApplication();

            var client = application.CreateClient();
            var response = await client.GetAsync("/swagger/index.html");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
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