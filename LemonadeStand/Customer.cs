using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {
        public double BuyingChance { get; set; }
        public int MaxBuyingAmount { get; set; }

        public Customer(double buyingChance, int maxBuyingAmount)
        {
            BuyingChance = buyingChance;
            MaxBuyingAmount = maxBuyingAmount;
            
        }

        public static List<Customer> GenerateCustomers(int numberOfCustomers, Random random)
        {
            List<Customer> customers = new List<Customer>();

            
            for(int i = 0; i < numberOfCustomers; i++)
            {
                double buyingChance = random.NextDouble();
                int maxBuyingAmount = random.Next(1, 5);

                Customer customer = new Customer(buyingChance, maxBuyingAmount);
                customers.Add(customer);
            }
            return customers;
        }

        public bool WillBuyLemonade(double lemonadePrice)
        {
            Random random = new Random();
            double randomNumber = random.NextDouble();

            if (randomNumber < BuyingChance)
            {
                int quantity = random.Next(1, MaxBuyingAmount + 1);
                Console.WriteLine($"Customer bought {quantity} cups of lemonade for ${quantity * lemonadePrice:F2}");
                return true;
            }
            else
            {
                Console.WriteLine("Customer did not buy lemonade");
                return false;   
            }
        }
    }
}
