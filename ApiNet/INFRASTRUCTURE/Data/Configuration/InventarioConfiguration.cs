using CORE.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace INFRASTUCTURE.Data.Configuration
{
    public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .UseIdentityColumn();

            builder.Property(p => p.EspacioDisponible).IsRequired();
            builder.Property(p => p.Objetos).IsRequired();
            builder.Property(p => p.PesoTotal).IsRequired();

            builder.ToTable("Inventario");
        }
    }
}
