using MainStoreFunctionality.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MainStoreFunctionality.WebApiCore
{
    public class WebApiCoreClient : IWebApiCoreClient
    {
        private readonly HttpClient _client;
        public WebApiCoreClient()
        {
            _client = new HttpClient();
        }

        //--------------------------------Employees-------------------------------------------------------------------

        public async Task<List<Employee>> GetEmployeesByShop(int shopId)
        {
            var response = await _client.GetAsync(String.Format(WebApiCoreUrls.GetEmployeesbyShopUrl, shopId));
            var content = response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : String.Empty;

            var employees = JsonConvert.DeserializeObject<List<Employee>>(content);
            return employees;
        }

        public async Task AddEmployee(Employee employee)
        {
            var httpContent = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(WebApiCoreUrls.AddEmployeeUrl, httpContent);
        }

        public async Task DeleteEmployee(int id)
        {
            var response = await _client.DeleteAsync(String.Format(WebApiCoreUrls.DeleteEmployeeUrl, id));
        }

        public async Task<int> GetLastIndexEmployees()
        {
            var response = await _client.GetAsync(String.Format(WebApiCoreUrls.GetLastIndexEmployeesUrl));
            var content = response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : String.Empty;

            var index = JsonConvert.DeserializeObject<int>(content);
            return index;
        }

        //--------------------------------Positions---------------------------------------------------------------

        public async Task<List<Position>> GetAllPositions()
        {
            var response = await _client.GetAsync(String.Format(WebApiCoreUrls.GetAllPositionsUrl));
            var content = response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : String.Empty;

            var positions = JsonConvert.DeserializeObject<List<Position>>(content);
            return positions;
        }

        public async Task AddPosition(Position position)
        {
            var httpContent = new StringContent(JsonConvert.SerializeObject(position), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(WebApiCoreUrls.AddPositionUrl, httpContent);
        }

        public async Task DeletePosition(int id)
        {
            var response = await _client.DeleteAsync(String.Format(WebApiCoreUrls.DeletePositionUrl, id));
        }

        public async Task<int> GetLastIndexPositions()
        {
            var response = await _client.GetAsync(String.Format(WebApiCoreUrls.GetLastIndexPositionsUrl));
            var content = response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : String.Empty;

            var index = JsonConvert.DeserializeObject<int>(content);
            return index;
        }

        //---------------------------------Shops----------------------------------------------------------------

        public async Task<List<Shop>> GetAllShops()
        {
            var response = await _client.GetAsync(String.Format(WebApiCoreUrls.GetAllShopsUrl));
            var content = response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : String.Empty;

            var shops = JsonConvert.DeserializeObject<List<Shop>>(content);
            return shops;
        }

        public async Task AddShop(Shop shop)
        {
            var httpContent = new StringContent(JsonConvert.SerializeObject(shop), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(WebApiCoreUrls.AddShopUrl, httpContent);
        }

        public async Task DeleteShop(int id)
        {
            var response = await _client.DeleteAsync(String.Format(WebApiCoreUrls.DeleteShopUrl, id));
        }

        public async Task<List<Shop>> GetShopsByCity(string city)
        {
            var response = await _client.GetAsync(String.Format(WebApiCoreUrls.GetShopsbyCityUrl, city));
            var content = response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : String.Empty;

            var shops = JsonConvert.DeserializeObject<List<Shop>>(content);
            return shops;
        }

        public async Task<int> GetLastIndexShops()
        {
            var response = await _client.GetAsync(String.Format(WebApiCoreUrls.GetLastIndexShopsUrl));
            var content = response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : String.Empty;

            var index = JsonConvert.DeserializeObject<int>(content);
            return index;
        }

    }
}
