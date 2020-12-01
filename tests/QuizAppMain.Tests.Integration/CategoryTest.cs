using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using QuizAppMainApi;
using QuizAppMainApi.Data;
using QuizAppModels.Models.Informations;
using Xunit;
using Xunit.Sdk;

namespace QuizAppMain.Tests.Integration
{
    public class CategoryTest
    {
        private readonly HttpClient _client;

        public CategoryTest()
        {
            var appFactory = new CustomWebApplicationFactory<Startup>();
            _client = appFactory.CreateClient();
        }
        
        [Fact]
        public async Task PostAsync_CategoryIsValid_CategoryShouldBeCreated()
        {
            var category = new CategoryInformation
            {
                Name = "Fizyka"
            };

            var content = JsonConvert.SerializeObject(category);
            var stringContent = new StringContent(content, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("/api/category/", stringContent);
            
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var responseToGetCategory = await _client.GetAsync("/api/category/1");
            responseToGetCategory.EnsureSuccessStatusCode();

            var stringResponse = await responseToGetCategory.Content.ReadAsStringAsync();
            var gotCattegory = JsonConvert.DeserializeObject<CategoryInformation>(stringResponse);

            Assert.IsType<CategoryInformation>(gotCattegory);
            Assert.Equal(1, gotCattegory.CategoryId);
        }
    }
}