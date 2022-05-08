using NUnit.Framework;
using RewardsAnalyzer.API.Controllers;

namespace RewardsAnalyzer.IntegrationTest
{
    public class CustomerRewardsIntegrationTest
    {

        /// <summary>
        /// GetPurchaseRewards_ShouldReturnRewards : Valid data should return rewards amount
        /// </summary>
        [Test]

        public void GetPurchaseRewards_ShouldReturnRewards()
        {
            // Arrange
            var customerController = new CustomerController();
            const float spentAmount = 120;

            // Act
            var response = customerController.GetPurchaseRewards(spentAmount);

            // Assert
            Assert.AreEqual(120, response.AmountSpent);
            Assert.AreEqual(90, response.Rewards);
        }

        /// <summary>
        /// GetPurchaseRewards_ShouldReturnError : Invalid data should return rewards amount
        /// </summary>
        [Test]
        public void GetPurchaseRewards_ShouldReturnError()
        {
            // Arrange
            var customerController = new CustomerController();
            const float spentAmount = 0;

            // Act
            var response = customerController.GetPurchaseRewards(spentAmount);

            // Assert
            Assert.AreEqual(400, response.ErrorDetails.StatusCode);
        }
    }
}