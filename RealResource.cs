using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class RealResource : IResource
    {
        public string GetData()
        {
            Console.WriteLine("RealResource: GetData");
            return "Це дані з реального ресурсу";
        }
    }
}

