 using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore 
{
    class HUEChessePizza : Pizza
    {
        public HUEChessePizza()
        {
            name = "HUE The best chesse pizza";
            dough = "HUE Verry thin dough";
            sauce = "HUE Verry spicy sauce";
            toppings.Add("Black olives");
            toppings.Add("Chesse");
        }
    }
}
