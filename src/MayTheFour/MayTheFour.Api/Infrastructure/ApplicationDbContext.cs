using MayTheFour.Api.Entities;
using MayTheFour.Api.Infrastructure.Characters;
using MayTheFour.Api.Infrastructure.Movies;
using MayTheFour.Api.Infrastructure.Planets;
using MayTheFour.Api.Infrastructure.Starships;
using MayTheFour.Api.Infrastructure.Vehicles;
using Microsoft.EntityFrameworkCore;

namespace MayTheFour.Api.Infrastructure;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Starship> Starships { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Planet> Planets { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new StarshipEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new VehicleEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new CharacterEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new MovieEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new PlanetEntityTypeConfiguration());
    }
}
