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
        private readonly SqlConnection _conexao;

        public QuartoDao(SqlConnection conexao)
        {
            _conexao = conexao;
        }

        public List<Quarto> ListarQuartosOcupados()
        {
            string querySql = "SELECT * " +
                             "FROM Tb_Quarto " +
                             "Where EstadoDoQuarto = 1";
            var quartos = ListarQuartos(querySql);
            return quartos;
        }

        public List<Quarto> ListarQuartosDisponiveis()
        {
            string querySql = "SELECT * " +
                              "FROM Tb_Quarto " +
                              "Where EstadoDoQuarto = 2";
            var quartos = ListarQuartos(querySql);
            return quartos;
        }

        private List<Quarto> ListarQuartos(string query)
        {
            var quartos = new List<Quarto>();
            SqlCommand comandoSql = null;
            SqlDataReader leitorDeDados = null;
            string querySql = query;
            try
            {
                comandoSql = DbSqlServer.ObterComandoSql(querySql, _conexao);
                leitorDeDados = comandoSql.ExecuteReader();

                while (leitorDeDados.Read())
                {
                    long id = leitorDeDados.GetInt64(0);
                    string numero = leitorDeDados.GetString(1);
                    EstadoQuarto estado = (EstadoQuarto)leitorDeDados.GetInt32(2);

                    quartos.Add(new Quarto(id, numero, estado));
                }
                return quartos;
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
