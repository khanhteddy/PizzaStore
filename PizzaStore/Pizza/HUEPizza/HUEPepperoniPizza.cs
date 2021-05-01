using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class HUEPepperoniPizza : Pizza
    {
        public HUEPepperoniPizza()
        {
            name = "HUE The best PepperoniPizza";
            dough = "HUE Thick dough";
            sauce = "HUE Sweet sauce";
            toppings.Add("Tomato");
        }
    }
}
