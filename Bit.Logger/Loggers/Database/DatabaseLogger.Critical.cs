namespace Bit.Logger.Loggers.Database
{
    using Bit.Logger.Config;
    using Bit.Logger.Models;
    using System;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class DatabaseLogger : ILogger, IConfiguration
    {
        public void Critical<TClass>(string message) where TClass : class =>
            WriteToDatabase<TClass>(Level.Critical, message);

        public void Critical(string message) =>
            ToDatabase(Level.Critical, message);

        public void Critical<TClass>(Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Critical, exception: exception);

        public void Critical(Exception exception) =>
            ToDatabase(Level.Critical, exception: exception);

        public void Critical<TClass>(string message, Exception exception) where TClass : class =>
            WriteToDatabase<TClass>(Level.Critical, message, exception);

        public void Critical(string message, Exception exception) =>
            ToDatabase(Level.Critical, message, exception);
    }
}