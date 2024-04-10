using System.Threading.Tasks;
using CORE.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class PersonajeConfiguration : IEntityTypeConfiguration<Personaje>
    {
        public void Configure(EntityTypeBuilder<Personaje> builder){
            
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nombre).IsRequired();
            builder.Property(p => p.Nivel).IsRequired();
            builder.Property(p => p.Salud).IsRequired();
            builder.Property(p => p.Energia).IsRequired();
            builder.Property(p => p.Fuerza).IsRequired();
            builder.Property(p => p.Inteligencia).IsRequired();
            builder.Property(p => p.Agilidad).IsRequired();
            builder.HasMany(p => p.Inventario).WithOne().HasForeignKey(o => o.Id);


            builder
                .ToTable("Personaje");
        }
        
    }
}