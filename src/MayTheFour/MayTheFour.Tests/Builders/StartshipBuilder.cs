using MayTheFour.Api.Features.Movies.Dtos;

namespace MayTheFour.Api.Entities
{
    public class StarshipBuilder
	{
		private string _name = "Galactic Explorer";
		private string _model = "GX-3";
		private string _manufacturer = "Interstellar Shipworks";
		private string _costInCredits = "800000";
		private string _length = "85 meters";
		private string _maxSpeed = "880 km/h";
		private string _crew = "10";
		private string _passengers = "40";
		private string _cargoCapacity = "200000 kg";
		private string _hyperdriveRating = "1.5";
		private string _mglt = "70";
		private string _consumables = "6 months";
		private string _classe = "Explorer";
		private List<MovieReference> _movies = new List<MovieReference>();

		public StarshipBuilder WithName(string name)
		{
			_name = name;
			return this;
		}

		public StarshipBuilder WithModel(string model)
		{
			_model = model;
			return this;
		}

		public StarshipBuilder WithManufacturer(string manufacturer)
		{
			_manufacturer = manufacturer;
			return this;
		}

		public StarshipBuilder WithCostInCredits(string costInCredits)
		{
			_costInCredits = costInCredits;
			return this;
		}

		public StarshipBuilder WithLength(string length)
		{
			_length = length;
			return this;
		}

		public StarshipBuilder WithMaxSpeed(string maxSpeed)
		{
			_maxSpeed = maxSpeed;
			return this;
		}

		public StarshipBuilder WithCrew(string crew)
		{
			_crew = crew;
			return this;
		}

		public StarshipBuilder WithPassengers(string passengers)
		{
			_passengers = passengers;
			return this;
		}

		public StarshipBuilder WithCargoCapacity(string cargoCapacity)
		{
			_cargoCapacity = cargoCapacity;
			return this;
		}

		public StarshipBuilder WithHyperdriveRating(string hyperdriveRating)
		{
			_hyperdriveRating = hyperdriveRating;
			return this;
		}

		public StarshipBuilder WithMglt(string mglt)
		{
			_mglt = mglt;
			return this;
		}

		public StarshipBuilder WithConsumables(string consumables)
		{
			_consumables = consumables;
			return this;
		}

		public StarshipBuilder WithClass(string classe)
		{
			_classe = classe;
			return this;
		}

		public StarshipBuilder WithMovies(List<MovieReference> movies)
		{
			_movies = movies;
			return this;
		}

		public Starship Build()
		{
			return new Starship(
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
				_hyperdriveRating,
				_mglt,
				_consumables,
				_classe,
				_movies);
		}
	}
}
