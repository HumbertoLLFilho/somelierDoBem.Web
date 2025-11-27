using SomelierDoBem.Domain.Entities;
using SomelierDoBem.Domain.Interfaces;

namespace SomelierDoBem.Infrastructure.Persistence;

public class InMemoryWineRepository : IWineRepository
{
    private static readonly List<Wine> _wines = new();

    public InMemoryWineRepository()
    {
        if (!_wines.Any())
        {
            _wines.AddRange(new[]
            {
                new Wine { Name = "Cabernet Sauvignon", Variety = "Cabernet Sauvignon", Year = 2018, Region = "Napa Valley", Country = "USA", Description = "Full-bodied red wine." },
                new Wine { Name = "Merlot", Variety = "Merlot", Year = 2019, Region = "Bordeaux", Country = "France", Description = "Smooth and soft red wine." },
                new Wine { Name = "Chardonnay", Variety = "Chardonnay", Year = 2020, Region = "Sonoma", Country = "USA", Description = "Dry white wine." }
            });
        }
    }

    public Task<IEnumerable<Wine>> GetAllAsync()
    {
        return Task.FromResult<IEnumerable<Wine>>(_wines);
    }

    public Task<Wine?> GetByIdAsync(Guid id)
    {
        var wine = _wines.FirstOrDefault(w => w.Id == id);
        return Task.FromResult(wine);
    }

    public Task AddAsync(Wine wine)
    {
        _wines.Add(wine);
        return Task.CompletedTask;
    }

    public Task UpdateAsync(Wine wine)
    {
        var existingWine = _wines.FirstOrDefault(w => w.Id == wine.Id);
        if (existingWine != null)
        {
            existingWine.Name = wine.Name;
            existingWine.Variety = wine.Variety;
            existingWine.Year = wine.Year;
            existingWine.Region = wine.Region;
            existingWine.Country = wine.Country;
            existingWine.Description = wine.Description;
        }
        return Task.CompletedTask;
    }

    public Task DeleteAsync(Guid id)
    {
        var wine = _wines.FirstOrDefault(w => w.Id == id);
        if (wine != null)
        {
            _wines.Remove(wine);
        }
        return Task.CompletedTask;
    }
}
