using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TRC.Core.Modelo;

namespace TRC.Data.Configuration
{
    public class CidadeConfiguration : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.HasKey(c => c.Id);

            builder.ToTable("TB_CIDADE","dbo");

            builder.Property(c => c.Nome)
                .HasColumnName("Nome");

            builder.Property(c => c.Estado_Id)
                .HasColumnName("Estado_Id");

            builder.HasOne(c => c.EstadoNavegation)
                .WithMany(c => c.CidadesNavegation)
                .HasForeignKey(c => c.Estado_Id)
                .HasPrincipalKey(c => c.Id);
        }
    }
}
