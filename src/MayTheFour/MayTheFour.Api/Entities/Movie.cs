using MayTheFour.Api.Features.Characters.Dtos;
using MayTheFour.Api.Features.Planets.Dtos;
using MayTheFour.Api.Features.Starships.Dtos;
using MayTheFour.Api.Features.Vehicles.Dtos;

namespace MayTheFour.Api.Entities
{
	public class Movie
	{
		public int Id { get; private set; }
		public string Title { get; private set; } = string.Empty;
		public string Episode { get; private set; } = string.Empty;
		public string OpeningCrawl { get; private set; } = string.Empty;
		public string Director { get; private set; } = string.Empty;
		public string Producer { get; private set; } = string.Empty;
		public string ReleaseDate { get; private set; } = string.Empty;
		public List<CharacterReference> Characters { get; private set; } = new List<CharacterReference>();
		public List<PlanetReference> Planets { get; private set; } = new List<PlanetReference>();
		public List<VehicleReference> Vehicles { get; private set; } = new List<VehicleReference>();
		public List<StarshipReference> Starships { get; private set; } = new List<StarshipReference>();

		public Movie() { }

		public Movie(
			int id,
			string title,
			string episode,
			string openingCrawl,
			string director,
			string producer,
			string releaseDate,
			List<CharacterReference> characters,
			List<PlanetReference> planets,
			List<VehicleReference> vehicles,
			List<StarshipReference> starships)
		{
			Id = id;
			Title = title;
			Episode = episode;
			OpeningCrawl = openingCrawl;
			Director = director;
			Producer = producer;
			ReleaseDate = releaseDate;
			Characters = characters;
			Planets = planets;
			Vehicles = vehicles;
			Starships = starships;
		}
	}
}
