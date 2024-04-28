using MayTheFour.Api.Features.Movies.Dtos;
using MayTheFour.Api.Features.Planets.Dtos;

namespace MayTheFour.Api.Entities
{
    public class CharacterBuilder
	{
		private string _name = "Luke Skywalker";
		private string _height = "172";
		private string _weight = "77";
		private string _hairColor = "Blond";
		private string _skinColor = "Fair";
		private string _eyeColor = "Blue";
		private string _birthYear = "19BBY";
		private string _gender = "Male";
		private List<PlanetReference> _planets = new List<PlanetReference>();
		private List<MovieReference> _movies = new List<MovieReference>();

		public CharacterBuilder WithName(string name)
		{
			_name = name;
			return this;
		}

		public CharacterBuilder WithHeight(string height)
		{
			_height = height;
			return this;
		}

		public CharacterBuilder WithWeight(string weight)
		{
			_weight = weight;
			return this;
		}

		public CharacterBuilder WithHairColor(string hairColor)
		{
			_hairColor = hairColor;
			return this;
		}

		public CharacterBuilder WithSkinColor(string skinColor)
		{
			_skinColor = skinColor;
			return this;
		}

		public CharacterBuilder WithEyeColor(string eyeColor)
		{
			_eyeColor = eyeColor;
			return this;
		}

		public CharacterBuilder WithBirthYear(string birthYear)
		{
			_birthYear = birthYear;
			return this;
		}

		public CharacterBuilder WithGender(string gender)
		{
			_gender = gender;
			return this;
		}

		public CharacterBuilder WithPlanets(List<PlanetReference> planets)
		{
			_planets = planets;
			return this;
		}

		public CharacterBuilder WithMovies(List<MovieReference> movies)
		{
			_movies = movies;
			return this;
		}

		public Character Build()
		{
			return new Character(
				0,
				_name,
				_height,
				_weight,
				_hairColor,
				_skinColor,
				_eyeColor,
				_birthYear,
				_gender,
				_planets,
				_movies);
		}
	}
}
