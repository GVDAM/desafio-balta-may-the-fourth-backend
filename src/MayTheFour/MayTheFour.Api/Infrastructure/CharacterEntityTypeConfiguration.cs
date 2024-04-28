using MayTheFour.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MayTheFour.Api.Infrastructure;

internal class CharacterEntityTypeConfiguration : IEntityTypeConfiguration<Character>
{
	public void Configure(EntityTypeBuilder<Character> builder)
	{
		builder.ToTable("characters", "may-the-fourth");

		builder.HasKey(x => x.Id);
		builder.Property(x => x.Id).ValueGeneratedOnAdd();

		builder.Property(x => x.Name);
		builder.Property(x => x.Height);
		builder.Property(x => x.Weight);
		builder.Property(x => x.HairColor);
		builder.Property(x => x.SkinColor);
		builder.Property(x => x.EyeColor);
		builder.Property(x => x.BirthYear);
		builder.Property(x => x.Gender);

		builder.OwnsMany(x => x.Planets, x =>
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
