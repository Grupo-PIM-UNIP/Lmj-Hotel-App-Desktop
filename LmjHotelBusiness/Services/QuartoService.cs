using LmjHotelBusiness.DAO;
using LmjHotelBusiness.DAO.Contratos;
using LmjHotelBusiness.Models;
using System.Collections.Generic;

namespace LmjHotelBusiness.Services
{
    // Classe de serviço responsável pelas regras de negócio do sistema
    public class QuartoService
    {
        //Injetando a dependência com a interface IQuartoDao
        private readonly IQuartoDao quartoDao = DaoFactoryInstantiate.CreateQuartoDao();

        public List<Quarto> ListarQuartosOcupados()
        {
            return quartoDao.ListarQuartosOcupados();
        }

        public List<Quarto> ListarQuartosDisponiveis()
        {
            return quartoDao.ListarQuartosDisponiveis();
        } 
    }
}
