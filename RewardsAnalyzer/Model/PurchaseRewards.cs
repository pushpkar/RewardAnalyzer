using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RewardsAnalyzer.API.Logging;

namespace RewardsAnalyzer.API.Model
{
    /// <summary>
    /// PurchaseRewards : This class contains the information of earned rewards by customer on every purchase 
    /// </summary>
    public class PurchaseRewards
    {
        // Earned rewards on every purchase
        public float Rewards { get; set; }

        // Date of the purchase
        public DateTime PurchaseDate { get; set; }

        //AmountSpent per order
        public float AmountSpent { get; set; }

        public ErrorDetails ErrorDetails { get; set; }
    }
}
