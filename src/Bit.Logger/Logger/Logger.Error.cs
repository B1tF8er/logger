namespace Bit.Logger
{
    using System;
    using System.Runtime.CompilerServices;
    using static Helpers.Constants.Caller;

    public partial class Logger
    {
        public void Error(string message, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Sources.ForEach(source => source.Error(message, className, methodName));

        public void Error(Exception exception, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Sources.ForEach(source => source.Error(exception, className, methodName));

        public void Error(string message, Exception exception, [CallerFilePath] string className = EmptyClassName, [CallerMemberName] string methodName = EmptyMethodName) =>
            Sources.ForEach(source => source.Error(message, exception, className, methodName));
    }
}
