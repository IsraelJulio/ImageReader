namespace FantasyScoutReader.Api.Models;

public class ScoutImageReadResponse
{
    public bool Success { get; set; }

    public string? Message { get; set; }

    public List<RodadaRequest> Scouts { get; set; } = new();
}