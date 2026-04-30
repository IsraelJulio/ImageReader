using FantasyScoutReader.Api.Models;
using Microsoft.Extensions.Options;
using OpenAI;
using OpenAI.Chat;

namespace FantasyScoutReader.Api.Services;

public class OpenAiQuestionClient : IAiQuestionClient
{
    private readonly OpenAIClient _client;

    public OpenAiQuestionClient(IOptions<OpenAiSettings> settings)
    {
        _client = new OpenAIClient(settings.Value.ApiKey);
    }

    public async Task<string> AskAsync(string question)
    {
        var chatClient = _client.GetChatClient("gpt-4.1-mini");

        var response = await chatClient.CompleteChatAsync(
        [
            new SystemChatMessage("""
            Você é um assistente especializado em futebol, fantasy game e leitura de scouts.
            Responda de forma clara, objetiva e em português do Brasil.
            """),
            new UserChatMessage(question)
        ]);

        return response.Value.Content.FirstOrDefault()?.Text ?? string.Empty;
    }
}