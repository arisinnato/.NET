namespace CORE.Interfaces.Repositorios;

public interface IInventarioRepository : IBaseRepository<Inventario>
{
    Task<Inventario> GetInventarioByIdAsync(int id);
    Task<IEnumerable<Inventario>> GetAllInventariosAsync();
    Task AddInventarioAsync(Inventario inventario);
    Task UpdateInventarioAsync(int Inventario);
}