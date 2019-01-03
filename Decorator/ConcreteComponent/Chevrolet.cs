using Decorator.Component;


namespace Decorator.ConcreteComponent
{
    public sealed class Chevrolet : ICar
    {
        public string Engine
        {
           get { return "V8 engine"; }
                
        }

        public double GetPrice()
        {
            return 116000f;
        }
    }
}
