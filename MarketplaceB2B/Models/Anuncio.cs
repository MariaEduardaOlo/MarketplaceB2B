namespace MarketplaceB2B.Models
{
    public class Anuncio
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Categoria { get; set; }

        public string Marca { get; set; }

        public int QuantidadeMinima { get; set; }

        public string Regiao { get; set; }

        public string Status { get; set; }

        public decimal Preco { get; set; }

        public string PrazoEntrega { get; set; }

        public string FormaContato { get; set; }

        public int Visualizacoes { get; set; }

        public Anuncio()
        {
            Status = "Rascunho";
            Visualizacoes = 0;
        }
    }
}
