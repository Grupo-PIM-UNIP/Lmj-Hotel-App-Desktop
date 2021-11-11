using LmjHotelBusiness.Models;
using System.Collections.Generic;

namespace LmjHotelBusiness.DAO.Contratos
{
    public interface IReservaDao
    {
        List<Reserva> ListarTodasReservas();
    }
}
