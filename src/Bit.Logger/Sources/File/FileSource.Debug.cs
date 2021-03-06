namespace Bit.Logger.Sources.File
{
    using System;
    using static Arguments.LogArguments;

    internal partial class FileSource
    {
        public void Debug(string message, string className, string methodName) =>
            WriteToFile(DebugMessage(message, className, methodName));

        public void Debug(Exception exception, string className, string methodName) =>
            WriteToFile(DebugException(exception, className, methodName));

        public void Debug(string message, Exception exception, string className, string methodName) =>
            WriteToFile(DebugMessageAndException(message, exception, className, methodName));
    }
}
