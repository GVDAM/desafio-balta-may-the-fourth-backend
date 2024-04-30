using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MayTheFour.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddNewEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "characters",
                schema: "may-the-fourth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Height = table.Column<string>(type: "TEXT", nullable: false),
                    Weight = table.Column<string>(type: "TEXT", nullable: false),
                    HairColor = table.Column<string>(type: "TEXT", nullable: false),
                    SkinColor = table.Column<string>(type: "TEXT", nullable: false),
                    EyeColor = table.Column<string>(type: "TEXT", nullable: false),
                    BirthYear = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_characters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                schema: "may-the-fourth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Episode = table.Column<string>(type: "TEXT", nullable: false),
                    OpeningCrawl = table.Column<string>(type: "TEXT", nullable: false),
                    Director = table.Column<string>(type: "TEXT", nullable: false),
                    Producer = table.Column<string>(type: "TEXT", nullable: false),
                    ReleaseDate = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "planets",
                schema: "may-the-fourth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    RotationPeriod = table.Column<string>(type: "TEXT", nullable: false),
                    OrbitalPeriod = table.Column<string>(type: "TEXT", nullable: false),
                    Diameter = table.Column<string>(type: "TEXT", nullable: false),
                    Climate = table.Column<string>(type: "TEXT", nullable: false),
                    Gravity = table.Column<string>(type: "TEXT", nullable: false),
                    Terrain = table.Column<string>(type: "TEXT", nullable: false),
                    SurfaceWater = table.Column<string>(type: "TEXT", nullable: false),
                    Population = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_planets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "characters_Movies",
                schema: "may-the-fourth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_characters_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_characters_Movies_characters_CharacterId",
                        column: x => x.CharacterId,
                        principalSchema: "may-the-fourth",
                        principalTable: "characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "characters_Planets",
                schema: "may-the-fourth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_characters_Planets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_characters_Planets_characters_CharacterId",
                        column: x => x.CharacterId,
                        principalSchema: "may-the-fourth",
                        principalTable: "characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "movies_Characters",
                schema: "may-the-fourth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_movies_Characters_movies_MovieId",
                        column: x => x.MovieId,
                        principalSchema: "may-the-fourth",
                        principalTable: "movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "movies_Planets",
                schema: "may-the-fourth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies_Planets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_movies_Planets_movies_MovieId",
                        column: x => x.MovieId,
                        principalSchema: "may-the-fourth",
                        principalTable: "movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StarshipReference",
                schema: "may-the-fourth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StarshipReference", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StarshipReference_movies_MovieId",
                        column: x => x.MovieId,
                        principalSchema: "may-the-fourth",
                        principalTable: "movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleReference",
                schema: "may-the-fourth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleReference", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleReference_movies_MovieId",
                        column: x => x.MovieId,
                        principalSchema: "may-the-fourth",
                        principalTable: "movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "planets_Characters",
                schema: "may-the-fourth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    PlanetId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_planets_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_planets_Characters_planets_PlanetId",
                        column: x => x.PlanetId,
                        principalSchema: "may-the-fourth",
                        principalTable: "planets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "planets_Movies",
                schema: "may-the-fourth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    PlanetId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_planets_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_planets_Movies_planets_PlanetId",
                        column: x => x.PlanetId,
                        principalSchema: "may-the-fourth",
                        principalTable: "planets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_characters_Movies_CharacterId",
                schema: "may-the-fourth",
                table: "characters_Movies",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_characters_Planets_CharacterId",
                schema: "may-the-fourth",
                table: "characters_Planets",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_movies_Characters_MovieId",
                schema: "may-the-fourth",
                table: "movies_Characters",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_movies_Planets_MovieId",
                schema: "may-the-fourth",
                table: "movies_Planets",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_planets_Characters_PlanetId",
                schema: "may-the-fourth",
                table: "planets_Characters",
                column: "PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_planets_Movies_PlanetId",
                schema: "may-the-fourth",
                table: "planets_Movies",
                column: "PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_StarshipReference_MovieId",
                schema: "may-the-fourth",
                table: "StarshipReference",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleReference_MovieId",
                schema: "may-the-fourth",
                table: "VehicleReference",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "characters_Movies",
                schema: "may-the-fourth");

            migrationBuilder.DropTable(
                name: "characters_Planets",
                schema: "may-the-fourth");

            migrationBuilder.DropTable(
                name: "movies_Characters",
                schema: "may-the-fourth");

            migrationBuilder.DropTable(
                name: "movies_Planets",
                schema: "may-the-fourth");

            migrationBuilder.DropTable(
                name: "planets_Characters",
                schema: "may-the-fourth");

            migrationBuilder.DropTable(
                name: "planets_Movies",
                schema: "may-the-fourth");

            migrationBuilder.DropTable(
                name: "StarshipReference",
                schema: "may-the-fourth");

            migrationBuilder.DropTable(
                name: "VehicleReference",
                schema: "may-the-fourth");

            migrationBuilder.DropTable(
                name: "characters",
                schema: "may-the-fourth");

            migrationBuilder.DropTable(
                name: "planets",
                schema: "may-the-fourth");

            migrationBuilder.DropTable(
                name: "movies",
                schema: "may-the-fourth");
        }
    }
}
