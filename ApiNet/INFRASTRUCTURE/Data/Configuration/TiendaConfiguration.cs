using System.Threading.Tasks;
using CORE.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class TiendaConfiguration : IEntityTypeConfiguration<Tienda>
    {
        public void Configure(EntityTypeBuilder<Tienda> builder){
            
           builder
            .HasKey(x => x.Id);

        builder
            .Property(x => x.Id)
            .UseIdentityColumn();

        builder.Property(p => p.Precios).IsRequired().HasMaxLength(255);
        builder.Property(p => p.Stock).IsRequired();
        builder.Property(p => p.Dinero).IsRequired();

        builder.ToTable("Tienda");
        }
    }
}