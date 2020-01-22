using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LemonadeStand
{
    public static class UserInterface
    {
        public static string name;
        public static int PitchersToBeMade;

        public static string Name { get { return name; } set { name = value; } }

        public static void Greeting()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
            Console.WriteLine("Attempt to sell as many cups of lemonade as possible in 7 days.");
        }

        public static void SetPlayerName()
        {
            Console.Write("Enter a name for your player: ");
            name = Console.ReadLine();     
        }

        public static void PitcherRecipe()
        {
            Console.WriteLine("8 Lemons, 12 Sugar Cubes, 4 Ice Cubes, eqaul 1 Pitcher.");
        }

        public static string MakePitcherPrompt()
        {
            Console.WriteLine("Would you like to make a pitcher of lemonade?");
            Console.WriteLine("Type yes to make pitcher or no to continue");
            string makePitcherResponse = Console.ReadLine();

            return makePitcherResponse;
        }

        public static int NumberOfPitchersToMake()
        {
            bool test;
            Console.WriteLine("How many pitchers would you like to make?");
            test = int.TryParse(Console.ReadLine(), out PitchersToBeMade);
            return PitchersToBeMade;
        }

        public static void StartNextDay()
        {
            Console.WriteLine("Business day has ended. Press enter to continue");
            Console.ReadLine();
        }
    }
}
