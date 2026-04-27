namespace FantasyScoutReader.Api.Services;

public interface IAiScoutPromptBuilder
{
    string BuildPrompt(int rodadaId, int numeroDaRodada);
}