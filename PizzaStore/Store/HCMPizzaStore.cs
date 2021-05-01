using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Store
{
    public class HCMPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "chesse":
                    return new HCMChessePizza();

                case "Greek":
                    return new HCMGreekPizza();

                case "Pepperoni":
                    return new HCMPepperoniPizza();

                default:
                    return null;
            }
        }
    }
}
