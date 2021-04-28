using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class PizzaStore
    {
        public void OrderPizza( string type)
        {
            Pizza pizza;
            switch (type)
            {
                case "chesse":
                    pizza = new ChessePizza();
                    break;
                case "Greek":
                    pizza = new GreekPizza();
                    break;
                case "Pepperoni":
                    pizza = new PepperoniPizza();
                    break;
                default:
                    Console.WriteLine("We do not have" + type + "pizza");
                    return;
            }
               
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();

            
        }
    }
}
