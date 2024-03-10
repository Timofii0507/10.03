using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Facade2 : IResource
    {
        private RealResource _realResource;

        public Facade2()
        {
            _realResource = new RealResource();
        }

        public string GetData()
        {
            Console.WriteLine("Facade: GetData");
            return _realResource.GetData();
        }
    }
}
