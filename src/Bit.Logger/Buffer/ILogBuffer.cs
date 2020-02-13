namespace Bit.Logger.Buffer
{
    using System;
    using System.Collections.Generic;

    public interface ILogBuffer<TLog>
    {
        bool Continue { get; set; }

        Dictionary<string, TLog> Logs { get; }

        object Padlock { get; }

        ILogBuffer<TLog> Check(bool isAllowed);

        ILogBuffer<TLog> Add(TLog log);

        ILogBuffer<TLog> Validate(int logsThreshold);

        void Write(Action<IEnumerable<TLog>> write, Func<KeyValuePair<string, TLog>, TLog> selector);
    }
}
