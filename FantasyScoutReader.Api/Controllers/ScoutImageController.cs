using FantasyScoutReader.Api.Models;
using FantasyScoutReader.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace FantasyScoutReader.Api.Controllers;

[ApiController]
[Route("api/scout-image")]
public class ScoutImageController : ControllerBase
{
    private readonly IScoutImageReaderService _scoutImageReaderService;

    public ScoutImageController(IScoutImageReaderService scoutImageReaderService)
    {
        _scoutImageReaderService = scoutImageReaderService;
    }

    [HttpPost("read")]
    [Consumes("multipart/form-data")]
    public async Task<ActionResult<ScoutImageReadResponse>> ReadImage([FromForm] ScoutImageReadRequest request)
    {
        if (request.Image == null || request.Image.Length == 0)
        {
            return BadRequest("Nenhuma imagem foi enviada.");
        }

        var result = await _scoutImageReaderService.ReadImageAsync(request);

        return Ok(result);
    }
}