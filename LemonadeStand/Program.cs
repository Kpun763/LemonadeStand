using System.ComponentModel.Design;

namespace LemonadeStand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Store store = new Store();

            Weather weatherForecast = new Weather();

          

            Console.WriteLine("Welcome to Kyle's Lemonade Stand");
            Console.WriteLine();

            
            Random random = new Random();
            

            int currentDay = 1;
            int totalDays = 7;

            List<Customer> customers = Customer.GenerateCustomers(3, random);

            while (currentDay <= totalDays)
            {

                Console.WriteLine($"... Day {currentDay} ...");

                weatherForecast.GenerateForecast();

                weatherForecast.DisplayForecast();

                Console.WriteLine($"Here is the forecast for today: {weatherForecast.WeatherCondition}, {weatherForecast.Temperature}{(char)176}F");

                int demand = store.CalculateDemand(player.LemonadePrice, weatherForecast);
                player.LemonadePrice = store.PriceAdjustBasedOnDemand(player.LemonadePrice, demand);
                Console.WriteLine($"The current price per cup: ${player.LemonadePrice:F2}");

                player.DisplayStatus();
                player.DisplayOptions();

                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    store.SellLemons(player);
                } 

                else if (option == 2)
                {
                    store.SellSugarCubes(player);
                }

                else if (option == 3)
                {
                    store.SellIceCubes(player);
                }

                else if (option == 4)
                {
                    store.SellCups(player);
                }

                else if (option == 5)
                {
              
                    if (UserInterface.AskYesNo("Do you want to begin selling lemonade? (y/n)"))
                    {
                        int pitchersToMake = UserInterface.GetNumberOfPitchers();
                        double lemonadePrice = UserInterface.GetPricePerCup();

                        for (int i=0; i < pitchersToMake; i++)
                        {
                            int cupsInPitcher = 8;

                            if (player.inventory.lemons.Count >= cupsInPitcher && 
                                player.inventory.sugarCubes.Count >= cupsInPitcher && 
                                player.inventory.iceCubes.Count >= cupsInPitcher && 
                                player.inventory.cups.Count >= cupsInPitcher)
                            {
                                player.inventory.RemoveLemons(cupsInPitcher);
                                player.inventory.RemoveSugarCubes(cupsInPitcher);
                                player.inventory.RemoveIceCubes(cupsInPitcher);
                                player.inventory.RemoveCups(cupsInPitcher);

                                player.PitchersMade++;
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough items to make a pitcher of lemonade.");
                                break;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option. Please select a valid option.");
                }

                double moneyEarned = 0.0;

                foreach (Customer customer in customers)
                {
                    if (customer.WillBuyLemonade(player.LemonadePrice))
                    {
                        int cupsBought = random.Next(1, customer.MaxBuyingAmount + 1);
                        double transactionAmount = cupsBought * player.LemonadePrice;

                        if (cupsBought <= player.inventory.cups.Count)
                        {
                            player.inventory.RemoveCups(cupsBought);
                            player.wallet.PayMoneyForItems(transactionAmount);
                            Console.WriteLine($"Customer bought {cupsBought} cups of lemonade for ${transactionAmount:F2}");
                            moneyEarned += transactionAmount;
                        }

                        else
                        {
                            Console.WriteLine("You do not have enough cups to complete this customers order.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Customer did not buy any lemonade");
                    }
                
                    
                }
                Console.WriteLine($"Daily profit or loss: ${moneyEarned:F2}");

                if (!UserInterface.AskYesNo("Do you want to continue shopping for items? (y/n:)")) 
                {
                    Console.WriteLine("Okay. Thanks for shopping!");
                    Console.WriteLine("Lets set the lemonade prices.");

                    //Setting price for lemonade
                    Console.WriteLine("Enter the price for a cup of lemonade:");
               
                }

                currentDay++;

            }

            Console.WriteLine("That is the end of the game.");




        }
    }
}