using LmjHotelBusiness.DAO.Contratos;
using LmjHotelBusiness.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DatabaseConfig;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmjHotelBusiness.DAO.Implementacoes
{
    public class ReservaDao : IReservaDao
    {
        private SqlConnection _conexao;

        public ReservaDao(SqlConnection conexao)
        {
            _conexao = conexao;
        }

        public List<Reserva> ListarTodasReservas()
        {
            var list = new List<Reserva>();
            SqlCommand comandoSql = null;
            SqlDataReader leitorDeDados = null;

            string querySql = "SELECT " +
                              " Tb_Reserva.Id, DataInicio, DataFim, HospedeId, QuartoId," +
                              " Tb_Hospede.Nome AS NomeHospede, Tb_Hospede.Sobrenome AS SobrenomeHospede," +
                              " Tb_Hospede.Telefone AS HospedeTelefone, Tb_Quarto.Numero AS Quarto " +
                              " FROM Tb_Reserva " +
                              " INNER JOIN Tb_Hospede ON Tb_Reserva.HospedeId = Tb_Hospede.Id " +
                              " INNER JOIN Tb_Quarto ON Tb_Reserva.QuartoId = Tb_Quarto.Id"; 
            try
            {
                comandoSql = DbSqlServer.ObterComandoSql(querySql, _conexao);
                leitorDeDados = comandoSql.ExecuteReader();

                while (leitorDeDados.Read())
                {
                    long idReserva = leitorDeDados.GetInt64(0);
                    DateTime dataInicio = leitorDeDados.GetDateTime(1);
                    DateTime dataFim = leitorDeDados.GetDateTime(2);
                    long hospedeId = leitorDeDados.GetInt64(3);
                    long quartoId = leitorDeDados.GetInt64(4);

                    string nome = leitorDeDados.GetString(5);
                    string sobrenome = leitorDeDados.GetString(6);
                    string telefone = leitorDeDados.GetString(7);

                    string numeroDoQuarto = leitorDeDados.GetString(8);

                    Quarto quarto = new Quarto(quartoId, numeroDoQuarto);
                    Hospede hospede = new Hospede(hospedeId, nome, sobrenome, telefone);
                    Reserva reserva = new Reserva(idReserva, dataInicio, dataFim, hospede, quarto);

                    list.Add(reserva);
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
