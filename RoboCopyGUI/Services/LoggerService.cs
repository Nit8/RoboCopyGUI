using System;
using System.IO;

namespace RobocopyFileCopier.Services
{
    public class LoggerService : ILoggerService
    {
        private readonly string _logPath;
        private readonly object _lockObject = new();

        public event EventHandler<string>? LogMessageReceived;

        public LoggerService()
        {
            var logDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                                          "RobocopyFileCopier", "Logs");
            Directory.CreateDirectory(logDirectory);

            _logPath = Path.Combine(logDirectory, $"robocopy-{DateTime.Now:yyyyMMdd}.log");
        }

        public void LogInfo(string message)
        {
            WriteLog("INFO", message);
        }

        public void LogWarning(string message)
        {
            WriteLog("WARN", message);
        }

        public void LogError(string message, Exception? exception = null)
        {
            var fullMessage = exception != null ? $"{message}: {exception}" : message;
            WriteLog("ERROR", fullMessage);
        }

        public void LogDebug(string message)
        {
            WriteLog("DEBUG", message);
        }

        private void WriteLog(string level, string message)
        {
            var logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}";

            lock (_lockObject)
            {
                try
                {
                    File.AppendAllText(_logPath, logEntry + Environment.NewLine);
                }
                catch
                {
                    // Ignore file write errors
                }
            }

            LogMessageReceived?.Invoke(this, logEntry);
        }
    }
}