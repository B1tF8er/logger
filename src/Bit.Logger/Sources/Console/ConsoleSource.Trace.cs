namespace Bit.Logger.Sources.Console
{
    using System;
    using static Arguments.LogArguments;

    internal partial class ConsoleSource
    {
        public void Trace(string message, string className, string methodName) =>
            WriteToConsole(TraceMessage(message, className, methodName));

        public void Trace(Exception exception, string className, string methodName) =>
            WriteToConsole(TraceException(exception, className, methodName));

        public void Trace(string message, Exception exception, string className, string methodName) =>
            WriteToConsole(TraceMessageAndException(message, exception, className, methodName));
    }
}
