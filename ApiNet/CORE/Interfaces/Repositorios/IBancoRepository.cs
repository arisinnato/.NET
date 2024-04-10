namespace CORE.Interfaces.Repositorios;

public interface IBancoRepository : IBaseRepository<Banco>
{
    Task<Banco> GetBancoByIdAsync(int id);
    Task<IEnumerable<Banco>> GetAllBancosAsync();
    Task AddBancoAsync(Banco banco);
    Task UpdateBancoAsync(Banco banco);
    Task DeleteBancoAsync(int id);
}
