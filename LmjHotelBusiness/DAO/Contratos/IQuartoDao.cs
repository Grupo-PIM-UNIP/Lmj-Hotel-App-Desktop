using LmjHotelBusiness.Models;
using System.Collections.Generic;

namespace LmjHotelBusiness.DAO.Contratos
{
    public interface IQuartoDao
    {
        List<Quarto> ListarQuartosOcupados();
        List<Quarto> ListarQuartosDisponiveis();
    }
}
