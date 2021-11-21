using LmjHotelBusiness.DAO.Contratos;
using LmjHotelBusiness.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using DatabaseConfig;
using LmjHotelBusiness.Models.Enums;

namespace LmjHotelBusiness.DAO.Implementacoes
{
    //A classe QuartoDao implementa os contratos estabelecidos pela interface IQuartoDao
    public class QuartoDao : IQuartoDao
    {
        //Declarando dependência de QuartoDao com a classe SqlConnection
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

        /* Método genérico de listagem de quartos, onde todas as listagens de quarto acima tem 
           praticamente a mesma implementação com exceção das querys SQL que são diferentes. Sendo assim
           os métodos acima passam uma query como parâmetro para o método ListarQuartos e este por sua vez
           realiza operações de acesso ao banco de dados SQL Server */
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
