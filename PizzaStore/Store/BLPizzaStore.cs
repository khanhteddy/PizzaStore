using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Store
{
    public class BLPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "chesse":
                    return new BLChessePizza();

                case "Greek":
                    return new BLGreekPizza();

                case "Pepperoni":
                    return new BLPepperoniPizza();

                default:
                    return null;
            }
        }
    }
}
