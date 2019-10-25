using Microsoft.EntityFrameworkCore;
using TRC.Core.Modelo;
using TRC.Data.Configuration;

namespace TRC.Data
{
    public class TrcContext : DbContext
    {
        public TrcContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Estado> Estados { get; set; }

        public DbSet<Cidade> Cidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new EstadoConfiguration());
            modelBuilder.ApplyConfiguration(new CidadeConfiguration());
        }
    }
}
