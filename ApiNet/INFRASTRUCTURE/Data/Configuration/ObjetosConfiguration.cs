using System.Threading.Tasks;
using CORE.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ObjetosConfiguration : IEntityTypeConfiguration<Objeto>
    {
        public void Configure(EntityTypeBuilder<Objeto> builder){
            
           builder
            .HasKey(x => x.Id);

        builder
            .Property(x => x.Id)
            .UseIdentityColumn();

        builder.Property(p => p.Nombre).IsRequired().HasMaxLength(255);
        builder.Property(p => p.Descripcion).IsRequired().HasMaxLength(200);
        builder.Property(p => p.Tipo).IsRequired();
        builder.Property(p => p.Valor).IsRequired();
        builder.Property(p => p.Ubicacion).IsRequired();

        builder.ToTable("Objetos");
        }
    }
}