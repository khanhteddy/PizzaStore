using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class HUEGreekPizza : Pizza
    {
        public HUEGreekPizza()
        {
            name = "HUE A good pizza";
            dough = "HUE Thin dough";
            sauce = "HUE Chilli sauce";
            toppings.Add("Tomato");
            toppings.Add("Potato"); 
        }
    }
}
