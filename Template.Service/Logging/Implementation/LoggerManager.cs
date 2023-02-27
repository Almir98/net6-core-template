namespace Template.Infrastructure.Logging.Implementation
{
    public class LoggerManager : ILoggerManager
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        public void LogInfo(string message) => logger.Info(message);
        public void LogWarn(string message) => logger.Warn(message);
        public void LogDebug(string message) => logger.Debug(message);
        public void LogError(Exception exception, string message) => logger.Error(exception, message);
    }
}
