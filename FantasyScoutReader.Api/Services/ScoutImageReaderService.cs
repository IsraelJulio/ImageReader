using FantasyScoutReader.Api.Models;

namespace FantasyScoutReader.Api.Services;

public class ScoutImageReaderService : IScoutImageReaderService
{
    public async Task<ScoutImageReadResponse> ReadImageAsync(ScoutImageReadRequest request)
    {
        await Task.Delay(500);

        return new ScoutImageReadResponse
        {
            Success = true,
            Message = "Imagem lida com sucesso. Resultado mockado por enquanto.",
            Scouts =
            [
                new RodadaRequest
                {
                    Nome = "Jogador Exemplo",
                    JogadorId = 0,
                    EstatisticaId = 0,
                    RodadaId = request.RodadaId,
                    NumeroDaRodada = request.NumeroDaRodada,
                    Gol = 1,
                    Assistencia = 1,
                    Finalizacao = 3,
                    Desarme = 2,
                    CAMarelo = 1
                }
            ]
        };
    }
}