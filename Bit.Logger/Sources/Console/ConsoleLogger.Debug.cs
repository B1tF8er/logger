namespace Bit.Logger.Sources.Console
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class ConsoleLogger
    {
        public void Debug<TClass>(string message) where TClass : class =>
            WriteToConsole(DebugMessage<TClass>(message));

        public void Debug(string message) =>
            WriteToConsole(DebugMessage(message));

        public void Debug<TClass>(Exception exception) where TClass : class =>
            WriteToConsole(DebugException<TClass>(exception));

        public void Debug(Exception exception) =>
            WriteToConsole(DebugException(exception));

        public void Debug<TClass>(string message, Exception exception) where TClass : class =>
            WriteToConsole(DebugMessageAndException<TClass>(message, exception));

        public void Debug(string message, Exception exception) =>
            WriteToConsole(DebugMessageAndException(message, exception));
    }
}