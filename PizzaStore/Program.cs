using PizzaStore.Store;
using PizzaStore.Store.Base;
using System;
using System.Collections.Generic;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var HUEpizzaStore = new HUEPizzaStore();
            HUEpizzaStore.OrderPizza("chesse");
            var BLpizzaStore = new BLPizzaStore();
            BLpizzaStore.OrderPizza("chesse");

        }
    }
}
