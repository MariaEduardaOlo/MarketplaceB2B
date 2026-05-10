using MarketplaceB2B.Models;

namespace MarketplaceB2B.Services
{
    public class SistemaService 
    {
        public List<Fornecedor> fornecedores = new List<Fornecedor>();

        public List<Comprador> compradores = new List<Comprador>();

        public List<Anuncio> anuncios = new List<Anuncio>();

        public List<Avaliacao> avaliacoes = new List<Avaliacao>();

        public void IniciarSistema()
        {
            Console.WriteLine("Sistema Marketplace iniciado");
        }
    }
}
