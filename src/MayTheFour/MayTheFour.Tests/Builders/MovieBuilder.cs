using MayTheFour.Api.Features.Characters.Dtos;
using MayTheFour.Api.Features.Planets.Dtos;
using MayTheFour.Api.Features.Starships.Dtos;
using MayTheFour.Api.Features.Vehicles.Dtos;

namespace MayTheFour.Api.Entities
{
	public class MovieBuilder
	{
		private string _title = "Star Voyager";
		private string _episode = "Episode I";
		private string _openingCrawl = "A long time ago in a galaxy far, far away...";
		private string _director = "George Lucas";
		private string _producer = "Gary Kurtz, Rick McCallum";
		private string _releaseDate = "May 25, 1977";
		private List<CharacterReference> _characters = new List<CharacterReference>();
		private List<PlanetReference> _planets = new List<PlanetReference>();
		private List<VehicleReference> _vehicles = new List<VehicleReference>();
		private List<StarshipReference> _starships = new List<StarshipReference>();

		public MovieBuilder WithTitle(string title)
		{
			_title = title;
			return this;
		}

		public MovieBuilder WithEpisode(string episode)
		{
			_episode = episode;
			return this;
		}

		public MovieBuilder WithOpeningCrawl(string openingCrawl)
		{
			_openingCrawl = openingCrawl;
			return this;
		}

		public MovieBuilder WithDirector(string director)
		{
			_director = director;
			return this;
		}

		public MovieBuilder WithProducer(string producer)
		{
			_producer = producer;
			return this;
		}

		public MovieBuilder WithReleaseDate(string releaseDate)
		{
			_releaseDate = releaseDate;
			return this;
		}

		public MovieBuilder WithCharacters(List<CharacterReference> characters)
		{
			_characters = characters;
			return this;
		}

		public MovieBuilder WithPlanets(List<PlanetReference> planets)
		{
			_planets = planets;
			return this;
		}

		public MovieBuilder WithVehicles(List<VehicleReference> vehicles)
		{
			_vehicles = vehicles;
			return this;
		}

		public MovieBuilder WithStarship(List<StarshipReference> starships)
		{
			_starships = starships;
			return this;
		}

		public Movie Build()
		{
			return new Movie(
				0,
				_title,
				_episode,
				_openingCrawl,
				_director,
				_producer,
				_releaseDate,
				_characters,
				_planets,
				_vehicles,
				_starships);
		}
	}
}
