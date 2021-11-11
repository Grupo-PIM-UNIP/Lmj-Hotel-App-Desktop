using System;

namespace DatabaseConfig
{
    public class DbSqlException : ApplicationException
    {
        public DbSqlException(string message) : base(message)
        {
        }
    }
}
