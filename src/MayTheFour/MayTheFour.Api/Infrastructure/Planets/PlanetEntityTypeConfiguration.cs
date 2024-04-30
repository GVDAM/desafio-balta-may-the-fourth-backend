using MayTheFour.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MayTheFour.Api.Infrastructure.Planets;

internal class PlanetEntityTypeConfiguration : IEntityTypeConfiguration<Planet>
{
    public void Configure(EntityTypeBuilder<Planet> builder)
    {
        builder.ToTable("planets", "may-the-fourth");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.Property(x => x.Name);
        builder.Property(x => x.RotationPeriod);
        builder.Property(x => x.OrbitalPeriod);
        builder.Property(x => x.Diameter);
        builder.Property(x => x.Climate);
        builder.Property(x => x.Gravity);
        builder.Property(x => x.Terrain);
        builder.Property(x => x.SurfaceWater);
        builder.Property(x => x.Population);

        builder.OwnsMany(x => x.Characters, x =>
        {
            x.HasKey(x => x.Id);
            x.Property(x => x.Id).ValueGeneratedNever();

            x.Property(x => x.Title);
        });

        builder.OwnsMany(x => x.Movies, x =>
        {
            x.HasKey(x => x.Id);
            x.Property(x => x.Id).ValueGeneratedNever();

            x.Property(x => x.Title);
        });
    }
}
