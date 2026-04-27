namespace FantasyScoutReader.Api.Models;

public class ScoutImageReadRequest
{
    public IFormFile Image { get; set; } = null!;

    public int RodadaId { get; set; }

    public int NumeroDaRodada { get; set; }
}