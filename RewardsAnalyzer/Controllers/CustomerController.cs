using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using RewardsAnalyzer.API.Logging;
using RewardsAnalyzer.API.Model;
using RewardsAnalyzer.Core;

namespace RewardsAnalyzer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        /// <summary>
        /// GetPurchaseRewards : This method is used to get the amount and previous rewards points and calculate the 
        /// total rewards of customer.
        /// </summary>
        /// <param name="spentAmount"></param>
        /// <returns></returns>
        [Route("purchaseRewards")]
        [HttpGet]
        public PurchaseRewards GetPurchaseRewards(float spentAmount)
        {
            var logNLog = new LogNLog();
            try
            {

                logNLog.Information("Calculate rewards methods called");
                if (spentAmount <= 0)
                {
                    return new PurchaseRewards
                    {
                        ErrorDetails = new ErrorDetails
                        {
                            StatusCode = Convert.ToInt32(HttpStatusCode.BadRequest),
                            Message = "Spent amount should be greater then 0"
                        }
                    };
                }

                return new PurchaseRewards
                {
                    AmountSpent = spentAmount,
                    PurchaseDate = DateTime.UtcNow,
                    Rewards = CustomerRewards.CalculateRewards(spentAmount)
                };
            }
            catch (Exception e)
            {
                logNLog.Error(e.Message);
                throw new Exception(e.Message);
            }

        }
    }
}
