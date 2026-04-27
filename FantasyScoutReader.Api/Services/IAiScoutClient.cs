namespace FantasyScoutReader.Api.Services;

public interface IAiScoutClient
{
    Task<string> ReadScoutImageAsync(IFormFile image, string prompt);
}