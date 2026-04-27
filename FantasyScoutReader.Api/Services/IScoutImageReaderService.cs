using FantasyScoutReader.Api.Models;

namespace FantasyScoutReader.Api.Services;

public interface IScoutImageReaderService
{
    Task<ScoutImageReadResponse> ReadImageAsync(ScoutImageReadRequest request);
}