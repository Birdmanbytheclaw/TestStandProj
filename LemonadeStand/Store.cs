using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LemonadeStand
{
    public class Store
    {
        Player player;
        private double pricePerLemon;
        static double lemonsPurchased;

        private double pricePerSugarCube;
        static double SugarCubesPurchased;

        private double pricePerIceCube;
        static double IceCubesPurchased;

        private double pricePerCup;
        static double CupsPurchased;
        public double pitcherForGame;

        public double price;
        public int countPitchersMade = 0;

        //Inventory inventory = new Inventory();

        public Store(Player player)
        {
           this.player = player;
        }


        public void StoreMenu()
        {
            bool buyProduct;
            int num = 0;
            while (num != 5)
            {
                Console.WriteLine("Lemonade Stand Store");
                player.wallet.CheckWalletBalance();
                Console.WriteLine(player.inventory.lemons.Count() + " lemons.       Press 1 to buy more Lemons.");
                Console.WriteLine(player.inventory.sugarCubes.Count() + " Sugar Cubes.  Press 2 to buy more Sugar Cubes.");
                Console.WriteLine(player.inventory.iceCubes.Count() + " Ice Cubes.    Press 3 to buy more Ice Cubes.");
                Console.WriteLine(player.inventory.cups.Count() + " Cups.         Press 4 to buy more Cups");
                Console.WriteLine("!Press 5 to leave the store!");
                buyProduct = int.TryParse(Console.ReadLine(), out num);

                if (num == 1)
                {
                    BuyLemons();
                }
                else if (num == 2)
                {
                    BuySugarCubes();
                }
                else if (num == 3)
                {
                    BuyIceCubes();
                }
                else if (num == 4)
                {
                    BuyCups();
                }
                else if(num == 5)
                {
                    Console.WriteLine("Exit Store");
                }
                else
                {
                    Console.WriteLine("Invalid: Make a new selection or Press 5 to exit store!");
                }
            }
        }
        public void BuyLemons()
        {
            bool buyItem;
            Console.WriteLine("Number of lemons to buy. Enter 10, 30 or 75: ");
            Console.WriteLine("10 for $0.76");
            Console.WriteLine("30 for $2.08");
            Console.WriteLine("75 for $4.17");
            buyItem = double.TryParse(Console.ReadLine(), out lemonsPurchased);
            if (lemonsPurchased == 10)
            {
                pricePerLemon = .76;
                player.wallet.Money -= pricePerLemon;
                for(int i = 0; i < lemonsPurchased; i++)
                {
                    player.inventory.AddLemonToLemonsList();
                }
            }
            else if(lemonsPurchased == 30)
            {
                pricePerLemon = 2.08;
                player.wallet.Money -= pricePerLemon;
                for (int i = 0; i < lemonsPurchased; i++)
                {
                    player.inventory.AddLemonToLemonsList();
                }
            }
            else if(lemonsPurchased == 75)
            {
                pricePerLemon = 4.17;
                player.wallet.Money -= pricePerLemon;
                for (int i = 0; i < lemonsPurchased; i++)
                {
                    player.inventory.AddLemonToLemonsList();
                }
            }
            else
            {
                Console.WriteLine("Invalid selection");
            }
            Console.Clear();
        }

        public void BuySugarCubes()
        {
            bool buyItem;
            Console.WriteLine("Number of Sugar Cubes to buy. Enter 8, 20 or 40: ");
            Console.WriteLine("8 for $0.53");
            Console.WriteLine("20 for $1.64");
            Console.WriteLine("40 for $3.28");
            buyItem = double.TryParse(Console.ReadLine(), out SugarCubesPurchased);
            if (SugarCubesPurchased == 8)
            {
                pricePerSugarCube = .53;
                player.wallet.Money -= pricePerSugarCube;
                for(int i = 0; i < SugarCubesPurchased; i++)
                {
                    player.inventory.AddSugarCubeToSugarCubesList();
                }
            }
            else if(SugarCubesPurchased == 20)
            {
                pricePerSugarCube = 1.64;
                player.wallet.Money -= pricePerSugarCube;
                for (int i = 0; i < SugarCubesPurchased; i++)
                {
                    player.inventory.AddSugarCubeToSugarCubesList();
                }
            }
            else if(SugarCubesPurchased == 40)
            {
                pricePerSugarCube = 3.28;
                player.wallet.Money -= pricePerSugarCube;
                for (int i = 0; i < SugarCubesPurchased; i++)
                {
                    player.inventory.AddSugarCubeToSugarCubesList();
                }
            }
            else
            {
                Console.WriteLine("Invalid selection");
            }
            Console.Clear();
        }

        public void BuyIceCubes()
        {
            bool buyItem;
            Console.WriteLine("Number of Ice Cubes to buy. Enter 40, 60 or 100: ");
            Console.WriteLine("40 for $0.97");
            Console.WriteLine("60 for $2.15");
            Console.WriteLine("100 for $3.60");
            buyItem = double.TryParse(Console.ReadLine(), out IceCubesPurchased);
            if (IceCubesPurchased == 40)
            {
                pricePerIceCube = .92;
                player.wallet.Money -= pricePerIceCube;
                for(int i = 0; i < IceCubesPurchased; i++)
                {
                    player.inventory.AddIceCubesToIceCubesList();
                }
            }
            else if(IceCubesPurchased == 60)
            {
                pricePerIceCube = 2.15;
                player.wallet.Money -= pricePerIceCube;
                for (int i = 0; i < IceCubesPurchased; i++)
                {
                    player.inventory.AddIceCubesToIceCubesList();
                }
            }
            else if(IceCubesPurchased == 100)
            {
                pricePerIceCube = 3.60;
                player.wallet.Money -= pricePerIceCube;
                for (int i = 0; i < IceCubesPurchased; i++)
                {
                    player.inventory.AddIceCubesToIceCubesList();
                }
            }
            else
            {
                Console.WriteLine("Invalid selection");
            }
            Console.Clear();
        }

        public void BuyCups()
        {
            bool buyItem;
            Console.WriteLine("Number of Cups to buy. Enter 25, 50 or 100: ");
            Console.WriteLine("25 for $0.97");
            Console.WriteLine("50 for $1.69");
            Console.WriteLine("100 for $3.09");
            buyItem = double.TryParse(Console.ReadLine(), out CupsPurchased);
            if (CupsPurchased == 25)
            {
                pricePerCup = .97;
                player.wallet.Money -= pricePerCup;
                for(int i = 0; i < CupsPurchased; i++)
                {
                    player.inventory.AddCupToCupsList();
                }
            }
            else if(CupsPurchased == 50)
            {
                pricePerCup = 1.69;
                player.wallet.Money -= pricePerCup;
                for (int i = 0; i < CupsPurchased; i++)
                {
                    player.inventory.AddCupToCupsList();
                }
            }
            else if(CupsPurchased == 100)
            {
                pricePerCup = 3.09;
                player.wallet.Money -= pricePerCup;
                for (int i = 0; i < CupsPurchased; i++)
                {
                    player.inventory.AddCupToCupsList();
                }
            }
            else
            {
                Console.WriteLine("Invalid selection");
            }
            Console.Clear();
        }

        public void ShowProfit()
        {
            Console.WriteLine("          GAME OVER!                      ");
            Console.WriteLine("You made $" + player.wallet.Money + " over seven days.");

        }

        //Recipe for Pitcher, Items it takes to make a Pitcher and remove those Items from Inventory when used to make a Pitcher
        public void MakePitcher()
        {
            string makePitcherResponse = UserInterface.MakePitcherPrompt();
            if (makePitcherResponse == "yes")
            {
                int PitchersToBeMade = UserInterface.NumberOfPitchersToMake();
                while (countPitchersMade < PitchersToBeMade)
                {
                    if ((player.inventory.lemons.Count >= player.recipe.amountOfLemons) && (player.inventory.sugarCubes.Count >= player.recipe.amountOfSugarCubes) && (player.inventory.iceCubes.Count >= player.recipe.amountOfIceCubes))
                    {
                        
                            player.inventory.lemons.RemoveRange(0, player.recipe.amountOfLemons);
                        
                            player.inventory.sugarCubes.RemoveRange(0, player.recipe.amountOfSugarCubes);                     

                            player.inventory.iceCubes.RemoveRange(0, player.recipe.amountOfIceCubes);

                        countPitchersMade++;
                        pitcherForGame++;
                        //might need to add count for pitcher or cups of lemonade
                    }
                }
            }
            else
            {
                Console.WriteLine("You do not have enough product!");
            }

        }

    }

    
}
    
