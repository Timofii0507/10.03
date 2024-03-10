using FacadePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Proxy : IResource
    {
        private Facade2 _facade;

        public Proxy()
        {
            _facade = new Facade2();
        }

        public string GetData()
        {
            Console.WriteLine("Proxy: GetData");
            return _facade.GetData();
        }
    }
}
