using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class HCMGreekPizza : Pizza
    {
        public HCMGreekPizza()
        {
            name = "HCM A good pizza";
            dough = "HCM Thin dough";
            sauce = "HCM Chilli sauce";
            toppings.Add("Tomato");
            toppings.Add("Potato"); 
        }
    }
}
