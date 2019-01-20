namespace Bit.Logger.Sources.Database
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class DatabaseLogger
    {
        public void Warning<TClass>(string message) where TClass : class =>
            WriteToDatabase(WarningMessage<TClass>(message));

        public void Warning(string message) =>
            WriteToDatabase(WarningMessage(message));

        public void Warning<TClass>(Exception exception) where TClass : class =>
            WriteToDatabase(WarningException<TClass>(exception));

        public void Warning(Exception exception) =>
            WriteToDatabase(WarningException(exception));

        public void Warning<TClass>(string message, Exception exception) where TClass : class =>
            WriteToDatabase(WarningMessageAndException<TClass>(message, exception));

        public void Warning(string message, Exception exception) =>
            WriteToDatabase(WarningMessageAndException(message, exception));
    }
}
