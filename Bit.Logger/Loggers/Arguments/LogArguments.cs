namespace Bit.Logger.Loggers.Arguments
{
    using System;
    using static Bit.Logger.Level;

    internal class LogArguments
    {
        internal Level Level { get; set; } 
        internal string ClassName { get; set; } 
        internal string MethodName { get; set; } 
        internal string Message { get; set; } 
        internal Exception Exception { get; set; } 
    }
}