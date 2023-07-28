using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterface
    {
        public static int GetNumberOfItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }

        public static int GetNumberOfPitchers()
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("Each pitcher pours 8 cups. How many pitchers would you like to make?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }

        public static bool AskYesNo(string promt)
        {
            while (true)
            {
                Console.WriteLine(promt);
                string response = Console.ReadLine().Trim().ToLower();

                if (response == "y" || response == "yes")
                    return true;
                else if (response == "n" || response == "no")
                    return false;
                Console.WriteLine("Not a valid response. Please enter 'y' for Yes or 'n' for No.");
            }
        }

        public static double GetPricePerCup()
        {
            bool validInput = false;
            double pricePerCup = -1 ; //Used a negative so the price of the lemonade could also be something like .75

            while (!validInput)
            {
                Console.WriteLine("Please enter the price for each cup of lemonade (dollars):");
                if (Double.TryParse(Console.ReadLine(),out pricePerCup))
                {
                    if (pricePerCup >= 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid Input. Please use a positive number to set the price.");
                    }
                }
              
            }
            return pricePerCup;


        }  

    }
}
