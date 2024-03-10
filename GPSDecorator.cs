using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class GPSDecorator : Decorator
    {
        public GPSDecorator(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " з GPS";
        }

        public override int GetPrice()
        {
            return base.GetPrice() + 500;
        }
    }
}

