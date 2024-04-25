﻿using MayTheFour.Api.Entities.Shared;

namespace MayTheFour.Api.Entities;

public class Starship
{
	private static int LastId = 0;

	public int Id { get; private set; }
	public string Name { get; private set; } = string.Empty;
	public string Model { get; private set; } = string.Empty;
	public string Manufacturer { get; private set; } = string.Empty;
	public string CostInCredits { get; private set; } = string.Empty;
	public string Length { get; private set; } = string.Empty;
	public string MaxSpeed { get; private set; } = string.Empty;
	public string Crew { get; private set; } = string.Empty;
	public string Passengers { get; private set; } = string.Empty;
	public string CargoCapacity { get; private set; } = string.Empty;
	public string HyperdriveRating { get; private set; } = string.Empty;
	public string Mglt { get; private set; } = string.Empty;
	public string Consumables { get; private set; } = string.Empty;
	public string Class { get; private set; } = string.Empty;
	public List<MovieReference> Movies { get; private set; } = new List<MovieReference>();

	private Starship() { }

	private Starship(
		int id,
		string name,
		string model,
		string manufacturer,
		string costInCredits,
		string length,
		string maxSpeed,
		string crew,
		string passengers,
		string cargoCapacity,
		string hyperdriveRating,
		string mglt,
		string consumables,
		string startshipClass,
		List<MovieReference> movies)
	{
		Id = id;
		Name = name;
		Model = model;
		Manufacturer = manufacturer;
		CostInCredits = costInCredits;
		Length = length;
		MaxSpeed = maxSpeed;
		Crew = crew;
		Passengers = passengers;
		CargoCapacity = cargoCapacity;
		HyperdriveRating = hyperdriveRating;
		Mglt = mglt;
		Consumables = consumables;
		Class = startshipClass;
		Movies = new List<MovieReference>();

		AddMovieReferences(movies);
	}

	public static Starship New(
		string name,
		string model,
		string manufacturer,
		string costInCredits,
		string length,
		string maxSpeed,
		string crew,
		string passengers,
		string cargoCapacity,
		string hyperdriveRating,
		string mglt,
		string consumables,
		string startshipClass,
		List<MovieReference> movies)
	{
		LastId++;

		return new Starship(
			LastId,
			name,
			model,
			manufacturer,
			costInCredits,
			length,
			maxSpeed,
			crew,
			passengers,
			cargoCapacity,
			hyperdriveRating,
			mglt,
			consumables,
			startshipClass,
			movies);
	}

	public void AddMovieReferences(List<MovieReference>? movieReferences)
	{
		if (movieReferences != null)
			Movies.AddRange(movieReferences);
	}
}
