using MarcadorDePonto.Models;
using Microsoft.EntityFrameworkCore;

namespace MarcadorDePonto.Infra;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Ponto> Pontos { get; set; }
}