using MayTheFour.Api.Entities;
using MayTheFour.Api.Features.Characters.Dtos;
using MayTheFour.Api.Features.Movies.Dtos;

namespace MayTheFour.Tests;

[TestClass]
public class PlanetTest
{
	[TestMethod]
	public void Should_create_planet()
	{
		// Arrange

		var name = "Planetara";
		var rotationPeriod = "24 hours";
		var orbitalPeriod = "365 days";
		var diameter = "12742 km";
		var climate = "temperate";
		var gravity = "1 standard";
		var terrain = "forests, mountains, rivers";
		var surfaceWater = "70%";
		var population = "2 billion";

		var kara = new CharacterReference(1, "Kara Zor-El");
		var jaxxon = new CharacterReference(2, "Jaxxon T. Tumperakki");
		var characters = new List<CharacterReference>() { kara, jaxxon };

		var galacticMovie = new MovieReference(1, "The Return of the Voyager");
		var edgeMovie = new MovieReference(2, "Voyager's Endgame");
		var movies = new List<MovieReference>() { galacticMovie, edgeMovie };

		var builder = new PlanetBuilder()
			.WithName(name)
			.WithRotationPeriod(rotationPeriod)
			.WithOrbitalPeriod(orbitalPeriod)
			.WithDiameter(diameter)
			.WithClimate(climate)
			.WithGravity(gravity)
			.WithTerrain(terrain)
			.WithSurfaceWater(surfaceWater)
			.WithPopulation(population)
			.WithCharacters(characters)
			.WithMovies(movies);

		// Act
		var planet = builder.Build();

		// Assert
		Assert.IsNotNull(planet);
		Assert.IsNotNull(planet.Id);
		Assert.AreEqual(name, planet.Name);
		Assert.AreEqual(rotationPeriod, planet.RotationPeriod);
		Assert.AreEqual(orbitalPeriod, planet.OrbitalPeriod);
		Assert.AreEqual(diameter, planet.Diameter);
		Assert.AreEqual(climate, planet.Climate);
		Assert.AreEqual(gravity, planet.Gravity);
		Assert.AreEqual(terrain, planet.Terrain);
		Assert.AreEqual(surfaceWater, planet.SurfaceWater);
		Assert.AreEqual(population, planet.Population);

		Assert.AreEqual(2, planet.Characters.Count);

		var firstCharacter = planet.Characters[0];
		Assert.AreEqual(kara.Id, firstCharacter.Id);
		Assert.AreEqual(kara.Title, firstCharacter.Title);

		var secondCharacter = planet.Characters[1];
		Assert.AreEqual(jaxxon.Id, secondCharacter.Id);
		Assert.AreEqual(jaxxon.Title, secondCharacter.Title);

		Assert.AreEqual(2, planet.Movies.Count);

		var firstMovie = planet.Movies[0];
		Assert.AreEqual(galacticMovie.Id, firstMovie.Id);
		Assert.AreEqual(galacticMovie.Title, firstMovie.Title);

		var secondMovie = planet.Movies[1];
		Assert.AreEqual(edgeMovie.Id, secondMovie.Id);
		Assert.AreEqual(edgeMovie.Title, secondMovie.Title);
	}
}
