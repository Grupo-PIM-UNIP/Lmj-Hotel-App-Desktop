using LmjHotelBusiness.DAO;
using LmjHotelBusiness.DAO.Implementacoes;
using LmjHotelBusiness.DAO.Contratos;
using LmjHotelBusiness.Models;
using System.Collections.Generic;

namespace LmjHotelBusiness.Services
{
    public class QuartoService
    {
        private readonly IQuartoDao quartoDao = DaoFactoryInstantiate.CreateQuartoDao();

        public List<Quarto> ListarQuartosDisponiveis()
        {
            return quartoDao.ListarQuartosDisponiveis();
        } 
    }
}
