using LmjHotelBusiness.DAO;
using LmjHotelBusiness.DAO.Contratos;
using LmjHotelBusiness.Models;
using System.Collections.Generic;

namespace LmjHotelBusiness.Services
{
    // Classe de serviço responsável pelas regras de negócio do sistema
    public class ReservaService
    {
        //Injetando a dependência com a interface IReservaDao
        private readonly IReservaDao reservaDao = DaoFactoryInstantiate.CreateReservadao();

        public List<Reserva> ListaTodasReservas()
        {
            return reservaDao.ListarTodasReservas();
        }

        public List<Reserva> ListaReservasAtivas()
        {
            return reservaDao.ListarReservasAtivas();
        }

        public List<Reserva> ListarReservasQueIniciamHoje()
        {
            return reservaDao.ListarReservasQueIniciamHoje();
        }
    }
}
