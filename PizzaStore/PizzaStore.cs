using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class PizzaStore 
    {
        public void OederPizza()
        {

            var pizza = new ChessePizza();
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();

            
        }
    }
}
