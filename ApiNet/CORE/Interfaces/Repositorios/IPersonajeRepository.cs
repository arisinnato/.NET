using CORE.Entidades;

namespace CORE.Interfaces.Repositorios;
public interface IPersonajeRepository : IBaseRepository<Personaje>
{
    Task<Personaje> GetPersonajeByIdAsync(int id);
    Task<IEnumerable<Personaje>> GetAllPersonajesAsync();
    Task AddPersonajeAsync(Personaje personaje);
    Task UpdatePersonajeAsync(Personaje personaje);
    Task DeletePersonajeAsync(int id);
}