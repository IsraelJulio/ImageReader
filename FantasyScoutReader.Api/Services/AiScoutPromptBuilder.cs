namespace FantasyScoutReader.Api.Services;

public class AiScoutPromptBuilder : IAiScoutPromptBuilder
{
    public string BuildPrompt(int rodadaId, int numeroDaRodada)
    {
        return $$"""
    Você é uma IA especializada em leitura de imagens de súmulas de futebol/futsal.

    Sua tarefa é analisar a imagem enviada e extrair os scouts dos jogadores.

    =========================
    🔤 TRADUÇÃO DE ABREVIAÇÕES
    =========================

    Interprete as colunas da imagem da seguinte forma:

    G = Gol
    Ass = Assistência
    Fin = Finalização
    Des = Desarme
    CA = Cartão Amarelo
    CV = Cartão Vermelho

    Outras possíveis abreviações:
    FS = Falta Sofrida
    FC = Falta Cometida
    IMP = Impedimento
    DP = Defesa de Pênalti
    PP = Pênalti Perdido
    Deg = Finalização defendida
    Fora = Finalização para fora

    =========================
    🎯 REGRAS IMPORTANTES
    =========================

    - Cada linha da tabela representa um jogador
    - Você deve mapear corretamente cada abreviação para o campo correspondente
    - Se um valor não existir, use 0
    - Não invente dados
    - Não misture jogadores entre times
    - Use números inteiros ou decimais

    =========================
    📦 FORMATO DE SAÍDA
    =========================

    Retorne APENAS JSON válido:

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

    Retorne SOMENTE o JSON.
    """;
    }
}