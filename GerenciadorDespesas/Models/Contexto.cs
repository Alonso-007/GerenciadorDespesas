using Microsoft.EntityFrameworkCore;

namespace GerenciadorDespesas.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opcoes) : base (opcoes) {}

        public DbSet<Meses> Meses { get; set; }
        public DbSet<Salarios> Salarios { get; set; }
        public DbSet<Despesas> Despesas { get; set; }
        public DbSet<TipoDespesas> TipoDespesas { get; set; }
    }
}
