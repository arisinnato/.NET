using System.Threading.Tasks;
using CORE.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class MisionConfiguration : IEntityTypeConfiguration<Misiones>
    {
        public void Configure(EntityTypeBuilder<Misiones> builder){
            
            builder
                .HasKey(x => x.id);

            builder
                .Property(x => x.id)
                .UseIdentityColumn();

            builder
                .Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(255);
            
            builder
                .Property(x => x.Objetivos)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .Property(x => x.Recompensas)
                .IsRequired()
                .HasMaxLength(255);
            
            builder
                .Property(x => x.Estado)
                .IsRequired()
                .HasMaxLength(255);
            
            builder.Property(p => p.Nombre).IsRequired();
            builder.Property(p => p.Objetivos).IsRequired();
            builder.Property(p => p.Recompensas).IsRequired();
            builder.Property(p => p.Estado).IsRequired();


            builder
                .ToTable("Misiones");
        }
    }
}