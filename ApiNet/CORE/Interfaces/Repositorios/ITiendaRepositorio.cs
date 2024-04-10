namespace CORE.Interfaces.Repositorios;
public interface ITiendaRepository : IBaseRepository<Tienda>
{
    Task<Tienda> GetTiendaByIdAsync(int id);
    Task<IEnumerable<Tienda>> GetAllTiendasAsync();
    Task AddTiendaAsync(Tienda tienda);
    Task UpdateTiendaAsync(Tienda tienda);
    Task DeleteTiendaAsync(int id);
}