using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Lemon : Item
    {
        //Liskov substitution principle (Item-Lemon)
        public Lemon()
        {
            name = "Lemon";
        }
    }
}
