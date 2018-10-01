using MainStoreFunctionality.WebApiCore;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainStoreFunctionality
{
    public class Bootstrapper
    {
        public static Container container;

        public void CreateContainer()
        {
            container = new Container(x =>
            {
                x.For<IWebApiCoreClient>().Use<WebApiCoreClient>();
            });
        }

        public static void Bootstrap()
        {
            new Bootstrapper().CreateContainer();

        }
     

    }
}
