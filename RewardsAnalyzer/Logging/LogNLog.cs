using NLog;

namespace RewardsAnalyzer.API.Logging
{
    /// <summary>
    /// LogNLog : This class used to implement the ILog interface
    /// </summary>
    public class LogNLog : ILog
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        public LogNLog()
        {
        }

        public void Information(string message)
        {
            Logger.Info(message);
        }

        public void Warning(string message)
        {
            Logger.Warn(message);
        }

        public void Debug(string message)
        {
            Logger.Debug(message);
        }

        public void Error(string message)
        {
            Logger.Error(message);
        }
    }
}
