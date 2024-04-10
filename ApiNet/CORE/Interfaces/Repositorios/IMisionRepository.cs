using CORE.Entidades;

namespace CORE.Interfaces.Repositorios;
public interface IMisionRepository : IBaseRepository<Misiones>
{
    Task<Misiones> GetMisionByIdAsync(int id);
    Task<IEnumerable<Misiones>> GetAllMisionesAsync();
    Task AddMisionAsync(Misiones mision);
    Task UpdateMisionAsync(Misiones mision);
    Task DeleteMisionAsync(int id);
}