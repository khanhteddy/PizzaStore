using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    {
        protected string name;
        protected string dough;
        protected string sauce;

        public void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough ...");
            Console.WriteLine("Adding sauce ...");
            Console.WriteLine("Adding toppings: ");
            toppings?.ForEach(
                (topping) => Console.WriteLine("\t" + topping));
        }
        public void Bake()
        {

        }
        public void Cut()
        {
        }
        public void Box()
        {
            Console.WriteLine("Boxing " + name);
        }
    }
}
