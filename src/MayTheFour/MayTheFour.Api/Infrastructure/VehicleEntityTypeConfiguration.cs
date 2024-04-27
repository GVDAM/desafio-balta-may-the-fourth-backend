using MayTheFour.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MayTheFour.Api.Infrastructure;

internal class VehicleEntityTypeConfiguration : IEntityTypeConfiguration<Vehicle>
{
	public void Configure(EntityTypeBuilder<Vehicle> builder)
	{
		builder.ToTable("vehicles", "may-the-fourth");

		builder.HasKey(x => x.Id);
		builder.Property(x => x.Id).ValueGeneratedOnAdd();

		builder.Property(x => x.Name);
		builder.Property(x => x.Model);
		builder.Property(x => x.Manufacturer);
		builder.Property(x => x.CostInCredits);
		builder.Property(x => x.Length);
		builder.Property(x => x.MaxSpeed);
		builder.Property(x => x.Crew);
		builder.Property(x => x.Passengers);
		builder.Property(x => x.CargoCapacity);
		builder.Property(x => x.Consumables);
		builder.Property(x => x.Class);

		builder.OwnsMany(x => x.Movies, x =>
		{
			x.HasKey(x => x.Id);
			x.Property(x => x.Id).ValueGeneratedNever();

			x.Property(x => x.Title);
		});
	}
}
