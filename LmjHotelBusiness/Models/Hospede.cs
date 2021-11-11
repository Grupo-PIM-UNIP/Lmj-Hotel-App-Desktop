namespace LmjHotelBusiness.Models
{
    public class Hospede
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }

        public Hospede()
        {
        }

        public Hospede(long id, string nome, string sobrenome, string telefone)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }
    }
}
