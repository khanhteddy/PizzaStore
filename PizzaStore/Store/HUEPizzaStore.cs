using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Store.Base
{
    public class HUEPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "chesse":
                    return  new HUEChessePizza();
                    
                case "Greek":
                   return new HUEGreekPizza();
                    
                case "Pepperoni":
                   return new HUEPepperoniPizza();
                    
                default:
                    return null;
            }
        }
    }
}
