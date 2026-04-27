namespace FantasyScoutReader.Api.Models;

public class RodadaRequest
{
    public string? Nome { get; set; }
    public int JogadorId { get; set; }
    public int EstatisticaId { get; set; }
    public int RodadaId { get; set; }
    public int NumeroDaRodada { get; set; }

    public float? Gol { get; set; }
    public float? Assistencia { get; set; }
    public float? Finalizacao { get; set; }
    public float? Trave { get; set; }
    public float? Defendida { get; set; }
    public float? Fora { get; set; }
    public float? FaltaSofrida { get; set; }
    public float? PenalPerdido { get; set; }
    public float? DefesaPenal { get; set; }
    public float? JSSGol { get; set; }
    public float? GolContra { get; set; }
    public float? CVermelho { get; set; }
    public float? CAMarelo { get; set; }
    public float? FaltaCometida { get; set; }
    public float? TiroLivrePerdido { get; set; }
    public float? Desarme { get; set; }
    public float? Defesa { get; set; }
    public float? Impedimento { get; set; }
    public float? Torcida { get; set; }
}