using MainStoreFunctionality.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MainStoreFunctionality.WebApiCore
{
    public interface IWebApiCoreClient
    {
        //---employees---
        Task<List<Employee>> GetAllEmployees(int shopId);
        Task AddEmployee(Employee employee);
        Task DeleteEmployee(int id);
        Task<int> GetLastIndexEmployees();

        //---positions---
        Task<List<Position>> GetAllPositions();
        Task DeletePosition(int id);
        Task AddPosition(Position position);
        Task<int> GetLastIndexPositions();

        //---shops---
        Task<List<Shop>> GetAllShops();
        Task AddShop(Shop shop);
        Task DeleteShop(int id);
        Task<List<Shop>> GetShopsByCity(string city);
        Task<int> GetLastIndexShops();
    }
}