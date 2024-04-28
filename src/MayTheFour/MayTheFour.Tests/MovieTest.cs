using MayTheFour.Api.Entities;
using MayTheFour.Api.Features.Characters.Dtos;
using MayTheFour.Api.Features.Planets.Dtos;
using MayTheFour.Api.Features.Starships.Dtos;
using MayTheFour.Api.Features.Vehicles.Dtos;

namespace MayTheFour.Tests;

[TestClass]
public class MovieTest
{
	[TestMethod]
	public void Should_create_movie()
	{
		// Arrange
		var title = "Star Voyager";
		var episode = "Episode I";
		var openingCrawl = "A long time ago in a galaxy far, far away...";
		var director = "George Lucas";
		var producer = "Gary Kurtz, Rick McCallum";
		var releaseDate = "May 25, 1977";

		var kara = new CharacterReference(1, "Kara Zor-El");
		var jaxxon = new CharacterReference(2, "Jaxxon T. Tumperakki");
		var characters = new List<CharacterReference>() { kara, jaxxon };

		var tatooine = new PlanetReference(1, "Tatooine");
		var dagobah = new PlanetReference(2, "Dagobah");
		var planets = new List<PlanetReference>() { tatooine, dagobah };

		var speedBike = new VehicleReference(1, "Speeder Bikes");
		var walkers = new VehicleReference(2, "AT-AT Walkers");
		var vehicles = new List<VehicleReference>() { speedBike, walkers };

		var falcon = new StarshipReference(1, "Millennium Falcon");
		var fighter = new StarshipReference(2, "TIE Fighter");
		var startShips = new List<StarshipReference>() { falcon, fighter };

		var builder = new MovieBuilder()
			.WithTitle(title)
			.WithEpisode(episode)
			.WithOpeningCrawl(openingCrawl)
			.WithDirector(director)
			.WithProducer(producer)
			.WithReleaseDate(releaseDate)
			.WithCharacters(characters)
			.WithPlanets(planets)
			.WithVehicles(vehicles)
			.WithStarship(startShips);

		// Act
		var movie = builder.Build();

		// Assert
		Assert.IsNotNull(movie);
		Assert.IsNotNull(movie.Id);
		Assert.AreEqual(title, movie.Title);
		Assert.AreEqual(episode, movie.Episode);
		Assert.AreEqual(openingCrawl, movie.OpeningCrawl);
		Assert.AreEqual(director, movie.Director);
		Assert.AreEqual(producer, movie.Producer);
		Assert.AreEqual(releaseDate, movie.ReleaseDate);

		Assert.AreEqual(2, movie.Characters.Count);

		var firstCharacter = movie.Characters[0];
		Assert.AreEqual(kara.Id, firstCharacter.Id);
		Assert.AreEqual(kara.Title, firstCharacter.Title);

		var secondCharacter = movie.Characters[1];
		Assert.AreEqual(jaxxon.Id, secondCharacter.Id);
		Assert.AreEqual(jaxxon.Title, secondCharacter.Title);

		Assert.AreEqual(2, movie.Planets.Count);

		var firstPlanet = movie.Planets[0];
		Assert.AreEqual(tatooine.Id, firstPlanet.Id);
		Assert.AreEqual(tatooine.Title, firstPlanet.Title);

		var secondPlanet = movie.Planets[1];
		Assert.AreEqual(dagobah.Id, secondPlanet.Id);
		Assert.AreEqual(dagobah.Title, secondPlanet.Title);
		
		Assert.AreEqual(2, movie.Vehicles.Count);

		var firstVehicle = movie.Vehicles[0];
		Assert.AreEqual(speedBike.Id, firstVehicle.Id);
		Assert.AreEqual(speedBike.Title, firstVehicle.Title);

		var secondVehicle = movie.Vehicles[1];
		Assert.AreEqual(walkers.Id, secondVehicle.Id);
		Assert.AreEqual(walkers.Title, secondVehicle.Title);
		
		Assert.AreEqual(2, movie.Starships.Count);

		var firstStarship = movie.Starships[0];
		Assert.AreEqual(falcon.Id, firstStarship.Id);
		Assert.AreEqual(falcon.Title, firstStarship.Title);

		var secondStarship = movie.Starships[1];
		Assert.AreEqual(fighter.Id, secondStarship.Id);
		Assert.AreEqual(fighter.Title, secondStarship.Title);
	}
}
