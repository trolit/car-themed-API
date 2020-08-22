using car_themed_app_Contracts;
using car_themed_app_IntegrationTests.DeserializedJsonModels;
using car_themed_app_Repository.Dtos.DealerDtos;
using car_themed_app_Repository.Models;
using FluentAssertions;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace car_themed_app_IntegrationTests
{
    public class DealersControllerTests : IntegrationTest
    {
        private readonly int _defaultPageNumber = 1;
        private readonly int _defaultMaxPageSize = 10;

        [Fact]
        public async Task GetAllDealers_WithoutAnyDealers_ReturnsEmptyResponse()
        {
            // Arrange
            
            // Act
            HttpResponseMessage response = await TestClient.GetAsync(ApiRoutes.Dealers.GetAll);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            string result = await response.Content.ReadAsStringAsync();
            var responseContent = DeserializeContentIntoObject<DeserializedGetAll<DealerDto>>(result);

            responseContent.Data.Count.Should().Be(0);
            responseContent.PageNumber.Should().Be(_defaultPageNumber);
            responseContent.PageSize.Should().Be(_defaultMaxPageSize);
            responseContent.NextPage.Should().BeNull();
            responseContent.PreviousPage.Should().BeNull();
        }

        [Fact]
        public async Task Get_ReturnsDealers_WhenDealerExistsInDatabase()
        {
            // Arrange
            var createdDealer = await CreateDealerAsync(new NewDealerDto { Name = "Kazlov", Address = "Inte-Tests", Country = "Poland", PostalCode = "040" });

            // Act
            var response = await TestClient.GetAsync(ApiRoutes.Dealers.Get.Replace("{dealerId}", createdDealer.Id.ToString()));

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var responseContent = await response.Content.ReadAsStringAsync();
            var returnedDealer = DeserializeContentIntoObject<DealerDto>(responseContent);

            returnedDealer.Id.Should().Be(createdDealer.Id);
            returnedDealer.Name.Should().Be(createdDealer.Name);
            returnedDealer.Address.Should().Be(createdDealer.Address);
            returnedDealer.PostalCode.Should().Be(createdDealer.PostalCode);
            returnedDealer.Country.Should().Be(createdDealer.Country);
        }

        private async Task<Dealer> CreateDealerAsync(NewDealerDto dealer)
        {
            var response = await TestClient.PostAsJsonAsync(ApiRoutes.Dealers.Create, dealer);
            var responseContent = await response.Content.ReadAsStringAsync();
            return DeserializeContentIntoObject<Dealer>(responseContent);
        }
    }
}
