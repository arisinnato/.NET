using CORE.Entidades;
using CORE.Interfaces.Repositorios;
using Infrastructure.Data;
using INFRASTUCTURE.Data;

namespace INFRASTUCTURE.Repositorios;

public class EnemigoRepositorio : BaseRepository<Enemigo>
{
    public EnemigoRepositorio(AppDbContext context) : base(context)
    {

    }

}