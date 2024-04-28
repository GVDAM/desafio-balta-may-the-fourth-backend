using MayTheFour.Api.Features.Movies.Dtos;
using MayTheFour.Api.Features.Planets.Dtos;

namespace MayTheFour.Api.Entities
{
	public class Character
	{
		public int Id { get; private set; }
		public string Name { get; private set; } = string.Empty;
		public string Height { get; private set; } = string.Empty;
		public string Weight { get; private set; } = string.Empty;
		public string HairColor { get; private set; } = string.Empty;
		public string SkinColor { get; private set; } = string.Empty;
		public string EyeColor { get; private set; } = string.Empty;
		public string BirthYear { get; private set; } = string.Empty;
		public string Gender { get; private set; } = string.Empty;
		public List<PlanetReference> Planets { get; private set; } = new List<PlanetReference>();
		public List<MovieReference> Movies { get; private set; } = new List<MovieReference>();

		public Character() { }

		public Character(
			int id,
			string name,
			string height,
			string weight,
			string hairColor,
			string skinColor,
			string eyeColor,
			string birthYear,
			string gender,
			List<PlanetReference> planets,
			List<MovieReference> movies)
		{
			Id = id;
			Name = name;
			Height = height;
			Weight = weight;
			HairColor = hairColor;
			SkinColor = skinColor;
			EyeColor = eyeColor;
			BirthYear = birthYear;
			Gender = gender;
			Planets = planets;
			Movies = movies;
		}
	}
}
