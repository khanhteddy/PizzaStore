using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            name = "The best PepperoniPizza";
            dough = "Thick dough";
            sauce = "Sweet sauce";
            toppings.Add("Tomato");
        }
    }
}
