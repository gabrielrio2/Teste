using Microsoft.EntityFrameworkCore;

namespace Teste.Models
{
    public class BancoDeDados : DbContext

    {
        public DbSet<Cliente>clientes{get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"server=(localdb)\mssqllocaldb;Database=Teste;Integrated Security=True");
        }
    }
}
