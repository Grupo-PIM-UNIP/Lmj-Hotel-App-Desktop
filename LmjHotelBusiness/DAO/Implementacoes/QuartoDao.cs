using LmjHotelBusiness.DAO.Contratos;
using LmjHotelBusiness.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using DatabaseConfig;
using LmjHotelBusiness.Models.Enums;

namespace LmjHotelBusiness.DAO.Implementacoes
{
    public class QuartoDao : IQuartoDao
    {
        public List<Quarto> list { get; set; } = new List<Quarto>();
        private readonly SqlConnection _conexao;

        public QuartoDao(SqlConnection conexao)
        {
            _conexao = conexao;
        }

        public List<Quarto> ListarQuartosDisponiveis()
        {
            SqlCommand comandoSql = null;
            SqlDataReader leitorDeDados = null;
            string querySql = "SELECT * " +
                              " FROM Tb_Quarto " +
                              " WHERE EstadoDoQuarto = 2";
            try
            {
                comandoSql = DbSqlServer.ObterComandoSql(querySql, _conexao);
                leitorDeDados = comandoSql.ExecuteReader();

                while (leitorDeDados.Read())
                {
                    long id = leitorDeDados.GetInt64(0);
                    string numero = leitorDeDados.GetString(1);
                    EstadoQuarto estado = (EstadoQuarto)leitorDeDados.GetInt32(2);

                    list.Add(new Quarto(id, numero, estado));
                }
                return list;
            }
            catch (SqlException e)
            {
                throw new DbSqlException(e.Message);
            }
            finally
            {
                leitorDeDados.Close();
            }
        }
    }
}
