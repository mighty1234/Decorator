using Decorator.Component;


namespace Decorator.ConcreteComponent
{
    public  sealed class Subaru : ICar
    {
        public string Engine
        {
            get { return "Boxer engine"; }
        }

        public double GetPrice()
        {
            return 800000f;
        }
    }
}
