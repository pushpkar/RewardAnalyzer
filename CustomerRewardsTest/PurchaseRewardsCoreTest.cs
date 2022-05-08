using NUnit.Framework;
using RewardsAnalyzer.Core;

namespace RewardsAnalyzer.CoreTest
{
    [TestFixture]
    public class CustomerRewardsCoreTest
    {
        [Test]
        public void CalculateRewards_SpentAmountLessThen50_ShouldReturnRewards()
        {
            Assert.AreEqual(0, CustomerRewards.CalculateRewards(49));
        }
        [Test]
        public void CalculateRewards_SpentAmountBetween50To99_ShouldReturnRewards()
        {
            Assert.AreEqual(49, CustomerRewards.CalculateRewards(99));
        }

        [Test]
        public void CalculateRewards_SpentAmountGreaterThen100_ShouldReturnRewards()
        {
            Assert.AreEqual(90, CustomerRewards.CalculateRewards(120));
        }
    }
}