using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Wallet
    {
        private double money = 0.92;
        public double Money;

        public Wallet()
        {
            Money = 20.00;
        }

        //For checing balance while making purchases in store --- Will most likely ajust if statement check at a later time
        public void CheckWalletBalance()
        {
            if(Money <= money)
            {
                Console.WriteLine("You do not have enough Money!");
            }
            else
            {
                Console.WriteLine($"You have ${Money} left.");
            }
        }
    }
}
