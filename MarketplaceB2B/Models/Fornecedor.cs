namespace MarketplaceB2B.Models
{
    public class Fornecedor : Usuario
    {
        public string Empresa { get; set; }

        public string Regiao { get; set; }

        public string Cnpj { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public bool Aprovado { get; set; }

        public bool Bloqueado { get; set; }

        public Fornecedor()
        {
            Aprovado = false;
            Bloqueado = false;
        }
    }    
}
