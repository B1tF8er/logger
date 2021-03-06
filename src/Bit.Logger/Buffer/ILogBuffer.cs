namespace Bit.Logger.Buffer
{
    using Arguments;
    using Config;
    using System;
    using System.Collections.Generic;

    internal interface ILogBuffer<TLog> where TLog : class
    {
        void Write(
            LogArguments logArguments,
            Func<LogArguments, IConfiguration, TLog> toLog,
            Func<KeyValuePair<string, TLog>, TLog> selector);
    }
}
