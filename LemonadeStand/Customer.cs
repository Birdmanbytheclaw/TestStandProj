using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Customer
    {
        public string name;
        public double chanceBuy;


        public Customer(string name, double chanceBuy)
        {
            this.name = name;
            this.chanceBuy = chanceBuy;
        }
    }
}
