using MayTheFour.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MayTheFour.Api.Infrastructure;

internal class MovieEntityTypeConfiguration : IEntityTypeConfiguration<Movie>
{
	public void Configure(EntityTypeBuilder<Movie> builder)
	{
		builder.ToTable("movies", "may-the-fourth");

		builder.HasKey(x => x.Id);
		builder.Property(x => x.Id).ValueGeneratedOnAdd();

		builder.Property(x => x.Title);
		builder.Property(x => x.Episode);
		builder.Property(x => x.OpeningCrawl);
		builder.Property(x => x.Director);
		builder.Property(x => x.Producer);
		builder.Property(x => x.ReleaseDate);

		builder.OwnsMany(x => x.Characters, x =>
		{
			x.HasKey(x => x.Id);
			x.Property(x => x.Id).ValueGeneratedNever();

			x.Property(x => x.Title);
		});

		builder.OwnsMany(x => x.Planets, x =>
		{
			x.HasKey(x => x.Id);
			x.Property(x => x.Id).ValueGeneratedNever();

			x.Property(x => x.Title);
		});

		builder.OwnsMany(x => x.Vehicles, x =>
		{
			x.HasKey(x => x.Id);
			x.Property(x => x.Id).ValueGeneratedNever();

			x.Property(x => x.Title);
		});

		builder.OwnsMany(x => x.Starships, x =>
		{
			x.HasKey(x => x.Id);
			x.Property(x => x.Id).ValueGeneratedNever();

			x.Property(x => x.Title);
		});
	}
}
