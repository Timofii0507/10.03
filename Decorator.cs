using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Decorator : ICar
    {
        protected ICar _car;

        public Decorator(ICar car)
        {
            _car = car;
        }

        public virtual string GetDescription()
        {
            return _car.GetDescription();
        }

        public virtual int GetPrice()
        {
            return _car.GetPrice();
        }
    }
}

