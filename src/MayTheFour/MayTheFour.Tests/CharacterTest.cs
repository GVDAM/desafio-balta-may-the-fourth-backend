using MayTheFour.Api.Entities;
using MayTheFour.Api.Features.Movies.Dtos;
using MayTheFour.Api.Features.Planets.Dtos;

namespace MayTheFour.Tests;

[TestClass]
public class CharacterTest
{
	[TestMethod]
	public void Should_create_character()
	{
		// Arrange
		var name = "Luke Skywalker";
		var height = "172";
		var weight = "77";
		var hairColor = "Blond";
		var skinColor = "Fair";
		var eyeColor = "Blue";
		var birthYear = "19BBY";
		var gender = "Male";

		var tatooine = new PlanetReference(1, "Tatooine");
		var dagobah = new PlanetReference(2, "Dagobah");
		var planets = new List<PlanetReference>() { tatooine, dagobah };

		var galacticMovie = new MovieReference(1, "The Return of the Voyager");
		var edgeMovie = new MovieReference(2, "Voyager's Endgame");
		var movies = new List<MovieReference>() { galacticMovie, edgeMovie };

		var builder = new CharacterBuilder()
			.WithName(name)
			.WithHeight(height)
			.WithWeight(weight)
			.WithHairColor(hairColor)
			.WithSkinColor(skinColor)
			.WithEyeColor(eyeColor)
			.WithBirthYear(birthYear)
			.WithGender(gender)
			.WithPlanets(planets)
			.WithMovies(movies);

		// Act
		var character = builder.Build();

		// Assert
		Assert.IsNotNull(character);
		Assert.IsNotNull(character.Id);
		Assert.AreEqual(name, character.Name);
		Assert.AreEqual(height, character.Height);
		Assert.AreEqual(weight, character.Weight);
		Assert.AreEqual(hairColor, character.HairColor);
		Assert.AreEqual(skinColor, character.SkinColor);
		Assert.AreEqual(eyeColor, character.EyeColor);
		Assert.AreEqual(birthYear, character.BirthYear);
		Assert.AreEqual(gender, character.Gender);

		Assert.AreEqual(2, character.Planets.Count);

		var firstPlanet = character.Planets[0];
		Assert.AreEqual(tatooine.Id, firstPlanet.Id);
		Assert.AreEqual(tatooine.Title, firstPlanet.Title);

		var secondPlanet = character.Planets[1];
		Assert.AreEqual(dagobah.Id, secondPlanet.Id);
		Assert.AreEqual(dagobah.Title, secondPlanet.Title);

		Assert.AreEqual(2, character.Movies.Count);

		var firstMovie = character.Movies[0];
		Assert.AreEqual(galacticMovie.Id, firstMovie.Id);
		Assert.AreEqual(galacticMovie.Title, firstMovie.Title);

		var secondMovie = character.Movies[1];
		Assert.AreEqual(edgeMovie.Id, secondMovie.Id);
		Assert.AreEqual(edgeMovie.Title, secondMovie.Title);
	}
}
