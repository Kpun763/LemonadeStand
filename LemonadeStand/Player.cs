﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public double LemonadePrice;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            LemonadePrice = 0.50;
        }

        // member methods (CAN DO)
        public void DisplayStatus()
        {
            Console.WriteLine("Player Inventory Status:");
            Console.WriteLine($"Money: ${wallet.Money:F2}");
            Console.WriteLine($"Lemons: {inventory.lemons.Count}");
            Console.WriteLine($"Sugar Cubes: {inventory.sugarCubes.Count}");
            Console.WriteLine($"Ice Cubes: {inventory.iceCubes.Count}");
            Console.WriteLine($"Cups: {inventory.cups.Count}");
            Console.WriteLine();

        }
        public void DisplayOptions()
        {
            Console.WriteLine("Select Options");
            Console.WriteLine();
            Console.WriteLine("1. Go to store to buy lemons");
            Console.WriteLine("2. Go to store to buy sugare cubes");
            Console.WriteLine("3. Go to store to buy ice cubes");
            Console.WriteLine("4. Go to store to buy cups");

        }
    }
}
