namespace FantasyScoutReader.Api.Services;

public class AiScoutPromptBuilder : IAiScoutPromptBuilder
{
    public string BuildPrompt(int rodadaId, int numeroDaRodada)
    {
        return $$"""
        Você é uma IA especializada em ler imagens de estatísticas de futebol/futsal.

        Leia a imagem enviada e extraia os scouts dos jogadores.

        Retorne APENAS um JSON válido, sem markdown, sem comentários e sem texto fora do JSON.

        O retorno deve ser uma lista no seguinte formato:

        [
          {
            "nome": "Nome do jogador",
            "jogadorId": 0,
            "estatisticaId": 0,
            "rodadaId": {{rodadaId}},
            "numeroDaRodada": {{numeroDaRodada}},
            "gol": 0,
            "assistencia": 0,
            "finalizacao": 0,
            "trave": 0,
            "defendida": 0,
            "fora": 0,
            "faltaSofrida": 0,
            "penalPerdido": 0,
            "defesaPenal": 0,
            "jssGol": 0,
            "golContra": 0,
            "cVermelho": 0,
            "cAMarelo": 0,
            "faltaCometida": 0,
            "tiroLivrePerdido": 0,
            "desarme": 0,
            "defesa": 0,
            "impedimento": 0,
            "torcida": 0
          }
        ]

        Regras:
        - Se um valor não aparecer na imagem, retorne 0.
        - Se não conseguir identificar o jogador, use "Jogador não identificado".
        - Não invente jogadores que não aparecem na imagem.
        - Não invente estatísticas.
        - Use números inteiros ou decimais.
        - O campo jogadorId deve ser 0 por enquanto.
        - O campo estatisticaId deve ser 0 por enquanto.
        """;
    }
}