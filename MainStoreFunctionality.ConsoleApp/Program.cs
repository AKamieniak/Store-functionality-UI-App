using MainStoreFunctionality.Models;
using MainStoreFunctionality.WebApiCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainStoreFunctionality.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.Test3();
        }

        public void Test4()
        {
            var client = new WebApiCoreClient();
            var positions = client.GetAllPositions().Result;
            foreach (var item in positions)
            {
                Console.WriteLine(item.PositionName);
            }
            Console.Read();

        }

        public void Test()
        {
            var client = new WebApiCoreClient();
            var a = client.GetEmployeesByShop(2).Result;
            foreach (var item in a)
            {
                Console.WriteLine(item.Name, " ",item.Surname);
            }
            Console.Read();
        }

        public void Test2()
        {
            var client = new WebApiCoreClient();
            var employee = new Employee()
            {
                Id = 7,
                Name = "Asia",
                PositionId = 2,
                ShopId = 1,
                Surname = "Kow"
            };
            client.AddEmployee(employee).Wait();
        }
        public void Test3()
        {
            var client = new WebApiCoreClient();
            client.DeleteEmployee(11).Wait();
        }
    }
}
