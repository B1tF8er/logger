namespace Bit.Logger.Sources.File
{
    using Arguments;
    using System;
    using Writers;
    using static Helpers.LogArgumentsExtensions;

    internal partial class FileSource
    {
        private void WriteToFile(LogArguments logArguments) => logBuffer
            .Check(logArguments.IsLevelAllowed(configuration.Level))
            .Add(logArguments.ToStringLogUsing(configuration))
            .Validate(configuration.BufferSize)
            .Write(FileBulkWriter.ToFileAsync, kv => $"{kv.Value}{Environment.NewLine}");
    }
}
