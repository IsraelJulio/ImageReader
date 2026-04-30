using FantasyScoutReader.Api.Models;
using FantasyScoutReader.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace FantasyScoutReader.Api.Controllers;

[ApiController]
[Route("api/ai-question")]
public class AiQuestionController : ControllerBase
{
    private readonly IAiQuestionClient _aiQuestionClient;

    public AiQuestionController(IAiQuestionClient aiQuestionClient)
    {
        _aiQuestionClient = aiQuestionClient;
    }

    [HttpPost("ask")]
    public async Task<ActionResult<AiQuestionResponse>> Ask([FromBody] AiQuestionRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Question))
            return BadRequest("A pergunta é obrigatória.");

        var answer = await _aiQuestionClient.AskAsync(request.Question);

        return Ok(new AiQuestionResponse
        {
            Answer = answer
        });
    }
}