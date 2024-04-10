namespace CORE.Interfaces.Repositorios;

public interface IObjetoRepository : IBaseRepository<Objeto>
{
    Task<Objeto> GetObjetoByIdAsync(int id);
    Task<IEnumerable<Objeto>> GetAllObjetosAsync();
    Task AddObjetoAsync(Objeto objeto);
    Task UpdateObjetoAsync(Objeto objeto);
    Task DeleteObjetoAsync(int id);
}