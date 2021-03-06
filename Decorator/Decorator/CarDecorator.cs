﻿using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
   public abstract class CarDecorator: ICar
    {
        private ICar car;
        public CarDecorator(ICar Car)
        {
            car = Car;
        }

        public string Engine { get { return car.Engine; } }

        public double GetPrice()
        {
            return car.GetPrice();
        }
        public abstract bool IsSuperChardged();
    }
}
