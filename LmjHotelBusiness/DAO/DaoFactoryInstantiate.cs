using DatabaseConfig;
using LmjHotelBusiness.DAO.Contratos;
using LmjHotelBusiness.DAO.Implementacoes;

namespace LmjHotelBusiness.DAO
{
    /* A classe DaoFactoryInstantiate instancia realiza a injeção de dependência das intefaces
       com suas respectivas implementações */
    public class DaoFactoryInstantiate
    {
        public static IQuartoDao CreateQuartoDao()
        {
            return new QuartoDao(DbSqlServer.AbrirConexao());
        }

        public static IReservaDao CreateReservadao()
        {
            return new ReservaDao(DbSqlServer.AbrirConexao());
        }
    }
}
