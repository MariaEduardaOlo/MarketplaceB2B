using Microsoft.EntityFrameworkCore;
using MarketplaceB2B.Models;

namespace MarketplaceB2B.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Fornecedor> Fornecedores { get; set; }

        public DbSet<Comprador> Compradores { get; set; }

        public DbSet<Anuncio> Anuncios { get; set; }

        public DbSet<Avaliacao> Avaliacoes { get; set; }
    }
}
