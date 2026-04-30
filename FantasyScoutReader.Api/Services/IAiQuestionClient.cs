namespace FantasyScoutReader.Api.Services;

public interface IAiQuestionClient
{
    Task<string> AskAsync(string question);
}