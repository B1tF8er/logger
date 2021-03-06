﻿namespace Bit.Logger.Buffer
{
    using Arguments;
    using Helpers;
    using Config;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Writers;
    using static Helpers.Constants.Buffer;

    internal class LogBuffer<TLog> : ILogBuffer<TLog> where TLog : class
    {
        private readonly IConfiguration configuration;
        private readonly IBulkWriter<TLog> bulkWriter;
        private readonly object padlock;
        private readonly IDictionary<string, TLog> logs;

        internal LogBuffer(IConfiguration configuration, IBulkWriter<TLog> bulkWriter)
        {
            this.configuration = configuration;
            this.bulkWriter = bulkWriter;
            padlock = new object();
            logs = new Dictionary<string, TLog>();
        }

        public void Write(
            LogArguments logArguments,
            Func<LogArguments, IConfiguration, TLog> toLog,
            Func<KeyValuePair<string, TLog>, TLog> selector)
        {
            if (!ShouldAdd(logArguments, toLog))
                return;

            if (IsUnderThreshold())
                return;

            Write(selector);
        }

        private bool ShouldAdd(LogArguments logArguments, Func<LogArguments, IConfiguration, TLog> toLog)
        {
            if (!logArguments.IsLevelAllowed(configuration.Level))
                return false;

            var key = $"{DateTime.Now.ToString(AsKey)}-{Guid.NewGuid()}";
            var log = toLog(logArguments, configuration);

            lock (padlock)
                logs.Add(key, log);

            return true;
        }

        private bool IsUnderThreshold()
        {
            var underThreshold = true;

            lock (padlock)
                underThreshold = logs.Count < configuration.BufferSize;

            return underThreshold;
        }

        private void Write(Func<KeyValuePair<string, TLog>, TLog> selector)
        {
            lock (padlock)
            {
                var orderedLogs = logs
                    .OrderByDescending(DateTimeKey())
                    .Select(selector);

                bulkWriter.Write(orderedLogs);
                logs.Clear();
            }
        }

        private static Func<KeyValuePair<string, TLog>, string> DateTimeKey() =>
            kv => kv.Key.Split('-').FirstOrDefault();
    }
}
