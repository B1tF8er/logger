namespace Bit.Logger.Loggers.Console
{
    using Bit.Logger.Config;
    using System;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        private void WriteToConsole<TClass>(Level level, string message = default(string), Exception exception = default(Exception))
            where TClass : class
        {
            if (Configuration.Level <= level)
            {
                Console.WriteLine(
                    string.Format(Configuration.FormatProvider, Configuration.Format,
                        level,
                        DateTime.Now,
                        typeof(TClass).FullName,
                        GetMethodName(),
                        message,
                        exception
                    )
                );
            }
        }

        private void WriteToConsole(Level level, string message = default(string), Exception exception = default(Exception))
        {
            if (Configuration.Level <= level)
            {
                Console.WriteLine(
                    string.Format(Configuration.FormatProvider, Configuration.Format,
                        level,
                        DateTime.Now,
                        GetClass().FullName,
                        GetMethodName(),    
                        message,    
                        exception
                    )
                );
            }
        }
    }
}