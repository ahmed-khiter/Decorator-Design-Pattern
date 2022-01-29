using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decorator Design pattern 
            //Why used it to solved the problem of extending a class functionality without adding concrete changes to the classes structure.
            
            
            //Normal Pizza
            IPizza pizza = new Pizza();
            Console.WriteLine(pizza.GetPizzaType());
            Console.WriteLine("Price: " +pizza.GetPrice() + " $");
            Console.WriteLine();

            //Extra Cheese 
            IPizza extraCheese = new CheeseDecorator(pizza);
            Console.WriteLine(extraCheese.GetPizzaType());
            Console.WriteLine("Price: " +  extraCheese.GetPrice() + " $");
            Console.WriteLine();

            //Extra Cheese with Extra Tomatom
            IPizza extraOnionWithExtraCheese = new OnionDecorator( extraCheese);
            Console.WriteLine(extraOnionWithExtraCheese.GetPizzaType());
            Console.WriteLine("Price: " + extraOnionWithExtraCheese.GetPrice() + " $");
            Console.WriteLine();

            //Extra Cheese & extra onion & Extra Tomatom 
            IPizza extraTomatom = new TomatoDecorator(extraOnionWithExtraCheese);
            Console.WriteLine(extraTomatom.GetPizzaType());
            Console.WriteLine("Price: " + extraTomatom.GetPrice()+ " $");
            Console.WriteLine();

            Console.ReadLine();

        }


        // 4 steps to implement the Decorator design pattern  : 
        /*
        1- base interface
        2- concerete implement 
        3- base decorators
        4- concrete decorators
        */

        //1-  base interface >>> IPizza


        //2- concerete implement >>> Pizza


        //3- base decorators >>>> PizzaDecorator


        //4- concrete decorators  >>>> CheeseDecorator , TomatoDecorator , OnionDecorator


       

       


    }
}
