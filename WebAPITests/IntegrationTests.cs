using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using WebAPI;
using Xunit;

namespace WebAPITests
{
    public class IntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> factory;

        public IntegrationTests(WebApplicationFactory<Startup> factory)
        {
            this.factory = factory;
        }

        [Fact]
        public async Task ValuesController_Index()
        {
            var client = factory.CreateClient();

            var response = await client.GetAsync("/api/values");

            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();

            Assert.Equal("[\"value1\",\"value2\"]", body);
        }

        [Fact]
        public async Task ValuesController_Get()
        {
            var client = factory.CreateClient();

            var response = await client.GetAsync("/api/values/5");

            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();

            Assert.Equal("value", body);
        }
    }
}
