using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Car : ICar
    {
        public string Description { get; set; }
        public int Price { get; set; }

        public Car()
        {
            Description = "Базова модель";
            Price = 10000;
        }

        public string GetDescription()
        {
            return Description;
        }

        public int GetPrice()
        {
            return Price;
        }
    }
}
