using System;

namespace RobocopyFileCopier.Services
{
    public interface ILoggerService
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message, Exception? exception = null);
        void LogDebug(string message);

        event EventHandler<string>? LogMessageReceived;
    }
}