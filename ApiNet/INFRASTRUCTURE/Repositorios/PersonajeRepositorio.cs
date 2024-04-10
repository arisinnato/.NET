using CORE.Entidades;
using CORE.Interfaces.Repositorios;
using Infrastructure.Data;
using INFRASTUCTURE.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace INFRASTUCTURE.Repositorios;

public class PersonajeRepositorio : BaseRepository<Personaje>
{
    public PersonajeRepositorio(AppDbContext context) : base(context)
    {
        
    }
    /*public override async Task<IEnumerable<Personaje>> 
    GetAllAsync() => await base.dbSet.Include(x => x.Personaje).ToListAsync();*/
}