namespace Bit.Logger.Sources.Database
{
    using System;
    using static Arguments.LogArguments;

    internal partial class DatabaseSource
    {
        public void Debug(string message, string className, string methodName) =>
            WriteToDatabase(DebugMessage(message, className, methodName));

        public void Debug(Exception exception, string className, string methodName) =>
            WriteToDatabase(DebugException(exception, className, methodName));

        public void Debug(string message, Exception exception, string className, string methodName) =>
            WriteToDatabase(DebugMessageAndException(message, exception, className, methodName));
    }
}
