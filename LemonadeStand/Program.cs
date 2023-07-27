﻿namespace LemonadeStand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Store store = new Store();

            Console.WriteLine("Welcome to Kyle's Lemonade Stand" );
            Console.WriteLine();


            Weather weather = new Weather();

            weather.GenereateForecase();
            weather.DisplayForecast();
            Console.WriteLine();

            while (true)
            {
                player.DisplayStatus();
                player.DisplayOptions();
                

                int choice = UserInterface.GetNumberOfItems("Enter your choice: ");

                switch (choice)
                {

                    case 1: store.SellLemons(player); 
                    break;

                    case 2: store.SellSugarCubes(player); 
                    break;

                    case 3: store.SellIceCubes(player);
                    break;

                    case 4: store.SellCups(player);
                    break;

                    

                    default: Console.WriteLine("Not a valid choice. Please select a valid choice.");
                    break;
                }
            }
            
           
        }
    }
}