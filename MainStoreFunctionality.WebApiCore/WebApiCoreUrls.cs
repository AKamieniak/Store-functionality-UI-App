using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainStoreFunctionality.WebApiCore
{
    public abstract class WebApiCoreUrls
    {
        //---------------------------URLs---------------------------

        //---employees---
        public static string GetEmployeesbyShopUrl = "http://localhost:49806/api/get-by-shop-id/{0}";
        public static string AddEmployeeUrl = "http://localhost:49806/api/employees/add";
        public static string DeleteEmployeeUrl = "http://localhost:49806/api/employees/delete/{0}";
        public static string GetLastIndexEmployeesUrl = "http://localhost:49806/api/employees/get-last-index";

        //---positions---
        public static string GetAllPositionsUrl = "http://localhost:49806/api/positions/get-all";
        public static string AddPositionUrl = "http://localhost:49806/api/positions/add";
        public static string DeletePositionUrl = "http://localhost:49806/api/positions/delete/{0}";
        public static string GetLastIndexPositionsUrl = "http://localhost:49806/api/positions/get-last-index";

        //---shops---
        public static string GetAllShopsUrl = "http://localhost:49806/api/shops/get-all";
        public static string AddShopUrl = "http://localhost:49806/api/shops/add";
        public static string DeleteShopUrl = "http://localhost:49806/api/shops/delete/{0}";
        public static string GetShopsbyCityUrl = "http://localhost:49806/api/shops/get-by-city/{city}";
        public static string GetLastIndexShopsUrl = "http://localhost:49806/api/shops/get-last-index";
    }
}
