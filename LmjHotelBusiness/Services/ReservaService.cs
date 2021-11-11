using LmjHotelBusiness.DAO;
using LmjHotelBusiness.DAO.Contratos;
using LmjHotelBusiness.Models;
using System.Collections.Generic;

namespace LmjHotelBusiness.Services
{
    public class ReservaService
    {
        private readonly IReservaDao reservaDao = DaoFactoryInstantiate.CreateReservadao();

        public List<Reserva> ListaTodasReservas()
        {
            return reservaDao.ListarTodasReservas();
        }
    }
}
