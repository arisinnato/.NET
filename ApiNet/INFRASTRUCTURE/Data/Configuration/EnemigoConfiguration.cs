using System.Threading.Tasks;
using CORE.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class EnemigoConfiguration : IEntityTypeConfiguration<Enemigo>
    {
        public void Configure(EntityTypeBuilder<Enemigo> builder){
            
           builder
            .HasKey(x => x.Id);

        builder
            .Property(x => x.Id)
            .UseIdentityColumn();

        builder.Property(p => p.Nombre).IsRequired().HasMaxLength(255);
        builder.Property(p => p.NivelAmenaza).IsRequired();
        builder.Property(p => p.Recompensa).IsRequired();
        builder.Property(p => p.Habilidades).IsRequired();

        builder.ToTable("Enemigo");
        }
    }
}