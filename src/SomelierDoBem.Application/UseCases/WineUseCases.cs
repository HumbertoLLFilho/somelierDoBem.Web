using SomelierDoBem.Application.DTOs;
using SomelierDoBem.Domain.Entities;
using SomelierDoBem.Domain.Interfaces;

namespace SomelierDoBem.Application.UseCases;

public class GetAllWinesUseCase
{
    private readonly IWineRepository _repository;

    public GetAllWinesUseCase(IWineRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<WineDto>> ExecuteAsync()
    {
        var wines = await _repository.GetAllAsync();
        return wines.Select(w => new WineDto
        {
            Id = w.Id,
            Name = w.Name,
            Variety = w.Variety,
            Year = w.Year,
            Region = w.Region,
            Country = w.Country,
            Description = w.Description,
            Color = w.Color,
            Acidity = w.Acidity
        });
    }
}

public class GetWineByIdUseCase
{
    private readonly IWineRepository _repository;

    public GetWineByIdUseCase(IWineRepository repository)
    {
        _repository = repository;
    }

    public async Task<WineDto?> ExecuteAsync(Guid id)
    {
        var wine = await _repository.GetByIdAsync(id);
        if (wine == null) return null;

        return new WineDto
        {
            Id = wine.Id,
            Name = wine.Name,
            Variety = wine.Variety,
            Year = wine.Year,
            Region = wine.Region,
            Country = wine.Country,
            Description = wine.Description,
            Color = wine.Color,
            Acidity = wine.Acidity
        };
    }
}

public class CreateWineUseCase
{
    private readonly IWineRepository _repository;

    public CreateWineUseCase(IWineRepository repository)
    {
        _repository = repository;
    }

    public async Task<WineDto> ExecuteAsync(CreateWineDto dto)
    {
        var wine = new Wine
        {
            Name = dto.Name,
            Variety = dto.Variety,
            Year = dto.Year,
            Region = dto.Region,
            Country = dto.Country,
            Description = dto.Description,
            Color = dto.Color,
            Acidity = dto.Acidity
        };

        await _repository.AddAsync(wine);

        return new WineDto
        {
            Id = wine.Id,
            Name = wine.Name,
            Variety = wine.Variety,
            Year = wine.Year,
            Region = wine.Region,
            Country = wine.Country,
            Description = wine.Description,
            Color = wine.Color,
            Acidity = wine.Acidity
        };
    }
}

public class UpdateWineUseCase
{
    private readonly IWineRepository _repository;

    public UpdateWineUseCase(IWineRepository repository)
    {
        _repository = repository;
    }

    public async Task ExecuteAsync(UpdateWineDto dto)
    {
        var wine = await _repository.GetByIdAsync(dto.Id);
        if (wine == null) throw new Exception("Wine not found");

        wine.Name = dto.Name;
        wine.Variety = dto.Variety;
        wine.Year = dto.Year;
        wine.Region = dto.Region;
        wine.Country = dto.Country;
        wine.Description = dto.Description;
        wine.Color = dto.Color;
        wine.Acidity = dto.Acidity;

        await _repository.UpdateAsync(wine);
    }
}

public class DeleteWineUseCase
{
    private readonly IWineRepository _repository;

    public DeleteWineUseCase(IWineRepository repository)
    {
        _repository = repository;
    }

    public async Task ExecuteAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
    }
}
