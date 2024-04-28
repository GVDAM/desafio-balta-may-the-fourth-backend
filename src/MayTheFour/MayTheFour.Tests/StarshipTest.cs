using MayTheFour.Api.Entities;
using MayTheFour.Api.Features.Movies.Dtos;

namespace MayTheFour.Tests;

[TestClass]
public class StarshipTest
{
	[TestMethod]
	public void Should_create_starship()
	{
		// Arrange
		var name = "Galactic Explorer";
		var model = "GX-3";
		var manufacturer = "Interstellar Shipworks";
		var costInCredits = "800000";
		var length = "85 meters";
		var maxSpeed = "880 km/h";
		var crew = "10";
		var passengers = "40";
		var cargoCapacity = "200000 kg";
		var hyperdriveRating = "1.5";
		var mglt = "70";
		var consumables = "6 months";
		var startsipClass = "Explorer";

		var galacticMovie = new MovieReference(1, "The Return of the Voyager");
		var edgeMovie = new MovieReference(2, "Voyager's Endgame");
		var movies = new List<MovieReference>() { galacticMovie, edgeMovie };

		var builder = new StarshipBuilder()
			.WithName(name)
			.WithModel(model)
			.WithManufacturer(manufacturer)
			.WithCostInCredits(costInCredits)
			.WithLength(length)
			.WithMaxSpeed(maxSpeed)
			.WithCrew(crew)
			.WithPassengers(passengers)
			.WithCargoCapacity(cargoCapacity)
			.WithHyperdriveRating(hyperdriveRating)
			.WithMglt(mglt)
			.WithConsumables(consumables)
			.WithClass(startsipClass)
			.WithMovies(movies);

		// Act
		var starship = builder.Build();

		// Assert
		Assert.IsNotNull(starship);
		Assert.IsNotNull(starship.Id);
		Assert.AreEqual(name, starship.Name);
		Assert.AreEqual(model, starship.Model);
		Assert.AreEqual(manufacturer, starship.Manufacturer);
		Assert.AreEqual(costInCredits, starship.CostInCredits);
		Assert.AreEqual(length, starship.Length);
		Assert.AreEqual(maxSpeed, starship.MaxSpeed);
		Assert.AreEqual(crew, starship.Crew);
		Assert.AreEqual(passengers, starship.Passengers);
		Assert.AreEqual(cargoCapacity, starship.CargoCapacity);
		Assert.AreEqual(hyperdriveRating, starship.HyperdriveRating);
		Assert.AreEqual(mglt, starship.Mglt);
		Assert.AreEqual(consumables, starship.Consumables);
		Assert.AreEqual(startsipClass, starship.Class);

		Assert.AreEqual(2, starship.Movies.Count);

		var firstMovie = starship.Movies[0];
		Assert.AreEqual(galacticMovie.Id, firstMovie.Id);
		Assert.AreEqual(galacticMovie.Title, firstMovie.Title);

		var secondtMovie = starship.Movies[1];
		Assert.AreEqual(secondtMovie.Id, edgeMovie.Id);
		Assert.AreEqual(secondtMovie.Title, edgeMovie.Title);
	}
}
