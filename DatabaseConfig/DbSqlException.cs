using System;

namespace DatabaseConfig
{
    //Exceção personalizada usada para tratat Exceptions de acesso a dados
    public class DbSqlException : ApplicationException
    {
        public DbSqlException(string message) : base(message)
        {
        }
    }
}
