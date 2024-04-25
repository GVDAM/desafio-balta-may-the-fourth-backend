using MayTheFour.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace MayTheFour.Api.Infrastructure;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Starship> Starships { get; set; }
}
