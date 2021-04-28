 using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore 
{
    class ChessePizza : Pizza
    {
        public ChessePizza()
        {
            name = "The best chesse pizza";
            dough = "Verry thin dough";
            sauce = "Verry spicy sauce";
            toppings.Add("Black olives");
            toppings.Add("Chesse");
        }
    }
}
