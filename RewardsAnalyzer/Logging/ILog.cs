namespace RewardsAnalyzer.API.Logging
{
    /// <summary>
    /// ILog : interface contains the all signature of log
    /// </summary>
    public interface ILog
    {
        void Information(string message);
        void Warning(string message);
        void Debug(string message);
        void Error(string message);
    }
}
