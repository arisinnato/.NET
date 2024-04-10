namespace CORE.Interfaces.Repositorios;
public interface IEnemigoRepository : IBaseRepository<Enemigo>
{
    Task<Enemigo> GetEnemigoByIdAsync(int id);
    Task<IEnumerable<Enemigo>> GetAllEnemigosAsync();
    Task AddEnemigoAsync(Enemigo enemigo);
    Task UpdateEnemigoAsync(Enemigo enemigo);
    Task DeleteEnemigoAsync(int id);
}