namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType databaseType)
        {
            return databaseType switch
            {
                DatabaseType.SqlServer => new SqlServerDatabase(),
                DatabaseType.Oracle => new OracleDatabase(),
                _ => throw new ArgumentException("Invalid database type", nameof(databaseType))
            };
        }
    }
}