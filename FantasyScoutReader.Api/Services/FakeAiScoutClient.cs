namespace FantasyScoutReader.Api.Services;

public class FakeAiScoutClient : IAiScoutClient
{
    public async Task<string> ReadScoutImageAsync(IFormFile image, string prompt)
    {
        await Task.Delay(500);

        return """
        [
          {
            "nome": "Jogador Exemplo IA",
            "jogadorId": 0,
            "estatisticaId": 0,
            "rodadaId": 1,
            "numeroDaRodada": 1,
            "gol": 2,
            "assistencia": 1,
            "finalizacao": 4,
            "trave": 0,
            "defendida": 0,
            "fora": 2,
            "faltaSofrida": 1,
            "penalPerdido": 0,
            "defesaPenal": 0,
            "jssGol": 0,
            "golContra": 0,
            "cVermelho": 0,
            "cAMarelo": 1,
            "faltaCometida": 2,
            "tiroLivrePerdido": 0,
            "desarme": 3,
            "defesa": 0,
            "impedimento": 1,
            "torcida": 0
          }
        ]
        """;
    }
}