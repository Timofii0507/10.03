using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class AirConditioningDecorator : Decorator
    {
        public AirConditioningDecorator(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " з кондиціонером";
        }

        public override int GetPrice()
        {
            return base.GetPrice() + 1000;
        }
    }
}

