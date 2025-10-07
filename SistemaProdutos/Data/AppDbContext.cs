using Microsoft.EntityFrameworkCore; // Matheus Angelo - CB3025489
using SistemaProdutos.Models; 

namespace SistemaProdutos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                .HasConversion<double>();
        }

    }
}
