using MarcadorDePonto.Infra;
using MarcadorDePonto.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarcadorDePonto.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PontosController(ApplicationDbContext context) : ControllerBase
{
    private readonly ApplicationDbContext _context = context;

    [HttpPost]
    public async Task<IActionResult> RegistrarPonto([FromBody] PontoDto pontoDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var ponto = new Ponto
        {
            Data = pontoDto.Data.Date,
            Entrada = pontoDto.Entrada,
            Saida = pontoDto.Saida
        };

        _context.Pontos.Add(ponto);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetPonto), new { id = ponto.Id }, ponto);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Ponto>> GetPonto(int id)
    {
        var ponto = await _context.Pontos.FindAsync(id);

        if (ponto == null)
            return NotFound();

        return ponto;
    }
}

public record PontoDto(DateTime Data, TimeSpan Entrada, TimeSpan Saida);