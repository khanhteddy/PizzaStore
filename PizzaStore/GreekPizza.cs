using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class GreekPizza : Pizza
    {
        public GreekPizza()
        {
            name = "A good pizza";
            dough = "Thin dough";
            sauce = "Chilli sauce";
            toppings.Add("Tomato");
            toppings.Add("Potato"); 
        }
    }
}
