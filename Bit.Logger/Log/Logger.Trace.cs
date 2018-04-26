namespace Bit.Logger
{
    using Bit.Logger.Config;
    using Bit.Logger.Loggers.Console;
    using Bit.Logger.Loggers.Database;
    using Bit.Logger.Loggers.File;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Logger : ILoggerFactory
    {
        public void Trace<TClass>(string message) where TClass : class =>
            Loggers.ForEach(logger => logger.Trace<TClass>(message));

        public void Trace(string message) =>
            Loggers.ForEach(logger => logger.Trace(message));

        public void Trace<TClass>(Exception exception) where TClass : class =>
            Loggers.ForEach(logger => logger.Trace<TClass>(exception));

        public void Trace(Exception exception) =>
            Loggers.ForEach(logger => logger.Trace(exception));

        public void Trace<TClass>(string message, Exception exception) where TClass : class =>
            Loggers.ForEach(logger => logger.Trace<TClass>(message, exception));

        public void Trace(string message, Exception exception) =>
            Loggers.ForEach(logger => logger.Trace(message, exception));
    }
}