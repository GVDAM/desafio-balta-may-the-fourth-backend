using MayTheFour.Api.Features.Characters.Dtos;
using MayTheFour.Api.Features.Movies.Dtos;

namespace MayTheFour.Api.Entities
{
	public class Planet
	{
		public int Id { get; private set; }
		public string Name { get; private set; } = string.Empty;
		public string RotationPeriod { get; private set; } = string.Empty;
		public string OrbitalPeriod { get; private set; } = string.Empty;
		public string Diameter { get; private set; } = string.Empty;
		public string Climate { get; private set; } = string.Empty;
		public string Gravity { get; private set; } = string.Empty;
		public string Terrain { get; private set; } = string.Empty;
		public string SurfaceWater { get; private set; } = string.Empty;
		public string Population { get; private set; } = string.Empty;
		public List<CharacterReference> Characters { get; private set; } = new List<CharacterReference>();
		public List<MovieReference> Movies { get; private set; } = new List<MovieReference>();

		public Planet() { }

		public Planet(
			int id,
			string name,
			string rotationPeriod,
			string orbitalPeriod,
			string diameter,
			string climate,
			string gravity,
			string terrain,
			string surfaceWater,
			string population,
			List<CharacterReference> characters,
			List<MovieReference> movies)
		{
			Id = id;
			Name = name;
			RotationPeriod = rotationPeriod;
			OrbitalPeriod = orbitalPeriod;
			Diameter = diameter;
			Climate = climate;
			Gravity = gravity;
			Terrain = terrain;
			SurfaceWater = surfaceWater;
			Population = population;
			Characters = characters;
			Movies = movies;
		}
	}
}
