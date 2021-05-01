using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class HCMPepperoniPizza : Pizza
    {
        public HCMPepperoniPizza()
        {
            name = "HCM The best PepperoniPizza";
            dough = "HCM Thick dough";
            sauce = "HCM Sweet sauce";
            toppings.Add("Tomato");
        }
    }
}
