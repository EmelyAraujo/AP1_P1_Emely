using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<Aportes> Aportes { get; set; }
    public Contexto(DbContextOptions <Contexto>options): base(options)
    {

    }
}