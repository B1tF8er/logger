namespace Bit.Logger.Sources.File
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class FileLogger
    {
        public void Warning<TClass>(string message) where TClass : class =>
            WriteToFile(WarningMessage<TClass>(message));

        public void Warning(string message) =>
            WriteToFile(WarningMessage(message));

        public void Warning<TClass>(Exception exception) where TClass : class =>
            WriteToFile(WarningException<TClass>(exception));

        public void Warning(Exception exception) =>
            WriteToFile(WarningException(exception));

        public void Warning<TClass>(string message, Exception exception) where TClass : class =>
            WriteToFile(WarningMessageAndException<TClass>(message, exception));

        public void Warning(string message, Exception exception) =>
            WriteToFile(WarningMessageAndException(message, exception));
    }
}