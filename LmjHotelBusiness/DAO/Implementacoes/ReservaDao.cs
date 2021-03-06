using DatabaseConfig;
using LmjHotelBusiness.DAO.Contratos;
using LmjHotelBusiness.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LmjHotelBusiness.DAO.Implementacoes
{
    //A classe ReservaDao implementa os contratos estabelecidos pela interface IReservaDao
    public class ReservaDao : IReservaDao
    {
        //Declarando dependência de ReservaDao com a classe SqlConnection
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
                              " WHERE DataInicio <= GETDATE() AND DataFim >= GETDATE()";

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
                              " WHERE convert(date, convert(varchar(10), DataInicio, 102)) = convert(date, GETDATE())";

            var reservas = ListarReservas(querySql);
            return reservas;
        }

        /* Método genérico de listagem de reservas, onde todas as listagens de reservas acima tem 
           praticamente a mesma implementação com exceção das querys SQL que são diferentes. Sendo assim
           os métodos acima passam uma query como parâmetro para o método ListarReservas e este por sua vez
           realiza operações de acesso ao banco de dados SQL Server */
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

        //Método auxiliar de instanciação de quarto usado no método de listar reservas.
        private Quarto InstanciarQuarto(SqlDataReader leitorDeDados)
        {
            long id = leitorDeDados.GetInt64(0);
            string numeroDoQuarto = leitorDeDados.GetString(1);
      
            return new Quarto(id, numeroDoQuarto);
        }

        //Método auxiliar de instanciação de hóspede usado no método de listar reservas.
        private Hospede InstanciarHospede(SqlDataReader leitorDeDados)
        {
            long id = leitorDeDados.GetInt64(2);
            string nome = leitorDeDados.GetString(3);
            string sobrenome = leitorDeDados.GetString(4);
            string telefone = leitorDeDados.GetString(5);

            return new Hospede(id, nome, sobrenome, telefone);
        }

        //Método auxiliar de instanciação de reserva usado no método de listar reservas.
        private Reserva InstanciarReserva(SqlDataReader leitorDeDados, Hospede hospede, Quarto quarto)
        {
            long id = leitorDeDados.GetInt64(6);
            DateTime dataInicio = leitorDeDados.GetDateTime(7);
            DateTime dataFim = leitorDeDados.GetDateTime(8);

            return new Reserva(id, dataInicio, dataFim, hospede, quarto);
        }
    }
}
