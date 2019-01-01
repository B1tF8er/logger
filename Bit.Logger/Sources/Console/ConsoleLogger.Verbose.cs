namespace Bit.Logger.Sources.Console
{
    using Config;
    using System;
    using static Arguments.LogArguments;

    internal partial class ConsoleLogger
    {
        public void Verbose<TClass>(string message) where TClass : class =>
            WriteToConsole(VerboseMessage<TClass>(message));

        public void Verbose(string message) =>
            WriteToConsole(VerboseMessage(message));

        public void Verbose<TClass>(Exception exception) where TClass : class =>
            WriteToConsole(VerboseException<TClass>(exception));

        public void Verbose(Exception exception) =>
            WriteToConsole(VerboseException(exception));

        public void Verbose<TClass>(string message, Exception exception) where TClass : class =>
            WriteToConsole(VerboseMessageAndException<TClass>(message, exception));

        public void Verbose(string message, Exception exception) =>
            WriteToConsole(VerboseMessageAndException(message, exception));
    }
}