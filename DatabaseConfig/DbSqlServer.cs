using System.Data.SqlClient;

namespace DatabaseConfig
{
    //Classe responsável por abri e fechar conexão com SQL Server, além de obter comando SQL. 
    public class DbSqlServer
    {
        private static SqlConnection connectionDatabase = null;

        /* Essa String de conexão funciona apenas localmente no meu PC, logo é necessária substituí-la
          pela sua string de conexão, para que consiga usar essa aplicação */
        private const string strConexao = "Integrated Security=SSPI;" +
                                           "Persist Security Info=False;" +
                                           "Initial Catalog=LmjHotelDatabase;" +
                                           "Data Source=JEANCARLOS-PC\\SQLEXPRESS";

        public static SqlConnection AbrirConexao()
        {
            if (connectionDatabase == null)
            {
                try
                {
                    connectionDatabase = new SqlConnection(strConexao);
                    connectionDatabase.Open();
                }
                catch (SqlException e)
                {
                    throw new DbSqlException(e.Message);
                }
            }
            return connectionDatabase;
        }

        public static void FecharConexao()
        {
            if (connectionDatabase != null)
            {
                try
                {
                    connectionDatabase.Close();
                }
                catch (SqlException e)
                {
                    throw new DbSqlException(e.Message);
                }
            }
        }

        public static SqlCommand ObterComandoSql(string querySql, SqlConnection conexao)
        {
            try
            {
                SqlCommand comandoSql = new SqlCommand(querySql, conexao);
                return comandoSql;
            }
            catch (SqlException e)
            {
                throw new DbSqlException(e.Message);
            }
        }
    }
}
