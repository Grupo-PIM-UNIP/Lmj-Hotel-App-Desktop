using System;

namespace LmjHotelBusiness.Models
{
    public class Reserva
    {
        public long Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public Hospede Hospede { get; set; }

        public Quarto Quarto { get; set; }

        public Reserva()
        {
        }

        public Reserva(long id, DateTime dataInicio, DateTime dataFim, Hospede hospede, Quarto quarto)
        {
            Id = id;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Hospede = hospede;
            Quarto = quarto;
        }
    }
}
