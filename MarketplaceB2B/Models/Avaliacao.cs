namespace MarketplaceB2B.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }

        public int Nota { get; set; }

        public string Comentario { get; set; }

        public bool Ocultada { get; set; }

        public Avaliacao()
        {
            Ocultada = false;
        }
    }
}
