﻿namespace Bit.Logger.Helpers
{
    using Config;
    using System.IO;
    using static Constants.PathResolver;

    public class DatabaseLogPathResolver : IDatabaseLogPathResolver
    {
        private readonly IConfiguration configuration;

        public DatabaseLogPathResolver(IConfiguration configuration) =>
            this.configuration = configuration;

        public string GetConnectionString()
        {
            string databaseLogName = $"{LogName}.db";
            var path = Path.Combine(configuration.DatabaseLogLocation, databaseLogName);
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            return $"Data Source={Path.GetFullPath(path)}";
        }
    }
}
