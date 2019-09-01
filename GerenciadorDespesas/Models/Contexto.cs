using Microsoft.EntityFrameworkCore;

namespace GerenciadorDespesas.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opcoes) : base (opcoes) {}
    }
}
