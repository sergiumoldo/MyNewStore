

using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http.Json;

namespace MyStore.Tests.Integration
{
    public class CategoriesControllerTests:IClassFixture<StoreApiFactory<Program>>
    {
        private readonly HttpClient httpClient;
        public CategoriesControllerTests(StoreApiFactory<Program> apiFactory)
        {
            apiFactory.ClientOptions.BaseAddress = new Uri("http://localhost:7072/api/");
            httpClient = apiFactory.CreateClient();
        }

        [Fact]
        public async void TGet_ReturnsNotFound_WhenCategoryDoesntExist()
        {
            //arrange


            //act
            var response = await httpClient.GetAsync($"/categories/3");

            var problem = await response.Content.ReadFromJsonAsync<ValidationProblemDetails>();
            problem!.Title.Should().Be("Not Found");
            problem.Status.Should().Be(404);

            //assert
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }
    }
}