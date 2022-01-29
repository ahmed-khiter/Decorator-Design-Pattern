using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class OnionDecorator : PizzaDecorator
    {
        public OnionDecorator(IPizza pizza) : base(pizza) { }


        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();

            return type + ", extra Onion";

        }

        public override double GetPrice()
        {
            double price = base.GetPrice();
            return price + 1;
        }


    }
}
