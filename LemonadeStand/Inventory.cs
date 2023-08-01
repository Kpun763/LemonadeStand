using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        // member variables (HAS A)
        public List<Lemon> lemons;
        public List<SugarCube> sugarCubes;
        public List<IceCube> iceCubes;
        public List<Cup> cups;

        // constructor (SPAWNER)
        public Inventory()
        {
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
            AddLemonsToInventory(25);
            AddSugarCubesToInventory(125);
            AddIceCubesToInventory(100);
            AddCupsToInventory(35);
        }

        // member methods (CAN DO)
        public void AddLemonsToInventory(int numberOfLemons)
        {
            for(int i = 0; i < numberOfLemons; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
        }

        public void AddSugarCubesToInventory(int numberOfSugarCubes)
        {
            for(int i = 0; i < numberOfSugarCubes; i++)
            {
                SugarCube sugarCube = new SugarCube();
                sugarCubes.Add(sugarCube);
            }
        }

        public void AddIceCubesToInventory(int numberOfIceCubes)
        {
            for(int i = 0; i < numberOfIceCubes; i++)
            {
                IceCube iceCube = new IceCube();
                iceCubes.Add(iceCube);
            }
        }

        public void AddCupsToInventory(int numberOfCups)
        {
            for(int i = 0; i < numberOfCups; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
        }

        public void RemoveLemons(int count)
        {
            if (lemons.Count >= count)
            {
                lemons.RemoveRange(0, count);
            }
            else
            {
                Console.WriteLine("Not enough lemons in your inventory.");
            }
        }

        public void RemoveSugarCubes(int count)
        {
            if (sugarCubes.Count >= count)
            {
                sugarCubes.RemoveRange(0, count);
            }
            else
            {
                Console.WriteLine("Not enough sugar cubes in your inventory.");
            }
        }

        public void RemoveIceCubes(int count)
        {
            if (iceCubes.Count >= count)
            {
                iceCubes.RemoveRange(0,count);
            }
            else
            {
                Console.WriteLine("Not enough ice cubes in your inventory.");
            }
        }

        public void RemoveCups(int count)
        {
            if (cups.Count >= count)
            {
                cups.RemoveRange(0, count);
            }
            else
            {
                Console.WriteLine("Not enough cups in your inventory.");
            }
        }
    }
}
