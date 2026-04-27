using FantasyScoutReader.Api.Models;
using Microsoft.Extensions.Options;
using OpenAI;
using OpenAI.Chat;

namespace FantasyScoutReader.Api.Services;

public class OpenAiScoutClient : IAiScoutClient
{
    private readonly OpenAIClient _client;

    public OpenAiScoutClient(IOptions<OpenAiSettings> settings)
    {
        _client = new OpenAIClient(settings.Value.ApiKey);
    }

    public async Task<string> ReadScoutImageAsync(IFormFile image, string prompt)
    {
        using var stream = image.OpenReadStream();
        using var ms = new MemoryStream();
        await stream.CopyToAsync(ms);

        var imageBytes = ms.ToArray();

        var chatClient = _client.GetChatClient("gpt-4.1");

        var response = await chatClient.CompleteChatAsync(
        [
            new UserChatMessage(
            [
                ChatMessageContentPart.CreateTextPart(prompt),
                ChatMessageContentPart.CreateImagePart(
                                                        BinaryData.FromBytes(imageBytes),
                                                        image.ContentType
                                                    )
            ])
        ]);

        var content = response.Value.Content.FirstOrDefault()?.Text;

        return content ?? "[]";
    }
}