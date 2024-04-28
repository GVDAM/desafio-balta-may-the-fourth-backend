using MayTheFour.Api.Features.Movies.Dtos;

namespace MayTheFour.Api.Entities
{
    public class VehicleBuilder
	{
		private string _name = "Star Voyager";
		private string _model = "SV-2";
		private string _manufacturer = "Galactic Starcraft";
		private string _costInCredits = "500000";
		private string _length = "120 meters";
		private string _maxSpeed = "950 km/h";
		private string _crew = "5";
		private string _passengers = "30";
		private string _cargoCapacity = "150000 kg";
		private string _consumables = "2 years";
		private string _vehicleClass = "Cruiser";
		private List<MovieReference> _movies = new List<MovieReference>();

		public VehicleBuilder WithName(string name)
		{
			_name = name;
			return this;
		}

		public VehicleBuilder WithModel(string model)
		{
			_model = model;
			return this;
		}

		public VehicleBuilder WithManufacturer(string manufacturer)
		{
			_manufacturer = manufacturer;
			return this;
		}

		public VehicleBuilder WithCostInCredits(string costInCredits)
		{
			_costInCredits = costInCredits;
			return this;
		}

		public VehicleBuilder WithLength(string length)
		{
			_length = length;
			return this;
		}

		public VehicleBuilder WithMaxSpeed(string maxSpeed)
		{
			_maxSpeed = maxSpeed;
			return this;
		}

		public VehicleBuilder WithCrew(string crew)
		{
			_crew = crew;
			return this;
		}

		public VehicleBuilder WithPassengers(string passengers)
		{
			_passengers = passengers;
			return this;
		}

		public VehicleBuilder WithCargoCapacity(string cargoCapacity)
		{
			_cargoCapacity = cargoCapacity;
			return this;
		}

		public VehicleBuilder WithConsumables(string consumables)
		{
			_consumables = consumables;
			return this;
		}

		public VehicleBuilder WithClass(string vehicleClass)
		{
			_vehicleClass = vehicleClass;
			return this;
		}

		public VehicleBuilder WithMovies(List<MovieReference> movies)
		{
			_movies = movies;
			return this;
		}

		public Vehicle Build()
		{
			return new Vehicle(
				0,
				_name,
				_model,
				_manufacturer,
				_costInCredits,
				_length,
				_maxSpeed,
				_crew,
				_passengers,
				_cargoCapacity,
				_consumables,
				_vehicleClass,
				_movies);
		}
	}
}
