namespace Bit.Logger.FormatProviders.FormatterStrategy
{
    using Enums;
    using System;
    using static Helpers.DateTypeExtensions;
    
    internal class DateFormatterStrategy : IFormatterStrategy
    {
        public string ApplyFormatTo<TArgument>(TArgument argument)
        {
            var date = argument as Nullable<DateTime>;

            return date?.ToString(GetFormatFor(DateType.Date)) ?? string.Empty;
        }
    }
}