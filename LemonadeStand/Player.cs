using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Player
    {
        public static string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe ;
        public Pitcher pitcher;

        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
        }

    }
}
