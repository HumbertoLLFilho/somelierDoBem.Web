namespace SomelierDoBem.Application.DTOs;

public class WineDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Variety { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Region { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public string Acidity { get; set; } = string.Empty;
}

public class CreateWineDto
{
    public string Name { get; set; } = string.Empty;
    public string Variety { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Region { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public string Acidity { get; set; } = string.Empty;
}

public class UpdateWineDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Variety { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Region { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public string Acidity { get; set; } = string.Empty;
}
