using MayTheFour.Api.Entities;
using MayTheFour.Api.Features.Movies.Dtos;

namespace MayTheFour.Tests;

[TestClass]
public class VehicleTest
{
	[TestMethod]
	public void Should_create_vehicle()
	{
		// Arrange
		var name = "Star Voyager";
		var model = "SV-2";
		var manufacturer = "Galactic Starcraft";
		var costInCredits = "500000";
		var length = "120 meters";
		var maxSpeed = "950 km/h";
		var crew = "5";
		var passengers = "30";
		var cargoCapacity = "150000 kg";
		var consumables = "2 years";
		var vehicleClass = "Cruiser";

		var galacticMovie = new MovieReference(1, "The Return of the Voyager");
		var edgeMovie = new MovieReference(2, "Voyager's Endgame");
		var movies = new List<MovieReference>() { galacticMovie, edgeMovie };

		var builder = new VehicleBuilder()
			.WithName(name)
			.WithModel(model)
			.WithManufacturer(manufacturer)
			.WithCostInCredits(costInCredits)
			.WithLength(length)
			.WithMaxSpeed(maxSpeed)
			.WithCrew(crew)
			.WithPassengers(passengers)
			.WithCargoCapacity(cargoCapacity)
			.WithConsumables(consumables)
			.WithClass(vehicleClass)
			.WithMovies(movies);

		// Act
		var vehicle = builder.Build();

		// Assert
		Assert.IsNotNull(vehicle);
		Assert.IsNotNull(vehicle.Id);
		Assert.AreEqual(name, vehicle.Name);
		Assert.AreEqual(model, vehicle.Model);
		Assert.AreEqual(manufacturer, vehicle.Manufacturer);
		Assert.AreEqual(costInCredits, vehicle.CostInCredits);
		Assert.AreEqual(length, vehicle.Length);
		Assert.AreEqual(maxSpeed, vehicle.MaxSpeed);
		Assert.AreEqual(crew, vehicle.Crew);
		Assert.AreEqual(passengers, vehicle.Passengers);
		Assert.AreEqual(cargoCapacity, vehicle.CargoCapacity);
		Assert.AreEqual(consumables, vehicle.Consumables);
		Assert.AreEqual(vehicleClass, vehicle.Class);

		Assert.AreEqual(2, vehicle.Movies.Count);

		var firstMovie = vehicle.Movies[0];
		Assert.AreEqual(galacticMovie.Id, firstMovie.Id);
		Assert.AreEqual(galacticMovie.Title, firstMovie.Title);

		var secondMovie = vehicle.Movies[1];
		Assert.AreEqual(edgeMovie.Id, secondMovie.Id);
		Assert.AreEqual(edgeMovie.Title, secondMovie.Title);
	}
}
