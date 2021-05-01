 using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore 
{
    class HCMChessePizza : Pizza
    {
        public HCMChessePizza()
        {
            name = "HCM The best chesse pizza";
            dough = "HCM Verry thin dough";
            sauce = "HCM Verry spicy sauce";
            toppings.Add("Black olives");
            toppings.Add("Chesse");
        }
    }
}
