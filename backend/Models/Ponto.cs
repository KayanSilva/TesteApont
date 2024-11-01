namespace MarcadorDePonto.Models;

public record Ponto
{
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public TimeSpan Entrada { get; set; }
    public TimeSpan Saida { get; set; }
}