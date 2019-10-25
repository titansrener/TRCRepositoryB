using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TRC.Core.Modelo;

namespace TRC.Data.Configuration
{
    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("TB_ESTADO", "dbo");

            builder.Property(p => p.Sigla)
                .HasColumnName("Sigla");

            builder.Property(p => p.Nome)
                .HasColumnName("Nome");
        }
    }
}
