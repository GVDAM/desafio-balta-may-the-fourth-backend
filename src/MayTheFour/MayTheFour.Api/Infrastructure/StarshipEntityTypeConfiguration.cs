using MayTheFour.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MayTheFour.Api.Infrastructure;

internal class StarshipEntityTypeConfiguration : IEntityTypeConfiguration<Starship>
{
	public void Configure(EntityTypeBuilder<Starship> builder)
	{
		builder.ToTable("starships", "may-the-fourth");

		builder.HasKey(x => x.Id);
		builder.Property(x => x.Id).ValueGeneratedNever();

		builder.Property(x => x.Name).IsRequired();
		builder.Property(x => x.Model).IsRequired();
		builder.Property(x => x.Manufacturer).IsRequired();
		builder.Property(x => x.CostInCredits).IsRequired();
		builder.Property(x => x.Length).IsRequired();
		builder.Property(x => x.MaxSpeed).IsRequired();
		builder.Property(x => x.Crew).IsRequired();
		builder.Property(x => x.Passengers).IsRequired();
		builder.Property(x => x.CargoCapacity).IsRequired();
		builder.Property(x => x.HyperdriveRating).IsRequired();
		builder.Property(x => x.Mglt).IsRequired();
		builder.Property(x => x.Consumables).IsRequired();
		builder.Property(x => x.Class).IsRequired();

		builder.OwnsMany(x => x.Movies, x =>
		{
			x.HasKey(x => x.Id);
			x.Property(x => x.Id).ValueGeneratedNever();

			x.Property(x => x.Title).IsRequired();
		});
	}
}
