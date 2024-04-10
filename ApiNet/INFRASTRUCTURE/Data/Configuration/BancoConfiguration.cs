using System.Threading.Tasks;
using CORE.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class BancoConfiguration : IEntityTypeConfiguration<Banco>
    {
        public void Configure(EntityTypeBuilder<Banco> builder){
            
           builder
            .HasKey(x => x.Id);

        builder
            .Property(x => x.Id)
            .UseIdentityColumn();

        builder.Property(p => p.CuentaBancaria).IsRequired().HasMaxLength(255);
        builder.Property(p => p.Intereses).IsRequired();
        builder.Property(p => p.Prestamos).IsRequired();
        builder.Property(p => p.Seguridad).IsRequired();

        builder.ToTable("Banco");
        }
    }
}