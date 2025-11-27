using SomelierDoBem.Domain.Entities;

namespace SomelierDoBem.Domain.Interfaces;

public interface IWineRepository
{
    Task<IEnumerable<Wine>> GetAllAsync();
    Task<Wine?> GetByIdAsync(Guid id);
    Task AddAsync(Wine wine);
    Task UpdateAsync(Wine wine);
    Task DeleteAsync(Guid id);
}
