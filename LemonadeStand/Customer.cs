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

        public void BuyingBehavior(double buyingChance, int maxBuyingAmount)
        {
            BuyingChance = buyingChance;
            MaxBuyingAmount = maxBuyingAmount;
        }
    }
}
