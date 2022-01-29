using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();

            return type + ", extra cheese";

        }

        public override double GetPrice()
        {
            double price = base.GetPrice();
            return price + 2;
        }

    }
}
