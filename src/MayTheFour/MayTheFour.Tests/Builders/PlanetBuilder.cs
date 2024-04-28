using MayTheFour.Api.Features.Characters.Dtos;
using MayTheFour.Api.Features.Movies.Dtos;

namespace MayTheFour.Api.Entities
{
	public class PlanetBuilder
	{
		private string _name = "Planetara";
		private string _rotationPeriod = "24 hours";
		private string _orbitalPeriod = "365 days";
		private string _diameter = "12742 km";
		private string _climate = "temperate";
		private string _gravity = "1 standard";
		private string _terrain = "forests, mountains, rivers";
		private string _surfaceWater = "70%";
		private string _population = "2 billion";
		private List<CharacterReference> _characters = new List<CharacterReference>();
		private List<MovieReference> _movies = new List<MovieReference>();

		public PlanetBuilder WithName(string name)
		{
			_name = name;
			return this;
		}

		public PlanetBuilder WithRotationPeriod(string rotationPeriod)
		{
			_rotationPeriod = rotationPeriod;
			return this;
		}

		public PlanetBuilder WithOrbitalPeriod(string orbitalPeriod)
		{
			_orbitalPeriod = orbitalPeriod;
			return this;
		}

		public PlanetBuilder WithDiameter(string diameter)
		{
			_diameter = diameter;
			return this;
		}

		public PlanetBuilder WithClimate(string climate)
		{
			_climate = climate;
			return this;
		}

		public PlanetBuilder WithGravity(string gravity)
		{
			_gravity = gravity;
			return this;
		}

		public PlanetBuilder WithTerrain(string terrain)
		{
			_terrain = terrain;
			return this;
		}

		public PlanetBuilder WithSurfaceWater(string surfaceWater)
		{
			_surfaceWater = surfaceWater;
			return this;
		}

		public PlanetBuilder WithPopulation(string population)
		{
			_population = population;
			return this;
		}

		public PlanetBuilder WithCharacters(List<CharacterReference> characters)
		{
			_characters = characters;
			return this;
		}

		public PlanetBuilder WithMovies(List<MovieReference> movies)
		{
			_movies = movies;
			return this;
		}

		public Planet Build()
		{
			return new Planet(
				0,
				_name,
				_rotationPeriod,
				_orbitalPeriod,
				_diameter,
				_climate,
				_gravity,
				_terrain,
				_surfaceWater,
				_population,
				_characters,
				_movies);
		}
	}
}
