using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Chevrolet();
            CarDecorator decorator = new OfferPrice(car);
            Console.WriteLine(string.Format("Engine :{0} IsSuperChardged :{1}  Price :{2}", decorator.Engine,decorator.IsSuperChardged.ToString(),decorator.GetPrice().ToString()));
        }
    }
}
