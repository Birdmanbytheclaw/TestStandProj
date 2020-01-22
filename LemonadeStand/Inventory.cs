using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LemonadeStand
{
    public class Inventory
    {
        public List<Lemon> lemons;
        public List<SugarCube> sugarCubes;
        public List<IceCube> iceCubes;
        public List<Cup> cups;
        Recipe recipeForPitcher = new Recipe();

        public Inventory()
        {
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
        }

        public void ClearInventory()
        {
            lemons.Clear();
            sugarCubes.Clear();
            iceCubes.Clear();
            cups.Clear();
        }

        public void AddLemonToLemonsList()
        {
            lemons.Add(new Lemon());
        }

        public void AddSugarCubeToSugarCubesList()
        {
            sugarCubes.Add(new SugarCube());
        }

        public void AddIceCubesToIceCubesList()
        {
            iceCubes.Add(new IceCube());
        }

        public void AddCupToCupsList()
        {
            cups.Add(new Cup());
        }



    }


}


