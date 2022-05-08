using System.Text.Json;

namespace RewardsAnalyzer.API.Logging
{
    /// <summary>
    /// ErrorDetails : This class used to hold the error details
    /// </summary>
    public class ErrorDetails
    {
        // Error status code
        public int StatusCode { get; set; }

        // Error message
        public string Message { get; set; }

        // Overriding error object into json string
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
