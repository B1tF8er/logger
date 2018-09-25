namespace Bit.Logger.Loggers.Arguments
{
    using Enums;
    using System;

    internal partial class LogArguments
    {
        internal Level Level { get; set; }

        internal string ClassName { get; set; }

        internal string MethodName { get; set; }

        internal string Message { get; set; } = default(string);

        internal Exception Exception { get; set; } = default(Exception);
    }
}