namespace SomelierDoBem.Domain.Entities;

public class Wine
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Variety { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Region { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty; // Tinto, Branco, Rosé, etc.
    public string Acidity { get; set; } = string.Empty; // Baixa, Média, Alta

    public Wine()
    {
        Id = Guid.NewGuid();
    }
}
