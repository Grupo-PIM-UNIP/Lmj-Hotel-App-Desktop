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
        private readonly SqlConnection _conexao;

        public ReservaDao(SqlConnection conexao)
        {
            _conexao = conexao;
        }

        public List<Reserva> ListarTodasReservas()
        {
            string querySql = " SELECT " +
                              " Tb_Quarto.Id AS IdQuarto, Tb_Quarto.Numero AS Quarto, " +
                              " Tb_Hospede.Id AS IdHospede, Tb_Hospede.Nome AS Nome, " +
                              " Tb_Hospede.Sobrenome AS Sobrenome, Tb_Hospede.Telefone AS Fone, " +
                              " Tb_Reserva.Id, DataInicio, DataFim " +
                              " FROM Tb_Reserva " +
                              " INNER JOIN Tb_Hospede ON Tb_Reserva.HospedeId = Tb_Hospede.Id " +
                              " INNER JOIN Tb_Quarto ON Tb_Reserva.QuartoId = Tb_Quarto.Id";
            
            var reservas = ListarReservas(querySql);
            return reservas;
        }

        public List<Reserva> ListarReservasAtivas()
        {
            string querySql = " SELECT " +
                              " Tb_Quarto.Id AS IdQuarto, Tb_Quarto.Numero AS Quarto, " +
                              " Tb_Hospede.Id AS IdHospede, Tb_Hospede.Nome AS Nome, " +
                              " Tb_Hospede.Sobrenome AS Sobrenome, Tb_Hospede.Telefone AS Fone, " +
                              " Tb_Reserva.Id, DataInicio, DataFim " +
                              " FROM Tb_Reserva " +
                              " INNER JOIN Tb_Hospede ON Tb_Reserva.HospedeId = Tb_Hospede.Id " +
                              " INNER JOIN Tb_Quarto ON Tb_Reserva.QuartoId = Tb_Quarto.Id " +
                              " WHERE DataFim >= GETDATE()";

            var reservas = ListarReservas(querySql);
            return reservas;
        }

        public List<Reserva> ListarReservasQueIniciamHoje()
        {
            string querySql = " SELECT " +
                              " Tb_Quarto.Id AS IdQuarto, Tb_Quarto.Numero AS Quarto, " +
                              " Tb_Hospede.Id AS IdHospede, Tb_Hospede.Nome AS Nome, " +
                              " Tb_Hospede.Sobrenome AS Sobrenome, Tb_Hospede.Telefone AS Fone, " +
                              " Tb_Reserva.Id, DataInicio, DataFim " +
                              " FROM Tb_Reserva " +
                              " INNER JOIN Tb_Hospede ON Tb_Reserva.HospedeId = Tb_Hospede.Id " +
                              " INNER JOIN Tb_Quarto ON Tb_Reserva.QuartoId = Tb_Quarto.Id " +
                              " WHERE DataInicio = GETDATE()";

            var reservas = ListarReservas(querySql);
            return reservas;
        }

        private List<Reserva> ListarReservas(string query)
        {
            var reservas = new List<Reserva>();
            string querySql = query;

            SqlCommand comandoSql = null;
            SqlDataReader leitorDeDados = null;

            try
            {
                comandoSql = DbSqlServer.ObterComandoSql(querySql, _conexao);
                leitorDeDados = comandoSql.ExecuteReader();

                while (leitorDeDados.Read())
                {
                    Quarto quarto = InstanciarQuarto(leitorDeDados);
                    Hospede hospede = InstanciarHospede(leitorDeDados);
                    Reserva reserva = InstanciarReserva(leitorDeDados, hospede, quarto);

                    reservas.Add(reserva);
                }
                return reservas;
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

        private Quarto InstanciarQuarto(SqlDataReader leitorDeDados)
        {
            long id = leitorDeDados.GetInt64(0);
            string numeroDoQuarto = leitorDeDados.GetString(1);
      
            return new Quarto(id, numeroDoQuarto);
        }

        private Hospede InstanciarHospede(SqlDataReader leitorDeDados)
        {
            long id = leitorDeDados.GetInt64(2);
            string nome = leitorDeDados.GetString(3);
            string sobrenome = leitorDeDados.GetString(4);
            string telefone = leitorDeDados.GetString(5);

            return new Hospede(id, nome, sobrenome, telefone);
        }

        private Reserva InstanciarReserva(SqlDataReader leitorDeDados, Hospede hospede, Quarto quarto)
        {
            long id = leitorDeDados.GetInt64(6);
            DateTime dataInicio = leitorDeDados.GetDateTime(7);
            DateTime dataFim = leitorDeDados.GetDateTime(8);

            return new Reserva(id, dataInicio, dataFim, hospede, quarto);
        }
    }
}
