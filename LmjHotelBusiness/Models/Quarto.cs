using LmjHotelBusiness.Models.Enums;

namespace LmjHotelBusiness.Models
{
    public class Quarto
    {
        public long Id { get; set; }
        public string Numero { get; set; }
        public EstadoQuarto EstadoQuarto { get; set; }

        public Quarto()
        {
        }

        public Quarto(long id, string numero, EstadoQuarto estadoQuarto)
        {
            Id = id;
            Numero = numero;
            EstadoQuarto = estadoQuarto;
        }
    }
}
