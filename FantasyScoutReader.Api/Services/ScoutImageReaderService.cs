using System.Text.Json;
using FantasyScoutReader.Api.Models;

namespace FantasyScoutReader.Api.Services;

public class ScoutImageReaderService : IScoutImageReaderService
{
    private readonly IAiScoutPromptBuilder _promptBuilder;
    private readonly IAiScoutClient _aiScoutClient;

    public ScoutImageReaderService(
        IAiScoutPromptBuilder promptBuilder,
        IAiScoutClient aiScoutClient)
    {
        _promptBuilder = promptBuilder;
        _aiScoutClient = aiScoutClient;
    }

    public async Task<ScoutImageReadResponse> ReadImageAsync(ScoutImageReadRequest request)
    {
        var prompt = _promptBuilder.BuildPrompt(
            request.RodadaId,
            request.NumeroDaRodada);

        var aiJson = await _aiScoutClient.ReadScoutImageAsync(
            request.Image,
            prompt);

        aiJson = aiJson
            .Replace("```json", "")
            .Replace("```", "")
            .Trim();

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var scouts = JsonSerializer.Deserialize<List<RodadaRequest>>(aiJson, options);

        return new ScoutImageReadResponse
        {
            Success = true,
            Message = "Imagem processada pela IA.",
            Scouts = scouts ?? []
        };
    }
}