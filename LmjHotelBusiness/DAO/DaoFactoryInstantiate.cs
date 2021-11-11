﻿using DatabaseConfig;
using LmjHotelBusiness.DAO.Contratos;
using LmjHotelBusiness.DAO.Implementacoes;

namespace LmjHotelBusiness.DAO
{
    public class DaoFactoryInstantiate
    {
        public static IQuartoDao CreateQuartoDao()
        {
            return new QuartoDao(DbSqlServer.AbrirConexao());
        }
    }
}