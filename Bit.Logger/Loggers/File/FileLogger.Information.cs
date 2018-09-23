namespace Bit.Logger.Loggers.File
{
    using Bit.Logger.Config;
    using System;
    using static Bit.Logger.Loggers.Arguments.LogArguments;

    internal partial class FileLogger : ILogger, IConfiguration
    {
        public void Information<TClass>(string message) where TClass : class =>
            WriteToFile(InformationMessage<TClass>(message));

        public void Information(string message) =>
            WriteToFile(InformationMessage(message));

        public void Information<TClass>(Exception exception) where TClass : class =>
            WriteToFile(InformationException<TClass>(exception));

        public void Information(Exception exception) =>
            WriteToFile(InformationException(exception));

        public void Information<TClass>(string message, Exception exception) where TClass : class =>
            WriteToFile(InformationMessageAndException<TClass>(message, exception));

        public void Information(string message, Exception exception) =>
            WriteToFile(InformationMessageAndException(message, exception));
    }
}