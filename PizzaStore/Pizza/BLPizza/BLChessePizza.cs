 using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore 
{
    class BLChessePizza : Pizza
    {
        public BLChessePizza()
        {
            name = "HCM The best chesse pizza";
            dough = "HCM Verry thin dough";
            sauce = "HCM Verry spicy sauce";
            toppings.Add("Black olives");
            toppings.Add("Chesse");
        }
    }
}
