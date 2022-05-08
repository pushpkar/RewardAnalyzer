namespace RewardsAnalyzer.Core
{
    /// <summary>
    /// CustomerRewards : This class is used to call the CalculateRewards method with will return 
    /// total rewards of the customer
    /// </summary>
    public static class CustomerRewards
    {
        /// <summary>
        /// CalculateRewards : This method is used to calculate the customer rewards based on amount spent
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static int CalculateRewards(float amount)
        {
            return amount switch
            {
                >= 50 and < 100 => (int)(1 * (amount - 50)),
                > 100 => (int)(1 * (amount - 100) + 1 * (amount - 50)),
                _ => 0
            };
        }

    }


}
